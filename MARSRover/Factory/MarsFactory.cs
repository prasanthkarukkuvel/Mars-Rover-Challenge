using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSRover.Factory
{
    public abstract class MarsFactory
    {
        public abstract IMars GetMars(int Width, int Height);
    }
}
