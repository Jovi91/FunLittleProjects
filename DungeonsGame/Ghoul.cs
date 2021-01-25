using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class Ghoul:Enemy
    {
        public Ghoul(Game game, Point location, Rectangle boundaries) : base(game, location, boundaries, 10)
        { }

        public override void Move(Random rnd)
        {
            bool doIMoveTowardPlayerPurposely = false;
            if (rnd.Next(3) <2)
                doIMoveTowardPlayerPurposely = true;

            if (doIMoveTowardPlayerPurposely)
                Location= Move(FindPlayerDirection(game.playerLocation), game.Boundaries);

            if (NearPlayer())
                game.HitPlayer(4, rnd);
        }
    }
}
