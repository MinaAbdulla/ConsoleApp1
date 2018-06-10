using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace RafterRoofGenerator.ElementBaseConstructors
{

    /// <summary>
    /// Deletes and rebuilds a new Curve array with antiClockWise orientation and offset Eaves.
    /// </summary>
    class CurveConstructor
    {
        private CurveArray curves;
        private CurveArray antiClockWiseCurves;
        private CurveArray offsetEavesCurves;
        private List<ElementId> elementIds;
        private Document document;
        private List<Reference> referenceList;
        private DrawingType roofDrawingType;
        private Wall roofWall;


        public List<Reference> ReferenceList
        {
            get => referenceList;
            set
            {
                if (value.Count < 0)
                {
                    throw new Exception("Invalid Element IDS");
                }

                else
                {
                    referenceList = value;
                }
            }

        }
        public CurveArray Curves { get => curves; set => curves = value; }
        public CurveArray AntiClockWiseCurves => antiClockWiseCurves;
        public CurveArray OffsetEavesCurves => offsetEavesCurves;
        public List<ElementId> ElementIds => elementIds;
        public DrawingType RoofDrawingType => roofDrawingType;
        public Wall RoofWall => roofWall;
        private float Spacing { get; set; }


        public CurveConstructor(List<Reference> referenceList, Document document, float spacing)
        {
            this.referenceList = referenceList;
            AssignElementIds();
            this.document = document;
            curves = AssignCurves();
            Spacing = spacing;

        }

        private void AssignElementIds()
        {
            elementIds = new List<ElementId>();
            foreach (Reference reference in referenceList)
            {
                elementIds.Add(reference.ElementId);
            }
        }

        public CurveArray AssignCurves()
        {
            CurveArray array;
            using (Transaction trans = new Transaction(document, "CreatingCurves"))
            {
                trans.Start();
                array = document.Application.Create.NewCurveArray();
                trans.Commit();
            }
            foreach (ElementId id in elementIds)
            {
                Element element = document.GetElement(id);

                Wall wall = element as Wall;
                if (wall != null)
                {
                    LocationCurve wallCurve = wall.Location as LocationCurve;
                    array.Append(wallCurve.Curve);
                    roofDrawingType = DrawingType.Wall;
                    roofWall = wall;
                    continue;
                }

                ModelCurve modelCurve = element as ModelCurve;
                if (modelCurve != null)
                {
                    array.Append(modelCurve.GeometryCurve);
                }
                roofDrawingType = DrawingType.ModelCurve;
            }

            return array;
        }

        private void AssignOffsetEaves()
        {







        }

        public static void SortCurveArrayClockWise(CurveArray curves)
        {





        }

        public static void SortCurveArrayCounterClockWise(CurveArray curves)
        {





        }
    }





}

