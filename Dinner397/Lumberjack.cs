using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner397
{
    public class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        Stack<Flapjack> meal;
        public enum Flapjack
        {
            chrupkiego,
            wilgotnego,
            rumianego,
            banaowego
        }

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjack(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }

        }

        public void EatFlapjacks()
        {
            foreach (Flapjack food in meal)
            {
                Console.WriteLine("{0} zjadł {1} naleśnika.", name, food);
            }

        }

    }
}
