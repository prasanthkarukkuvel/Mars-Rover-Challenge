using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MARSRover.Models;

namespace MARSRover.Factory
{
    public class MarsRoverFactory : RoverFactory
    {
        public override IRover GetRover(string Name, Direction Direction, Position Position)
        {
            return new Rover(Name, Direction, Position);
        }
    }
}
