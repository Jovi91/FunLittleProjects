using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    [Serializable]
    public class Bet
    {
        public int Amount { get; set; } = 0;
        public int Dog { get; set; }
        public Guy Bettor { get; set; }

        public Bet(int amount, int dog, Guy bettor)
        {
            this.Amount = amount;
            this.Dog = dog;
            this.Bettor = bettor;
        }
        public string GetDescription()
        {
            string info;
            if (Amount==0)
                info = Bettor.Name + " nie postawił zakładu.";
            else
                info = Bettor.Name + " stawia " + Amount + "zł na psa numer " + Dog;

            return info;

        }

        public int PayOut(int winner)
        {
            int payOut;
            if (Dog == winner)
                payOut = Amount;
            else
                payOut = -Amount;

            return payOut;

        }
    }
}
