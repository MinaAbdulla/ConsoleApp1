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
    public class SkeletonFaceBase : IFaceBase
    {
        private Curve faceEdge;

        public Curve FaceEdge => faceEdge;


        public SkeletonFaceBase(Curve curve)
        {
            faceEdge = curve;
        }


    }
}
