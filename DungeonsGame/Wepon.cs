using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    public abstract class Wepon:Mover
    {
        protected Game game;
        public bool PickedUp { get; private set; }
        //public new Point Location { get; private set; }
        public abstract string Name { get; }
        public Wepon(Game game, Point location):base(game, location)
        {
            PickedUp = false;
            this.game = game;
        }

        public abstract void Attac(Direction direction, Random rnd);
        public void PickUpWepon() { PickedUp = true; }

        public bool DemageEnemy(Direction direction, int radious, int demage, Random rnd) 
        {
            Point target = game.playerLocation;
            for (int distance = 0; distance < radious; distance++)
            {
                foreach (Enemy enemy in game.enemies)
                {
                    if (Nearby(enemy.Location, target, radious))
                    {
                        enemy.Hit(demage, rnd);
                        return true;
                    }
                    
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }
}
