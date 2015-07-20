using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MARSRover.Models;

namespace MARSRover.Factory
{
    /// <summary>
    ///
    /// </summary>
    class AppMarsFactory : MarsFactory
    {
        /// <summary>
        /// Gets the mars.
        /// </summary>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <returns></returns>
        public override IMars GetMars(int Width, int Height)
        {
            return new Mars(Width, Height);
        }
    }
}
