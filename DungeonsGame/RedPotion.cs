using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class RedPotion:Wepon, IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location)
        { }

        public bool Used { get; private set; }

        public override string Name { get { return "Red Potion"; } }

        public override void Attac(Direction direction, Random rnd)
        {
            game.IncreasePlayerHealth(10, rnd);
            Used = true;
        }
    }
}
