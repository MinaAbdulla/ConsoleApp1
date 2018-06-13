#region Namespaces
using System.Collections.Generic;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using RafterRoofGenerator.ElementBaseConstructors; //USING FOR ELEMENT CONTRUCTORS.
using RafterRoofGenerator.ElementBuilders; //USING FOR ELEMENT BUILDERS.

#endregion

namespace TestProject
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;
            Selection sel = uidoc.Selection;

            List<Reference> refLists = uidoc.Selection.PickObjects(ObjectType.Element, "Please select a model curve") as List<Reference>;

            CurveConstructor curveBuilder = new CurveConstructor(refLists, doc, 4f);
            FootPrintRoofBuilder roofBuilder = new FootPrintRoofBuilder(curveBuilder, doc, new Transaction(doc, "RoofTransaction"), 38);

            roofBuilder.Draw();
            roofBuilder.SetSlopingAngle();

            FootPrintRoofBase roofBase = new FootPrintRoofBase(roofBuilder.Roof);
            BeamPlanarSystemBuilder beamSys = new BeamPlanarSystemBuilder(doc, roofBase, new Transaction(doc, "BEAMS"));
            beamSys.Draw();
            return Result.Succeeded;
        }
    }
}
