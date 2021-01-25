using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHouse
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor Livingroom;
        Opponent opponent;
        OutsideWithDoor FrontYard;
        int numberofChecks;
        int numberOfLocationChange;
        public Form1()
        {
            InitializeComponent();

            CreateObjects();
            
         }

        private void CreateObjects()
        {
            //Location[] lokalizacje = new Location[6];
            //lokalizacje[0] = new RoomWithDoor("Salon", "coś", "Drzwi przesuwane",)
           
            FrontYard = new OutsideWithDoor("podjazd", true, "drzwi dębowe z mosiężną klamką");
            OutsideWithDoor BackYard = new OutsideWithDoor("podwórko", false, "drzwi przesuwane");
            OutsideWithHidingPlace Garden = new OutsideWithHidingPlace("ogród", false, "w szopie");
            Livingroom = new RoomWithDoor("salon", "turecki dywan, figurka z Londynu", "debowe drzwi z mosiężną klamką", "za kanapą");
            RoomWithDoor Kitchen = new RoomWithDoor("kuchnia", "plasikowy srebrno-szary klosz", "drzwi przesuwane", "pod stołem");
            Room Dinningroom = new Room("jadalnia", "miedziany kandelbar");
           RoomWithHidingPlace Stairs = new RoomWithHidingPlace("schody", "drewniana poręcz", "w szafie ściennej");
            Room Corridor = new Room("korytarz", "obraz z psem");
            RoomWithHidingPlace MainBedroom = new RoomWithHidingPlace("główna sypialnia", "duże łózko", "pod łóżkiem");
            RoomWithHidingPlace Bedroom = new RoomWithHidingPlace("druga sypialnia", "małe łóżko", "pod łóżkiem");
            RoomWithHidingPlace Bathroom = new RoomWithHidingPlace("łazienka", "umywalka i toaleta", "pod prysznicem");
            OutsideWithHidingPlace Driveway = new OutsideWithHidingPlace("droga dojazdowa", true, "w garażu");
            


            //tu uzywam rzutowania w góre (tablica spodziewa się obiektów Location a dostaje jej dzieci)
            Dinningroom.Exits = new Location[2] { Livingroom, Kitchen };
            Kitchen.Exits = new Location[] { Dinningroom };
            Livingroom.Exits = new Location[] { Dinningroom , Stairs};
            Garden.Exits = new Location[] { FrontYard, BackYard };
            BackYard.Exits = new Location[] { Garden, FrontYard,Driveway };
            FrontYard.Exits = new Location[] { Garden, BackYard, Driveway };
            Stairs.Exits = new Location[] { Livingroom, Corridor };
            Corridor.Exits = new Location[] {Stairs, MainBedroom, Bedroom, Bathroom };
            Driveway.Exits = new Location[] { FrontYard, BackYard };
            MainBedroom.Exits = new Location[] { Corridor };
            Bedroom.Exits = new Location[] { Corridor };
            Bathroom.Exits = new Location[] { Corridor };


            Livingroom.DoorLocation = FrontYard;
            FrontYard.DoorLocation = Livingroom;
            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = Kitchen;

           // currentLocation = FrontYard;
            ResetGame();
            tb_LocationDescription.Text = "";
           // 

        }

        public void ResetGame()
        {
            MoveToNewLocation(FrontYard);
            opponent = new Opponent(FrontYard);
 
            b_checkThatHidingPlace.Visible = false;
            b_GoThroughTheDoor.Visible = false;
            b_GoToNextLocation.Visible = false;
            cb_Locations.Visible = false;
            b_Hide.Visible = true;
            numberOfLocationChange = 0;
            numberofChecks = 0;
        }
      private void b_Hide_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                Application.DoEvents();
                tb_LocationDescription.Text = i.ToString();
                opponent.Move();
                Thread.Sleep(200);
            }
            b_Hide.Visible = false;
            MoveToNewLocation(currentLocation);
            SetComponentsVisibity();
        }

      public void MoveToNewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            numberOfLocationChange++;
            cb_Locations.Items.Clear();
            //SetComponentsVisibity();

            for (int i = 0; i < newLocation.Exits.Length; i++)
            {
                cb_Locations.Items.Add(newLocation.Exits[i].Name);
            }
            cb_Locations.SelectedIndex = 0;
        }


        private void b_GoToNextLocation_Click(object sender, EventArgs e)
        {
            Location selectedLocation = currentLocation.Exits[cb_Locations.SelectedIndex];
            numberOfLocationChange++;

            MoveToNewLocation(selectedLocation);
            SetComponentsVisibity();
        }

        private void b_GoThroughTheDoor_Click(object sender, EventArgs e)
        {
            //rzutowanie w dół (Location na interface IHasExteriorDoor po którym dziedziczy dziecko Location(RoomWithDoor lub OutsideWithDoor)
            IHasExteriorDoor locationBehindTheDoor = currentLocation as IHasExteriorDoor;
            MoveToNewLocation(locationBehindTheDoor.DoorLocation);
            SetComponentsVisibity();

        }

        public void SetComponentsVisibity()
        {

            tb_LocationDescription.Text = currentLocation.Description;
            cb_Locations.Visible = true;
            b_GoToNextLocation.Visible = true;
            IHidingPlace hidingPlace;
            if (currentLocation is IHidingPlace)
            {
                hidingPlace = currentLocation as IHidingPlace;
                b_checkThatHidingPlace.Visible = true;
                b_checkThatHidingPlace.Text = "Sprawdź " + hidingPlace.PlaceToHide;

            }
            else
                b_checkThatHidingPlace.Visible = false;

            if (currentLocation is IHasExteriorDoor)
                b_GoThroughTheDoor.Visible = true;
            else
                b_GoThroughTheDoor.Visible = false;
        }
        private void b_checkThatHidingPlace_Click(object sender, EventArgs e)
        {
            IHidingPlace hidingPlace = currentLocation as IHidingPlace;
            numberofChecks++;
            if (opponent.Check(currentLocation))
            {
                
                tb_LocationDescription.Text = "Brawo! Schowałem się w " + currentLocation.Name + " " + hidingPlace.PlaceToHide + ".\n\nZnalazłeś mnie w "+ numberOfLocationChange + " ruchach. Szukałeś w " + numberofChecks + " miejscach.";
                ResetGame();
            }
            else
            {
                tb_LocationDescription.Text = "Pudło! Czy naprawde sądziłeś, że schowałbym się " + hidingPlace.PlaceToHide + ".. Szukaj dalej!";
            }
        }



    }
}
