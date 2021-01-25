using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
  [Serializable]  
    class Greyhound
    {
        public int StartingPosition { set; get; }
        public static int RacetrackLength { get; set; } = 440;
        public PictureBox MyPictureBox { set; get; }
        public int Location { set; get; }= 0;
        public Random MyRandom { set; get; }

        public Greyhound(int startingPosition, PictureBox myPictureBox)
        {
            this.StartingPosition = startingPosition;
            this.MyPictureBox = myPictureBox;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Location = new Point(Location, MyPictureBox.Location.Y);
        }
        public bool Run()
        {
            MyRandom = new Random();
            bool winner = false ;

            //int distance =  MyRandom.Next(1, 10);
            //Point p = MyPictureBox.Location;
            //p.X += distance;
            //MyPictureBox.Location = p;
            Location += MyRandom.Next(1, 15);
            MyPictureBox.Location = new Point(Location, MyPictureBox.Location.Y);


            if (Location >= RacetrackLength)
                winner = true;

            return winner;
        }




    }
}
