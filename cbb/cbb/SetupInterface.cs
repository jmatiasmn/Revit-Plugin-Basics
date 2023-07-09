using Autodesk.Revit.UI;
using cbb.core;
using cbb.ui.Revit;
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
    /// Setup whole puglins interface with tabs, panels, buttons,...
    /// </summary>
    public class SetupInterface
    {
        #region constructor
        /// <summary>
        /// Default constructor.
        /// Initializes a new instace of the <see cref="SetupInterface"/>
        /// </summary>
        public SetupInterface()
        {
        }

        #endregion

        #region public methods

        public void Initialize(UIControlledApplication uiapp)
        {
            //Plugin's maing tab name;
            string tabName = "Circle's Bim Blog";

            //Create Tab on Revit UI.
            uiapp.CreateRibbonTab(tabName);

            //Panel name hosted on ribbon tab.
            string pannelAnotationName = "Annotation Commnds";

            //Create the annotate comands panel.
            var annotateCommandsPanel = uiapp.CreateRibbonPanel(tabName, pannelAnotationName);

            //Populate button data model.
            RevitPushButtonDataModel TagWallButtonData = new RevitPushButtonDataModel
            {
                Label= "Tag Wall \nLayers",
                Panel = annotateCommandsPanel,
                ToolTipImage = "wall.png" ,
                IconImageName = "32.jpg",
                Tooltip = "This is some sample tooltip text, replace it later",
                CommandNamespacePath = TagWallLayersCommand.GetPath()
            };

            // Create button
            PushButton TagWallButton = RevitPushButton.Create(TagWallButtonData);

            
        }

        #endregion
    }
}
