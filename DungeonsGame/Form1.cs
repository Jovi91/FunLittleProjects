using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsGame
{
    public partial class Form1 : Form
    {
        Game game;
        Random rnd = new Random();
        PictureBox PictureBoxWithBorder;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 675, 265));
            game.NewLevel(rnd);
            UpdateCharacters();
            PictureBoxWithBorder = new PictureBox();
        }        
        
        public Form1()
        {
            InitializeComponent();
            
        }


        public void UpdateCharacters()
        {//wczytuje położenie postaci
            //aktualizuje położenie postaci
            //aktualizuje wyświetlanie ekwipunku na zwoju
            l_playerLocation.Text = "Player: " + pb_player.Location.ToString();
            l_weponLocation.Text = "Wepon: " + pb_swordGame.Location.ToString();
            l_enemyLocation.Text = "Enemy: " + pb_bat.Location.ToString();

            pb_player.Visible = true;
            pb_player.Location=game.playerLocation;
            l_playerHitPoints.Text = game.playerHitPoints.ToString();
            Point location = new Point(pb_player.Location.X, pb_player.Location.Y);

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.enemies)
            {
                if (enemy is Bat)
                {
                    pb_bat.Location = enemy.Location;
                    l_batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints>0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    pb_ghost.Location = enemy.Location;
                    l_ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints>0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    pb_ghoul.Location = enemy.Location;
                    l_ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            for (int i= game.enemies.Count-1; i>=0; i--)
            {
                if (game.enemies[i] is Bat)
                {
                    if (showBat)
                    {
                        pb_bat.Visible = true;
                        l_batHitPoints.Visible = true;
                        l_bat.Visible = true;
                    }
                    else
                    {
                        pb_bat.Visible = false;
                        l_batHitPoints.Visible=false;
                        l_bat.Visible = false;
                        game.enemies.RemoveAt(i);
                    }
                }
                else if (game.enemies[i] is Ghost)
                {
                    if (showGhost)
                    {
                        pb_ghost.Visible = true;
                        l_ghostHitPoints.Visible = true;
                        l_ghost.Visible = true;
                    }
                    else
                    {
                        pb_ghost.Visible = false;
                        l_ghostHitPoints.Visible = false;
                        l_ghost.Visible = false;
                        game.enemies.RemoveAt(i);
                    }
                }
                else if (game.enemies[i] is Ghoul)
                {
                    if (showGhoul)
                    {
                        pb_ghoul.Visible = true;
                        l_ghoulHitPoints.Visible = true;
                        l_ghoul.Visible = true;
                    }
                    else
                    {
                        pb_ghoul.Visible = false;
                        l_ghoulHitPoints.Visible = false;
                        l_ghoul.Visible = false;
                        game.enemies.RemoveAt(i);
                    }
                }
            }
            pb_swordGame.Visible = false;
            pb_bowGame.Visible = false;
            pb_redPotionGame.Visible = false;
            pb_bluePotionGame.Visible = false;
            pb_maceGame.Visible = false;
            Control weponControl = null;

            switch(game.weponInRoom.Name)
            {
                case "Sword":
                    weponControl = pb_swordGame; break;
                case "Bow":
                   weponControl = pb_bowGame; break;
                case "Red Potion":
                    weponControl = pb_redPotionGame; break;
                case "Blue Potion":
                    weponControl = pb_bluePotionGame; break;
                case "Mace":
                    weponControl = pb_maceGame; break;

            }

            weponControl.Visible = true;



            if (game.CheckPlayerInventory("Sword"))
                pb_swordInventory.Visible = true;

            if (game.CheckPlayerInventory("Bow"))
                pb_bowInventory.Visible = true;

            if (game.CheckPlayerInventory("Red Potion"))
                pb_redPotionInventory.Visible = true;

            if (game.CheckPlayerInventory("Blue Potion"))
                pb_bluePotionInventory.Visible = true;

            if (game.CheckPlayerInventory("Mace"))
                pb_maceInventory.Visible = true;


            if (!game.playerWepons.Contains("Blue Potion"))
                pb_bluePotionInventory.Visible = false;
            if (!game.playerWepons.Contains("Red Potion"))
                pb_redPotionInventory.Visible = false;

            MatchAttacButtonsToWeponKind();


                weponControl.Location = game.weponInRoom.Location;
            if (game.weponInRoom.PickedUp)
                weponControl.Visible = false;
            else
                weponControl.Visible = true;

            if(game.playerHitPoints<=0)
            {
                MessageBox.Show("Game Over!");
                Application.Exit();
            }

            if (enemiesShown<1)
            {
                MessageBox.Show("You've beaten your enemis on this level");
                game.NewLevel(rnd);
                UpdateCharacters();

            }
            

        }

        public void MatchAttacButtonsToWeponKind()
        {
            //if(PictureBoxWithBorder!=null)
            //    if(PictureBoxWithBorder.BorderStyle==BorderStyle.FixedSingle)
            //       return true;
            if (PictureBoxWithBorder != null && PictureBoxWithBorder.BorderStyle == BorderStyle.FixedSingle )
            {
                if (PictureBoxWithBorder == pb_bluePotionInventory || PictureBoxWithBorder == pb_redPotionInventory)
                    ShowOnlyDrinkPotionButton();
                else
                {
                    b_fightUp.Visible = true;
                    b_fightRight.Visible = true;
                    b_fightDown.Visible = true;
                    b_fightLeft.Visible = true;
                }

            }
            else
            {
                b_fightUp.Visible = false;
                b_fightRight.Visible = false;
                b_fightDown.Visible = false;
                b_fightLeft.Visible = false;

            }
            

        }

        public void ShowOnlyDrinkPotionButton()
        {
            b_fightRight.Visible = false;
            b_fightDown.Visible = false;
            b_fightLeft.Visible = false;
            b_fightUp.Visible = true;
            b_fightUp.Text = "Wypij Eliksir";
        }

        public void ShowDefaultFightButtons()
        {
            b_fightRight.Visible = true;
            b_fightDown.Visible = true;
            b_fightLeft.Visible = true;
            b_fightUp.Visible = true;
            b_fightUp.Text = "Góra";
        }
        public Point GetPosition(int X, int Y)
        {
            Point position = new Point(X, Y);

            return position;
        }

        private void pb_swordInventory_Click(object sender, EventArgs e)
        {
            string weponName = "Sword";
            if(game.CheckPlayerInventory(weponName))
            {
                game.Equip(weponName);
                PictureBoxWithBorder.BorderStyle = BorderStyle.None;
                PictureBoxWithBorder = pb_swordInventory;
                PictureBoxWithBorder.BorderStyle = BorderStyle.FixedSingle;

                //UpdateCharacters();
                ShowDefaultFightButtons();
            }
        }

        private void pb_bluePotionInventory_Click(object sender, EventArgs e)
        {
            string weponName = "Blue Potion";
            if (game.CheckPlayerInventory(weponName))
            {
                game.Equip(weponName);

                PictureBoxWithBorder.BorderStyle = BorderStyle.None;
                PictureBoxWithBorder = pb_bluePotionInventory;
                PictureBoxWithBorder.BorderStyle = BorderStyle.FixedSingle;

                ShowOnlyDrinkPotionButton();
            }
        }

        private void pb_bowInventory_Click(object sender, EventArgs e)
        {
            string weponName = "Bow";
            if (game.CheckPlayerInventory(weponName))
            {
                game.Equip(weponName);

                PictureBoxWithBorder.BorderStyle = BorderStyle.None;
                PictureBoxWithBorder = pb_bowInventory;
                PictureBoxWithBorder.BorderStyle = BorderStyle.FixedSingle;

                ShowDefaultFightButtons();
            }
        }

        private void pb_redPotionInventory_Click(object sender, EventArgs e)
        {
            string weponName = "Red Potion";
            if (game.CheckPlayerInventory(weponName))
            {
                game.Equip(weponName);

                PictureBoxWithBorder.BorderStyle = BorderStyle.None;
                PictureBoxWithBorder = pb_redPotionInventory;
                PictureBoxWithBorder.BorderStyle = BorderStyle.FixedSingle;

                ShowOnlyDrinkPotionButton();
            }
        }

        private void pb_maceInventory_Click(object sender, EventArgs e)
        {
            string weponName = "Mace";
            if (game.CheckPlayerInventory(weponName))
            {
                game.Equip(weponName);

                PictureBoxWithBorder.BorderStyle = BorderStyle.None;
                PictureBoxWithBorder = pb_maceInventory;
                PictureBoxWithBorder.BorderStyle = BorderStyle.FixedSingle;

                ShowDefaultFightButtons();
            }
        }
        private void b_moveUp_Click(object sender, EventArgs e)
        {
            //rnd = rnd.Next(3);
            game.Move(Mover.Direction.up, rnd);
            UpdateCharacters();
            
        }
        private void b_moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.right, rnd);
            UpdateCharacters();
        }

        private void b_moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.down, rnd);
            UpdateCharacters();
        }

        private void b_moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.left, rnd);
            UpdateCharacters();
        }

        private void b_fightUp_Click(object sender, EventArgs e)
        {
            game.Attac(Mover.Direction.up, rnd);
            if (PictureBoxWithBorder == pb_bluePotionInventory || PictureBoxWithBorder == pb_redPotionInventory)
                PictureBoxWithBorder.BorderStyle = BorderStyle.None;
            UpdateCharacters();


        }

        private void b_fightRight_Click(object sender, EventArgs e)
        {
            game.Attac(Mover.Direction.right, rnd);
            UpdateCharacters();
        }

        private void b_fightDown_Click(object sender, EventArgs e)
        {
            game.Attac(Mover.Direction.down, rnd);
            UpdateCharacters();
        }

        private void b_fightLeft_Click(object sender, EventArgs e)
        {
            game.Attac(Mover.Direction.left, rnd);
            UpdateCharacters();
        }
    }
}
