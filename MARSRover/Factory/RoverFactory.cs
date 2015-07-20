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
    public abstract class RoverFactory
    {
        /// <summary>
        /// Gets the rover.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="Direction">The direction.</param>
        /// <param name="Position">The position.</param>
        /// <returns></returns>
        public abstract IRover GetRover(string Name, Direction Direction, Position Position);
    }
}
