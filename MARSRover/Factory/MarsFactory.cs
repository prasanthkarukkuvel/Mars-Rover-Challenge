using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSRover.Factory
{
    /// <summary>
    ///
    /// </summary>
    public abstract class MarsFactory
    {
        /// <summary>
        /// Gets the mars.
        /// </summary>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <returns></returns>
        public abstract IMars GetMars(int Width, int Height);
    }
}
