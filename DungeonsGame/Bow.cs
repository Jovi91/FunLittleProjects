using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class Bow:Wepon
    {
        public Bow(Game game, Point location) : base(game, location)
        { }

        public override string Name { get { return "Bow"; } }

        public override void Attac(Direction direction, Random rnd)
        {
            DemageEnemy(direction, 120, 4, rnd);
 
        }
    }
}
