using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSRover
{
    /// <summary>
    ///
    /// </summary>
    public interface IMars
    {
        /// <summary>
        /// Shows this instance.
        /// </summary>
        void Show();
        /// <summary>
        /// Lands the rover.
        /// </summary>
        /// <param name="Rover">The rover.</param>
        void LandRover(IRover Rover);
        /// <summary>
        /// Gets the rover.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        IRover GetRover(string Name);
    }
}
