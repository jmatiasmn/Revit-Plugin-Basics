using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace cbb
{
    /// <summary>
    /// Plugin's main entry point
    /// </summary>
    public class Main : IExternalApplication
    {
        #region external application public methods
        /// <summary>
        /// Called when Revit Shutdown
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
        /// <summary>
        /// Caled when Revit starts up.
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Result OnStartup(UIControlledApplication application)
        {
            //Plugin's maing tab name;
            string tabName = "Circle's Bim Blog";

            //Panel name hosted on ribbon tab.
            string pannelAnotationName = "Annotation Commnds";

            //Create Tab on Revit UI.
            application.CreateRibbonTab(tabName);

            //Create first panel on Revit Ribbon tab;
           var panelAnnotation = application.CreateRibbonPanel(tabName, pannelAnotationName);

            //Create push button data and populate it with information.
            var tagWallLayersBtnData = new PushButtonData("TagWallLayersBtnData", "Tag Wall \nLayers", Assembly.GetExecutingAssembly().Location, "cbb.TagWallLayersCommand")
            {
                ToolTipImage = new BitmapImage(new Uri(@"C:\Users\jmati\Desktop\Marko Koljancic\res\wall.png")),
                ToolTip = "This is some sample tooltip text, replace it later"
            };

            var TagWallLayersBtn = panelAnnotation.AddItem(tagWallLayersBtnData) as PushButton;
            TagWallLayersBtn.LargeImage = new BitmapImage(new Uri(@"C:\Users\jmati\Desktop\Marko Koljancic\res\32.jpg"));


            return Result.Succeeded;
        }
        #endregion
    }
}
