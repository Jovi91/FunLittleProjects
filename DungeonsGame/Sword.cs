using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class Sword:Wepon
    {
        public Sword(Game game, Point location) : base(game, location)
        { }

        public override string Name { get { return "Sword"; } }

        public override void Attac(Direction direction, Random rnd)
        {
            int searchDirection = (int)direction;
            for (int i = searchDirection; i < searchDirection+3; i++)
            {
                if(DemageEnemy((Direction)(i%4),40,10,rnd)) break;
            }
        }
    }
}
