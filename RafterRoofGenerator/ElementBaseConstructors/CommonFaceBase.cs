
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
    public class CommonFaceBase:IFaceBase
    {
        private Curve faceEdge;
        private XYZ directionVector;

        public Curve FaceEdge => faceEdge;
        public XYZ DirectionVector => directionVector;


        public CommonFaceBase(Curve curve)
        {
            faceEdge = curve;
            directionVector = GetDirectionVector(faceEdge);
        }

                
        private XYZ GetDirectionVector(Curve curve)
        {
            var vector = faceEdge.GetEndPoint(1) - faceEdge.GetEndPoint(0);
            return vector.Normalize();
        }


    }
}
