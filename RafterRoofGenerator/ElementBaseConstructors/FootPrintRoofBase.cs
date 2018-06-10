namespace RafterRoofGenerator.ElementBaseConstructors
{
    using System.Collections.Generic;
    using System.Linq;
    using Autodesk.Revit.DB;
    using static RafterRoofGenerator.ElementBaseConstructors.Helper.CurveSorterUtils;
    
    public class FootPrintRoofBase
    {
        private List<CommonFaceBase> commonFaces;
        private List<SkeletonFaceBase> skeletonFaces;
        private List<PlanarFace> planarFaceList;
        private List<Curve> edgeList;


        public FootPrintRoof Roof { get; set; }
        public List<SkeletonFaceBase> SkeletonFaces => skeletonFaces;
        public List<PlanarFace> PlanarFaceList => planarFaceList;
        public List<Curve> EdgeLists => edgeList;

        /// <summary>
        /// Instantiate a roof preparer object from a given roof.
        /// </summary>
        /// <param name="roof">Roof drawin in Revit by foot print sketch mode.</param>
        public FootPrintRoofBase(FootPrintRoof roof)
        {
            Roof = roof;
            planarFaceList = ConstructFaces();
            edgeList = ConstructEdges();
            commonFaces = InstantiatesBases(out skeletonFaces);

        }

        /// <summary>
        /// Constructs all the faces of the given roof.
        /// </summary>
        /// <returns>All the faces of the roof.</returns>
        private List<PlanarFace> ConstructFaces()
        {
            var planarList = new List<PlanarFace>();
            var refLists = (List<Reference>)HostObjectUtils.GetTopFaces(Roof);
            refLists.RemoveAt(2);
            foreach (Reference reference in refLists)
            {
                var planFace = Roof.GetGeometryObjectFromReference(reference) as PlanarFace;
                planarFaceList.Add(planFace);
            }
            return planarList;
        }


        /// <summary>
        /// Constructs all the edges of the roof,
        /// whether they are internal or external.
        /// </summary>
        /// <returns>All of the edges of the roof</returns>
        private List<Curve> ConstructEdges()
        {
            var curveList = new List<Curve>();
            foreach (PlanarFace face in planarFaceList)
            {
                var edgeArrays = face.EdgeLoops.get_Item(0);

                foreach (Edge edge in edgeArrays)
                {
                    curveList.Add(edge.AsCurve());
                }
            }
            return curveList;
        }


        /// <summary>
        /// Instantiates all the roof edge bases.
        /// </summary>
        /// <param name="internals">Outs a list of skeleton face bases which are
        /// all the internal skeleton edges of each face of the roof.</param>
        /// <returns>Common face bases which are the external edge of each face</returns>
        private List<CommonFaceBase> InstantiatesBases(out List<SkeletonFaceBase> internals)
        {
            var internalCurves = new List<Curve>();
            var externalCurves = new List<Curve>();
            var uniqueCurves = new List<Curve>();

            foreach (Curve c in edgeList)
            {
                if (!uniqueCurves.Any(x => (x.GetEndPoint(0) == c.GetEndPoint(0) && x.GetEndPoint(1) == c.GetEndPoint(1))))
                {

                    uniqueCurves.Add(c);
                }
                else
                {
                    internalCurves.Add(c);
                }
            }

            foreach (Curve c in uniqueCurves)
            {
                if (!internalCurves.Any(x => (x.GetEndPoint(0) == c.GetEndPoint(0) && x.GetEndPoint(1) == c.GetEndPoint(1))))
                {
                    externalCurves.Add(c);
                }
            }
            internals = FormSkeletonBases(internalCurves);
            return FormCommonBases(externalCurves);
        }


        /// <summary>
        /// Forms the Common Base of each of the roof faces
        /// </summary>
        /// <param name="curves">List of unsorted or sorted curves.</param>
        /// <returns>List of all the common base curves (Edges sorted anti clock wise)</returns>
        private List<CommonFaceBase> FormCommonBases(List<Curve> curves)
        {
            var curveList = MakeCounterClockwise(curves);
            List<CommonFaceBase> baseList = new List<CommonFaceBase>();
            foreach (var c in curveList)
            {
                baseList.Add(new CommonFaceBase(c));
            }
            return baseList;
        }

        
        /// <summary>
        /// Forms the Skeleton bases out of List of given Curves (internal edges)
        /// </summary>
        /// <param name="curves">list of internal curves of the roof</param>
        /// <returns>List of all the skeleton base curves of the roof</returns>
        private List<SkeletonFaceBase> FormSkeletonBases(List<Curve> curves)
        {
            List<SkeletonFaceBase> baseList = new List<SkeletonFaceBase>();
            foreach (var c in curves)
            {
                baseList.Add(new SkeletonFaceBase(c));
            }
            return baseList;
        }

    }
}
