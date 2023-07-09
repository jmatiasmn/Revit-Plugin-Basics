using Autodesk.Revit.UI;
using cbb.core;
using cbb.res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.ui.Revit
{
    /// <summary>
    /// The Revit push button methods
    /// </summary>
    public static class RevitPushButton
    {

        #region public methods
        /// <summary>
        /// Creates the push button based on data provided on <see cref="RevitPushButtonDataModel"/>.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static PushButton Create(RevitPushButtonDataModel data)
        {
            //The button name based on unique identifier
            string btnDataName = Guid.NewGuid().ToString();

            PushButtonData btnData = new PushButtonData(btnDataName, data.Label, CoreAssembly.GetAssemblyLocation(), data.CommandNamespacePath)
            {
                LargeImage =  ResourceImage.GetIcon("32.jpg"),
                ToolTipImage = ResourceImage.GetIcon("wall.png")
            };

            return data.Panel.AddItem(btnData) as PushButton;
        }

        #endregion
    }
}
