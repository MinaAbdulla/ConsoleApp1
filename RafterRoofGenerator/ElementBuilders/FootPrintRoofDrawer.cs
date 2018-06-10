namespace RafterRoofGenerator.ElementBuilders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Autodesk.Revit.DB;
    using RafterRoofGenerator.ElementBaseConstructors;
    using static RafterRoofGenerator.RevitEntities.RevitUnitConverter;

    class FootPrintRoofBuilder : IDrawer
    {

        private Level roofLevel;
        private RoofType roofType;
        private CurveArray roofCurveArray;
        private ModelCurveArray roofModelMapped;
        private Document document;
        private Transaction roofTransaction;
        private FootPrintRoof roof;
        private double slopingAngleInDegree;


        public Level RoofLevel => roofLevel;
        public RoofType RoofingType => roofType;
        public CurveArray RoofCurveArray => roofCurveArray;
        public Transaction RoofTransaction { get => roofTransaction; set => roofTransaction = value; }
        public Document RoofDocument { get => document; set => document = value; }
        public FootPrintRoof Roof => roof;
        public CurveConstructor CurveBuilder { get; set; }
        public double SlopingAngleInDegree { get => slopingAngleInDegree; set => slopingAngleInDegree = value; }


        /// <summary>
        /// Instantiates a Drawer class for a roof of a footprint. The Mapped ModelCurve Array and the Roof,
        /// will not be instantiated except after drawing the roof.
        /// </summary>
        /// <param name="roofArray">Closed loop of the footprint.</param>
        /// <param name="roofBaseLevel">Level at which the roof is drawn.</param>
        /// <param name="document">Document in which the roof will be drawn.</param>
        /// <param name="roofType">The type of a roof, if not given it will be assigned a random Type.</param>
        /// <param name="roofTransaction">Transaction used to draw the roof.</param>
        /// <param name="slopingAngle">Angle for the roof if not given it will be set to default 30 degrees.</param>
        public FootPrintRoofBuilder(CurveConstructor curveBuilder, Document document, RoofType roofType, Transaction roofTransaction, double slopingAngle)
        {
            CurveBuilder = curveBuilder;
            slopingAngleInDegree = slopingAngle;
            this.document = document;
            this.roofTransaction = roofTransaction;
            this.roofType = roofType;
            if (roofType == null)
                this.roofType = new FilteredElementCollector(document).OfClass(typeof(RoofType)).FirstOrDefault() as RoofType;
            roofCurveArray = curveBuilder.Curves; //WILL BE CHANGED.
            AssignLevel();
        }


        /// <summary>
        /// Instantiates a Drawer class for a roof of a footprint. The Mapped ModelCurve Array and the Roof,
        /// will not be instantiated except after drawing the roof.
        /// </summary>
        /// <param name="roofArray">Closed loop of the footprint.</param>
        /// <param name="roofBaseLevel">Level at which the roof is drawn.</param>
        /// <param name="document">Document in which the roof will be drawn.</param>
        /// <param name="roofTransaction">Transaction used to draw the roof.</param>
        public FootPrintRoofBuilder(CurveConstructor curveBuilder, Document document, Transaction roofTransaction)
            : this(curveBuilder, document, new FilteredElementCollector(document).OfClass(typeof(RoofType)).FirstOrDefault() as RoofType, roofTransaction, 0)
        { }

        public FootPrintRoofBuilder(CurveConstructor curveBuilder, Document document, Transaction roofTransaction, double SlopingAngle)
            : this(curveBuilder, document, new FilteredElementCollector(document).OfClass(typeof(RoofType)).FirstOrDefault() as RoofType, roofTransaction, SlopingAngle)
        { }

        /// <summary>
        /// Draws the foot print roof instantiates the roof and the ModelCurve mapped from the footprintRoof.
        /// </summary>
        public void Draw()
        {
            using (roofTransaction)
            {
                TransactionStart(roofTransaction);
                roofModelMapped = new ModelCurveArray();
                roof = document.Create.
                NewFootPrintRoof(roofCurveArray, roofLevel, roofType, out roofModelMapped);
                TransactionCommit(roofTransaction);
            }

        }


        /// <summary>
        /// Starts the class's made transaction for the RevitAPI.
        /// </summary>
        public void TransactionStart(Transaction transaction)
        {
            transaction.Start();
        }



        /// <summary>
        /// Commits the class's made transaction for the RevitAPI.
        /// </summary>
        public void TransactionCommit(Transaction transaction)
        {
            transaction.Commit();
        }


        /// <summary>
        /// Assigns a custom roofing angle for every edge.
        /// </summary>
        private void SetRoofSlopeAngle()
        {
            ModelCurveArrayIterator iterator = roofModelMapped.ForwardIterator();
            ModelCurve modelCurve;
            iterator.Reset();
            while (iterator.MoveNext())
            {
                modelCurve = iterator.Current as ModelCurve;
                roof.set_DefinesSlope(modelCurve, true);
                roof.set_SlopeAngle(modelCurve, Math.Tan(ToRadians(slopingAngleInDegree)));
            }
        }


        /// <summary>
        /// Assigns a default roofing angle for every edge of 30 Degrees.
        /// </summary>
        private void AssignDefaultRoofSlopeAngle()
        {
            ModelCurveArrayIterator iterator = roofModelMapped.ForwardIterator();
            ModelCurve modelCurve;

            iterator.Reset();
            while (iterator.MoveNext())
            {
                modelCurve = iterator.Current as ModelCurve;
                roof.set_DefinesSlope(modelCurve, true);
                roof.set_SlopeAngle(modelCurve, Math.Tan(ToRadians(30)));
            }


        }
        
        /// <summary>
        /// Sets the Slope Angle.
        /// </summary>
        public void SetSlopingAngle()
        {
            using (Transaction transaction = new Transaction(document, "ChangeSlope"))
            {
                TransactionStart(transaction);
                if (slopingAngleInDegree == 0)
                    AssignDefaultRoofSlopeAngle();
                else
                    SetRoofSlopeAngle();

                TransactionCommit(transaction);
            }
        }

        /// <summary>
        /// Gets the corresponding Level of the ModelCurves.
        /// </summary>
        /// <returns>Level of the ModelCurves</returns>
        private Level CorrespondingCurveLevel()
        {
            var curve = roofCurveArray.get_Item(0);
            var elevation = curve.GetEndPoint(1).Z;
            var collection = new FilteredElementCollector(document).OfClass(typeof(Level));
            List<Level> levelList = new List<Level>();

            foreach (Element element in collection)
            {
                levelList.Add(element as Level);
            }

            return levelList.FirstOrDefault(Lvl => Lvl.Elevation == elevation);
        }


        /// <summary>
        /// Gets the corresponding Level of the top of walls.
        /// </summary>
        /// <returns>Top Constrain Wall Level</returns>
        private Level CorrespondingWallLevel()
        {
            var roofWall = CurveBuilder.RoofWall;
            Parameter param = roofWall.get_Parameter(BuiltInParameter.WALL_HEIGHT_TYPE);
            return document.GetElement(param.AsElementId()) as Level;
        }


        /// <summary>
        /// Assigns the level.
        /// </summary>
        private void AssignLevel()
        {
            switch (CurveBuilder.RoofDrawingType)

            {
                case DrawingType.Wall:
                    roofLevel = CorrespondingWallLevel();
                    break;
                case DrawingType.ModelCurve:

                    roofLevel = CorrespondingCurveLevel();
                    break;

            }
        }

    }
}
