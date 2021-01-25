using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsGame
{
    public class Game
    {
        //ustawione na public dlatego trzeba sprawdzic czy klasa Enemy jest hermetyczna
        
        public List<Enemy> enemies;
        public Wepon weponInRoom;

        private Player player;
        public Point playerLocation { get { return player.Location; } }
        public int playerHitPoints { get { return player.HitPoints; } }
        public List<string> playerWepons { get { return player.Wepons; } }

        public int Level { get; private set; } = 0;

        public Rectangle Boundaries { get; }

        public Game(Rectangle boundaries)
        {
            this.Boundaries = boundaries;
            player = new Player(this,
                new Point(boundaries.Left + 10, boundaries.Top + 70),
                Boundaries);
                
            //player = new Player();
            //enemies = new List<Enemy>();
            //InventoryAvailability = new Dictionary<Inventory, bool>();
        }

        public void Move(Mover.Direction direction, Random rnd)
        {
            //wywołuje metody Move przeciwników które mają parametr kirunku i Random
            player.Move(direction);

            foreach (Enemy enemy in enemies)
            {
                enemy.Move(rnd);
            }
        }

        public void Equip(string weponName)
        {
            player.Equip(weponName);
        }

        public bool CheckPlayerInventory(string weponName)
        {
            return player.Wepons.Contains(weponName);
        }

        public void HitPlayer(int maxDemage, Random rnd)
        {
            player.Hit(maxDemage, rnd);
        }

        public void IncreasePlayerHealth(int health, Random rnd)
        {
            player.IncreaseHealth(health, rnd);
        }

        public void Attac(Mover.Direction direction, Random rnd)
        {
            player.Attac(direction, rnd);
            foreach (Enemy enemy in enemies)
            {
                enemy.Move(rnd);
            }
        }

        private Point GetRandomLocation(Random rnd)
        {
            return new Point(Boundaries.Left +
                rnd.Next(Boundaries.Right / 10 - Boundaries.Left / 10) * 10,
                Boundaries.Top +
                rnd.Next(Boundaries.Bottom / 10 - Boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random rnd)
        {
            Level++;
            switch(Level)
            {
                case 1:
                    MessageBox.Show("Round 1!");
                    enemies = new List<Enemy>();
                    enemies.Add(new Bat(this, GetRandomLocation(rnd), Boundaries));
                    weponInRoom = new Sword(this, GetRandomLocation(rnd));
                    break;
                case 2:
                    MessageBox.Show("Round 2!");
                    enemies = new List<Enemy>();
                    enemies.Add(new Ghost(this, GetRandomLocation(rnd), Boundaries));
                    weponInRoom = new BluePotion(this, GetRandomLocation(rnd));
                    break;
                case 3:
                    MessageBox.Show("Round 3!");
                    enemies = new List<Enemy>();
                    enemies.Add(new Ghoul(this, GetRandomLocation(rnd), Boundaries));
                    weponInRoom = new Bow(this, GetRandomLocation(rnd));
                    break;
                case 4:
                    MessageBox.Show("Round 4!");
                    enemies = new List<Enemy>();
                    enemies.Add(new Ghost(this, GetRandomLocation(rnd), Boundaries));
                    enemies.Add(new Bat(this, GetRandomLocation(rnd), Boundaries));
                    if (!CheckPlayerInventory("Bow"))
                        weponInRoom = new Bow(this, GetRandomLocation(rnd));
                    else if (!CheckPlayerInventory("Blue Potion"))
                        weponInRoom = new BluePotion(this, GetRandomLocation(rnd));
                    break;
                case 5:
                    MessageBox.Show("Round 5!");
                    enemies = new List<Enemy>();
                    enemies.Add(new Bat(this, GetRandomLocation(rnd), Boundaries));
                    enemies.Add(new Ghoul(this, GetRandomLocation(rnd), Boundaries));
                    weponInRoom = new RedPotion(this, GetRandomLocation(rnd));
                    break;
                case 6:
                    MessageBox.Show("Round 6!");
                    enemies = new List<Enemy>();
                    enemies.Add(new Ghost(this, GetRandomLocation(rnd), Boundaries));
                    enemies.Add(new Ghoul(this, GetRandomLocation(rnd), Boundaries));
                    weponInRoom = new Mace(this, GetRandomLocation(rnd));
                    break;
                case 7:
                    MessageBox.Show("Round 7!");
                    enemies = new List<Enemy>();
                    enemies.Add(new Bat(this, GetRandomLocation(rnd), Boundaries));
                    enemies.Add(new Ghost(this, GetRandomLocation(rnd), Boundaries));
                    enemies.Add(new Ghoul(this, GetRandomLocation(rnd), Boundaries));
                    if (!CheckPlayerInventory("Mace"))
                        weponInRoom = new Mace(this, GetRandomLocation(rnd));
                    else if(!CheckPlayerInventory("Red Potion"))
                        weponInRoom = new RedPotion(this, GetRandomLocation(rnd));
                    break;
                case 8:
                    MessageBox.Show(" Congrats! You WON!!!");
                    Application.Exit();
                    break;



            }
        }





        //public void HitPlayer()
        //{
        //   // Point currentPosition = new Point(pictureBox.Location.X, pictureBox.Location.Y);

        //}


        //public Point GetPosition(int X, int Y)
        //{
        //    Point position = new Point(X, Y);

        //    return position;
        //}
    }
}
