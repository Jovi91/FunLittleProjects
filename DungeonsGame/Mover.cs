using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    public abstract class Mover
    {
        const int MoveInterval = 10;
        public Point Location { get;protected set; }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.Location = location;
        }

        public enum Direction
        {
            up,
            right,
            down,
            left
        }

        protected bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(Location.X-locationToCheck.X)<distance &&
                (Math.Abs(Location.Y - locationToCheck.Y) < distance)){
                return true;
            } else{
                return false;
            }
        }

        protected bool Nearby(Point enemyLocation, Point playerLocation, int distance)
        {
            if (Math.Abs(playerLocation.X - enemyLocation.X) < distance &&
                (Math.Abs(playerLocation.Y - enemyLocation.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = Location;
            switch(direction)
            {
                case Direction.up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;



            }
            return newLocation;
        }

        public Point Move(Direction direction, Point playerLocation, Rectangle boundaries)
        {
            Point newLocation = Location;
            switch (direction)
            {
                case Direction.up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;



            }
            return newLocation;
        }

    }
}
