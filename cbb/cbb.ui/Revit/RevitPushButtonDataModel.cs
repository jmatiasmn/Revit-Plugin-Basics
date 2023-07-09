using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.ui.Revit
{
    /// <summary>
    /// Represets Revit push button data model.
    /// </summary>
    public class RevitPushButtonDataModel
    {
        #region public methods
        /// <summary>
        /// Gets or sets the label of the button
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// Gets or sets the panel on wich button is hosted.
        /// </summary>
        public RibbonPanel Panel { get; set; }
        /// <summary>
        /// Gets or sets the tooltip
        /// </summary>
        public string CommandNamespacePath { get; set; }
        public string Tooltip { get; set; }
        /// <summary>
        /// Gets or sets the  name of the icon image.
        /// </summary>
        public string IconImageName { get; set; }
        /// <summary>
        /// The name of tooltip image.
        /// </summary>
        public string ToolTipImage { get; set; }

        #endregion

        #region constructor
        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="RevitPushButtonDataModel"/> class.
        /// </summary>
        public RevitPushButtonDataModel()
        {
        }
        #endregion
    }
}
