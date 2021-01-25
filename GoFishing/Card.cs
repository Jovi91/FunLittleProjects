using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishing
{
    public class Card
    {
        public enum Suit
        {
            Spades,
            Clubs,
            Dimonds,
            Hearts
        }
        public enum Value
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public Value value;
        public Suit suit;

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;

        }

        static string[] names0 = new string[]
        {"", "Asów", "Dwójek", "Trójek", "Czwórek", "Piątek", "Szóstek", "Siódemek", "Ósemek", "Dziewiątek", "Dziesiątek",
            "Waletów", "Dam", "Króli"};
        static string[] names1 = new string[]
            {"", "Asa", "Dwójkę", "Trójkę", "Czwórkę", "Piątekę", "Szóstkę", "Siódemkę", "Ósemkę", "Dziewiątkę", "Dziesiątkę",
            "Waleta", "Damę", "Króla"};
        static string[] names2AndMore = new string[]
            {"", "Asy", "Dwójki", "Trójki", "Czwórki", "Piątki", "Szóstki", "Siódemki", "Ósemki", "Dziewiątki", "Dziesiątki",
            "Walety", "Damy", "Króle"};

        public static string Plural(Card.Value value, int count)
        {
            if (count == 0)
                return names0[(int)value];
            if(count==1)
                return names1[(int)value];
            return names2AndMore[(int)value];
        }

        static string[] suits = new string[] { "pik", "trefl", "karo", "kier" };
        static string[] names=new string[]
            {"", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka", "Dziesiątka",
            "Walet", "Dama", "Król"};
        public string Name
        {
            get { return names[(int)value] + " " + suits[(int)suit]; }
        }


    }
}
