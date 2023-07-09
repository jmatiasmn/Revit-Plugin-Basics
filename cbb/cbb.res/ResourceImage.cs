using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace cbb.res
{
    /// <summary>
    /// Gets the embedded resource image from the cbb.res assembly based on user provided file name with extension
    /// Helper methods.
    /// </summary>
    public class ResourceImage
    {
        #region public methods
        /// <summary>
        /// Gets the icon image from resource assembly
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static BitmapImage GetIcon(string name)
        {
            // Create the resource reader stream.
            Stream stream = ResourceAssembly.GetAssemnly().GetManifestResourceStream(ResourceAssembly.GetNamespace() + "Images.Icons." + name);

            // Construct and return image.

            var image = new BitmapImage();

            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();

            // Return constructed BitmapImage.
            return image;

        }
        #endregion
    }
}
