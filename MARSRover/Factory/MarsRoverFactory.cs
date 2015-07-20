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
    public class MarsRoverFactory : RoverFactory
    {
        /// <summary>
        /// Gets the rover.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="Direction">The direction.</param>
        /// <param name="Position">The position.</param>
        /// <returns></returns>
        public override IRover GetRover(string Name, Direction Direction, Position Position)
        {
            return new Rover(Name, Direction, Position);
        }
    }
}
