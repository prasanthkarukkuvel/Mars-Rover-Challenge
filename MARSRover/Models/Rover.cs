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
    public class Rover : IRover
    {
        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        private Direction Direction { get; set; }
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Position Position { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rover"/> class.
        /// </summary>
        public Rover() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rover"/> class.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="Direction">The direction.</param>
        /// <param name="Position">The position.</param>
        public Rover(string Name, Direction Direction, Position Position)
        {
            this.Name = Name;
            this.Direction = Direction;
            this.Position = Position;
        }

        /// <summary>
        /// Gets the format.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        ///
        public string Format
        {
            get
            {
                switch (Direction)
                {
                    case Direction.NORTH: return "^" + Name;
                    case Direction.SOUTH: return Name + "v";
                    case Direction.EAST: return "<" + Name;
                    case Direction.WEST: return Name + ">";
                }

                return "__";
            }
        }

        /// <summary>
        /// Moves this instance.
        /// </summary>
        private void Move()
        {
            switch (Direction)
            {
                case Direction.NORTH: Position.Y++; break;
                case Direction.SOUTH: Position.Y--; break;
                case Direction.EAST: Position.X--; break;
                case Direction.WEST: Position.X++; break;
            }
        }

        /// <summary>
        /// Rotates the left.
        /// </summary>
        private void RotateLeft()
        {
            switch (Direction)
            {
                case Direction.NORTH: Direction = Direction.EAST; break;
                case Direction.SOUTH: Direction = Direction.WEST; break;
                case Direction.EAST: Direction = Direction.SOUTH; break;
                case Direction.WEST: Direction = Direction.NORTH; break;
            }
        }

        /// <summary>
        /// Rotates the right.
        /// </summary>
        private void RotateRight()
        {
            switch (Direction)
            {
                case Direction.NORTH: Direction = Direction.WEST; break;
                case Direction.SOUTH: Direction = Direction.EAST; break;
                case Direction.EAST: Direction = Direction.NORTH; break;
                case Direction.WEST: Direction = Direction.SOUTH; break;
            }
        }

        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <param name="Action">The action.</param>
        /// <returns></returns>
        private RoverAction GetAction(string Action)
        {
            switch (Action)
            {
                case "L": return RoverAction.LEFT;
                case "R": return RoverAction.RIGHT;
                case "M":
                default: return RoverAction.MOVE;
            }
        }

        /// <summary>
        /// Does the specified action.
        /// </summary>
        /// <param name="Action">The action.</param>
        public void Do(string Action)
        {
            switch (GetAction(Action))
            {
                case RoverAction.LEFT: RotateLeft(); break;
                case RoverAction.RIGHT: RotateRight(); break;
                case RoverAction.MOVE: Move(); break;
            }
        }
    }
}
