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

namespace RafterRoofGenerator.ElementBuilders
{
    public interface IDrawer
    {
        void Draw();
        void TransactionStart(Transaction transaction);
        void TransactionCommit(Transaction transaction);
    }
}
