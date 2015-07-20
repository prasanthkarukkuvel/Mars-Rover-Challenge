using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSRover
{
    public abstract class RoverFactory
    {
        public abstract IRover GetRover(string Name, Direction Direction, Position Position);
    }
}
