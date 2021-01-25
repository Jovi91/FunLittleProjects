using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class Ghost:Enemy
    {
        public Ghost(Game game, Point location, Rectangle boundaries) : base(game, location, boundaries, 8)
        { }

        public override void Move(Random rnd)
        {
            bool doIMoveTowardPlayerPurposely = false;
            if (rnd.Next(3) == 1)
                doIMoveTowardPlayerPurposely = true;

            if (doIMoveTowardPlayerPurposely)
                Location=Move(FindPlayerDirection(game.playerLocation), game.Boundaries);

            if (NearPlayer())
                game.HitPlayer(3, rnd);
        }
    }
}
