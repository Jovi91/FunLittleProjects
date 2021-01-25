using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DungeonsGame
{
    public abstract class Enemy:Mover
    {
        const int NearPlayerDistance = 25;
        //Game game;
        //Point Location;
        
        public int HitPoints { get; private set; }

        public bool Dead
        {
            get
            {
                if (HitPoints <= 0) return true;
                else return false;
            }
        }
        public Enemy(Game game, Point location, Rectangle boundaries, int hitPoints):base(game, location)
        {
            this.HitPoints = hitPoints;
        }


        public abstract void Move(Random rnd);
        //{
            //randomowo porusza się i sprawdza czy jest blisko gracza
            //(sprawdzić czy NearPlayer i to sprawdzenie na pewno w Enemy a nie w Game)
            //if(NearPlayer())
            //{
            //    game.HitPlayer();
            //}

            //Attac(); -> metoda Enemy Move ma wywoływać Attac
       // }

        public void Hit(int maxDemage, Random rnd)
        {//tę metodę używa gracz aby udeżyć przeciwnika
            HitPoints -= rnd.Next(1, maxDemage);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.playerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > Location.X + 10)
                directionToMove = Direction.right;
            else if (playerLocation.X < Location.X - 10)
                directionToMove = Direction.left;
            else if (playerLocation.Y < Location.Y - 10)
                directionToMove = Direction.up;
            else
                directionToMove = Direction.down;

            return directionToMove;
        }
        //public Point GetPosition()
        //{
        //}

    }
}
