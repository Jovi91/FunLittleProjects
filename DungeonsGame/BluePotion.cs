using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class BluePotion:Wepon, IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        { }

        public bool Used { get; private set; }

        public override string Name { get { return "Blue Potion"; } }

        public override void Attac(Direction direction, Random rnd)
        {
            game.IncreasePlayerHealth(5, rnd);
            Used = true;
        }
    }
}
