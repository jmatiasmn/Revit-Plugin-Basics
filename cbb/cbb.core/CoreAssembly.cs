using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cbb.core
{
    /// <summary>
    /// The core assembly helper methods.
    /// </summary>
    public class CoreAssembly
    {
        #region public methods

        /// <summary>
        /// Gets the current resource assembly
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyLocation()
        {
            return Assembly.GetExecutingAssembly().Location;
        }

        /// <summary>
        /// Gets the namespace of the currently running resource assembly
        /// </summary>
        /// <returns></returns>
        public static string GetNamespace()
        {
            return typeof(CoreAssembly).Namespace + ".";
        }


        #endregion
    }
}
