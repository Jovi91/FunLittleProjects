using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {

        public OutsideWithHidingPlace(string name, bool hot, string placeToHide):base(name, hot)
        {
            this.placeToHide = placeToHide;
        }

        string placeToHide;
        public string PlaceToHide
        {
            get
            {
                return placeToHide;
            }
        }

    }
}
