using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    class Opponent
    {
        Location myLocation;
        Random random;

        public Opponent(Location myLocation)
        {
            this.myLocation = myLocation;
            random = new Random();
        }

        public void Move()
        {
            //bool iFoundPlaceToHide = false;
            int locationIndex;
            IHasExteriorDoor hasDoor;
            //if(myLocation.Exits[locationIndex] is IHasExteriorDoor)
            int enterTheDoor = random.Next(1, 4);
            do
            {
                if (myLocation is IHasExteriorDoor && enterTheDoor == 1)
                {
                    hasDoor = myLocation as IHasExteriorDoor;
                    myLocation = hasDoor.DoorLocation;
                
                }
                else
                {
                    locationIndex=random.Next(0, myLocation.Exits.Length);
                    myLocation = myLocation.Exits[locationIndex];
                }
            }
            while (!(myLocation is IHidingPlace));

            

        }


        public bool Check(Location locationToCheck)
        {
            if (myLocation == locationToCheck)
                return true;
            else
                return false;


        }
    }
}
