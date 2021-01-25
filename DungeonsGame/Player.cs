using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsGame
{
    class Player:Mover
    {
        Wepon equippedWepon;
        //public Point Location { get; set; }
        public int HitPoints { get; private set; }
        List<Wepon> inventory = new List<Wepon>();
        public List<string> Wepons 
        {
            get {
                List<string> names = new List<string>();
                foreach (Wepon wepon  in inventory)
                {
                    names.Add(wepon.Name);
                }
                return names;
            }
         }
        //public enum Direction
        //{
        //    up,
        //    right,
        //    down,
        //    left
        //}

        public Player(Game game, Point location, Rectangle boundaries):base(game,location)
        {
            HitPoints=10;
        }
        public void Hit(int maxDemage, Random rnd)
        {//tą metodę używa przeciwnik by udeżyć gracza
            HitPoints -= rnd.Next(1, maxDemage);
        }
        public void IncreaseHealth(int health, Random rnd)
        {
            HitPoints += rnd.Next(1, health);
        }
        public void Equip(string weponName)
        {
            foreach (Wepon wepon in inventory)
            {
                if (wepon.Name == weponName)
                    equippedWepon = wepon;
            }
        }
        public void Move(Direction direction)
        {
            base.Location = Move(direction, game.Boundaries);
            if (!game.weponInRoom.PickedUp)
            {
                if (Nearby(game.weponInRoom.Location, 20))
                //if (game.weponInRoom.Nearby(Location, 10))
                {

                      
                    




                     game.weponInRoom.PickUpWepon();

                    inventory.Add(game.weponInRoom);
                    if (inventory.Count < 2)
                        equippedWepon = game.weponInRoom;
                }
                    
            }
        }
    public void Attac(Direction direction, Random rnd)
        {
            if (equippedWepon is null) return;

            equippedWepon.Attac(direction, rnd);
            if (equippedWepon is IPotion)
            {
                inventory.Remove(equippedWepon);
                //Wepons.Remove(equippedWepon.Name);
            }



        }


    }
}
