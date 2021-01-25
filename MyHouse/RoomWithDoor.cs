using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription, string placeToHide) :base(name,decoration,placeToHide)
        { 
            this.doorDescription = doorDescription;
           // this.doorLocation = doorLocation;
        }
        string doorDescription;
        public string DoorDescription
        {
            get
            {
                return doorDescription;
            }
        }

        Location doorLocation;
        public Location DoorLocation
        {
            get
            {
                return doorLocation;
            }
            set
            {
                doorLocation = value;
            }
        }

        public override string Description
        {
            get
            {
                return base.Description + "Ta lokalizacja posiada " + DoorDescription + ".";
            }
        }
    }
}
