using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DungeonsGame
{
    class Bat:Enemy
    {
        public Bat(Game game, Point location, Rectangle boundaries) : base(game, location, boundaries, 6)
        { }

        public override void Move(Random rnd)
        { 
            bool doIMoveTowardPlayerPurposely = false;
            if (rnd.Next(2) == 1)
                doIMoveTowardPlayerPurposely = true;

            if (doIMoveTowardPlayerPurposely)
               Location= Move(FindPlayerDirection(game.playerLocation), game.Boundaries);
            else
                Location=Move((Direction)(rnd.Next(4)), game.Boundaries);

            if (NearPlayer())
                game.HitPlayer(2, rnd);
        }
    }
}
