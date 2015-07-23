using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSRover.Models
{
    /// <summary>
    ///
    /// </summary>
    public class Mars : IMars
    {
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        private int Width { get; set; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        private int Height { get; set; }
        /// <summary>
        /// Gets or sets the rovers.
        /// </summary>
        /// <value>
        /// The rovers.
        /// </value>
        private List<IRover> Rovers { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mars" /> class.
        /// </summary>
        public Mars() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mars" /> class.
        /// </summary>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        public Mars(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        /// <summary>
        /// Adds the rover.
        /// </summary>
        /// <param name="Rover">The rover.</param>
        public void LandRover(IRover Rover)
        {
            Rovers = Rovers ?? new List<IRover>();
            Rovers.Add(Rover);
        }

        /// <summary>
        /// Gets the rover.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <returns></returns>
        private IRover GetRover(int X, int Y)
        {
            return Rovers.Where(x => x.Position.X == X && x.Position.Y == Y).FirstOrDefault();
        }

        /// <summary>
        /// Gets the rover.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public IRover GetRover(string Name)
        {
            return Rovers.Where(x => x.Name == Name).FirstOrDefault();
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
        public void Show()
        {
            Console.WriteLine();

            for (int j = 1; j <= Height; j++)
            {
                Console.Write(" " + (Height - (j - 1)).ToString("00") + " |");

                for (int i = 1; i <= Width; i++)
                {
                    var Rover = GetRover(i, (Height - j) + 1);

                    if (Rover == null)
                    {
                        Console.Write(" __ |");
                    }
                    else
                    {
                        Console.Write(" " + Rover.Format + " |");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                if ((j) >= Height)
                {
                    Console.Write("  00 ");

                    for (int i = 1; i <= Width; i++)
                    {
                        Console.Write(" " + i.ToString("00") + "  ");
                    }
                }
            }
        }
    }
}
