using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSRover
{
    public interface IMars
    {
        void Show();
        void LandRover(IRover Rover);
        IRover GetRover(string Name);
    }
}
