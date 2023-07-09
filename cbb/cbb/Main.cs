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
            SetupInterface ui = new SetupInterface();
            ui.Initialize(application);


            return Result.Succeeded;
        }
        #endregion
    }
}
