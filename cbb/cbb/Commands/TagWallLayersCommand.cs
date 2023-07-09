using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cbb
{
    /// <summary>
    /// Coomand code to be executed when button is clicked
    /// </summary>

    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class TagWallLayersCommand : IExternalCommand
    {
        /// <summary>
        /// Tag wall layers by creating text note element on user specified point and populate it with information
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// 

        #region Public properties
        #endregion

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string walls = "";

            foreach (Element element in new FilteredElementCollector(commandData.Application.ActiveUIDocument.Document).OfCategory(BuiltInCategory.OST_Walls).WhereElementIsElementType())
            {
                walls += element.Name + "\n";
            }
            
            TaskDialog diag = new TaskDialog("Test")
            {
                MainContent = walls,
                MainInstruction = "aaa",
                CommonButtons = TaskDialogCommonButtons.Yes,

            };
            diag.Show();

            return Result.Succeeded;
        }
    }
}
