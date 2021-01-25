using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    class RoomWithHidingPlace:Room, IHidingPlace
    { 

        public RoomWithHidingPlace(string name,  string decoration, string placeToHide) : base(name, decoration)
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
