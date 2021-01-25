using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class Mace:Wepon
    {
        public Mace(Game game, Point location) : base(game, location)
        { }

        public override string Name { get { return "Mace"; } }

        public override void Attac(Direction direction, Random rnd)
        {
            int searchDirection = (int)direction;
            for (int i = 0; i < 4; i++)
            {
                if (DemageEnemy((Direction)((searchDirection+i) % 4), 30, 10, rnd)) break;
            }
        }
    }
}
