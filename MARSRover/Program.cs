using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MARSRover.Factory;
using MARSRover.Models;

namespace MARSRover
{
    /// <summary>
    ///
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var MarsFactory = new AppMarsFactory();
            var RoverFactory = new MarsRoverFactory();

            var Mars = MarsFactory.GetMars(10, 10);
            Mars.LandRover(RoverFactory.GetRover("A", Direction.EAST, new Position { X = 5, Y = 2 }));
            Mars.LandRover(RoverFactory.GetRover("B", Direction.WEST, new Position { X = 2, Y = 5 }));
            Mars.Show();

            while (true)
            {
                Console.WriteLine("\n\n");
                Console.Write("  Enter Rover and Rover Action: ");
                var Actions = Console.ReadLine().Select(x => x.ToString()).ToArray();
                var Rover = Mars.GetRover(Actions[0]);

                if (Rover == null)
                {
                    Console.WriteLine("  No Rover found");
                }
                else
                {
                    foreach (var Action in Actions.Skip(1))
                    {
                        Rover.Do(Action);
                    }

                    Mars.Show();
                }
            }
        }
    }
}
