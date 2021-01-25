using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeCarts
{
    [Serializable]
    class CardComparer : IComparer<Card>
    {
        public enum CompareBy
        {
            valueThenSuit,
            suitThenValue
        }
        public CompareBy _compareBy = CompareBy.valueThenSuit;
        public int Compare(Card x, Card y)
        {
            if (_compareBy == CompareBy.valueThenSuit)
            {
                if (x.value > y.value) return 1;
                else if (x.value < y.value) return -1;
                else
                {
                    if (x.suit > y.suit) return 1;
                    else if (x.suit < y.suit) return -1;
                    else return 0;
                }
            }
            else
            {
                if (x.suit > y.suit) return 1;
                else if (x.suit < y.suit) return -1;
                else
                {
                    if (x.value > y.value) return 1;
                    else if (x.value < y.value) return -1;
                    else return 0;
                }

            }


        }
    }
}
