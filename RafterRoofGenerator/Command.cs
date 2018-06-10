namespace RafterRoofGenerator
{
    #region Namespaces
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Autodesk.Revit.ApplicationServices;
    using Autodesk.Revit.Attributes;
    using Autodesk.Revit.DB;
    using Autodesk.Revit.UI;
    using Autodesk.Revit.UI.Selection;
    using RafterRoofGenerator.RevitEntities;
    using RafterRoofGenerator.ElementBuilders;
    using RafterRoofGenerator.ElementBaseConstructors;

    #endregion

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
            //Good Job  
            return Result.Succeeded;
        }
    }
}
