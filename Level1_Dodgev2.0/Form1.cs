using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level1_Dodgev2._0
{
    public partial class FrmDodge : Form
    {
        Graphics g; // declare the graphics object
        int x = 20, y = 20;// starting position of planet
        //Declare the rectangles to display the spaceship and planets in
        Rectangle areaSpaceship;       
        Rectangle[] area = new Rectangle[7];//area[0] to area[6]

        Random speed = new Random();
        Random idk = new Random();

        int[] planetSpeed = new int[7];
        bool left, right;
        int score = 0;
        int lives = 5;
        int highScore = 0;
        int IDK = 0;
        int livesSetBack = 0;
        int livesBoost = 0;
        int scoreSetBack = 0;
        int scoreBoost = 0;
        bool secretStuffz;
        bool secretStuffz2 = true;
        bool menuVis = false;

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                area[i].Y += planetSpeed[i];
                if (area[i].IntersectsWith(areaSpaceship))
                {
                    area[i].Y = 20;
                    lives -= 1; // reduce lives by 1
                    LblLives.Text = lives.ToString();

                    CheckLives();
                }
                if (secretStuffz2 == true)
                {
                    planetSpeed[i] = speed.Next(5, 10);
                    secretStuffz2 = false;
                }
                
                if (score > 20)
                {
                    planetSpeed[i] = speed.Next(10, 20);
                    secretStuffz2 = false;
                }
                if (score > 50)
                {
                    planetSpeed[i] = speed.Next(20, 25);
                }
                if (score > 100)
                {
                    planetSpeed[i] = speed.Next(25, 40);
                }
                if (score > 200)
                {
                    planetSpeed[i] = speed.Next(40, 50);
                }
                if (score > 500)
                {
                    planetSpeed[i] = speed.Next(50, 80);
                }
                if (score > 1000)
                {
                    planetSpeed[i] = speed.Next(80, 100);
                }

                if (area[i].Y > PnlGame.Height)
                {
                    area[i].Y = 20;
                    score += 1; // add 1 to score
                    LblScore.Text = score.ToString();//display score on the form 
                }
            }
            PnlGame.Invalidate();
        }


        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the spaceship on the panel
            g.DrawImage(spaceship, areaSpaceship);
            //use the DrawImage method to draw the planet on the panel

            for (int i = 0; i <= 6; i++)
            {
                g.DrawImage(planet1, area[i]);
            }
           
            if (secretStuffz == false)
            {
                menuStrip1.Enabled = true;
                TmrShip.Enabled = false;
                TmrPlanet.Enabled = false;
            }
        }

        int x2 = 50, y2 = 290; //starting position of spaceship
        //Load our two images from the bin\debug folder
        Image spaceship = Image.FromFile(Application.StartupPath + @"\alien1.png");
        Image mystery = Image.FromFile(Application.StartupPath + @"\download.jpg");

        private void FrmDodge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                left = true;
            }
            if (e.KeyData == Keys.Right)
            {
                right = true;
            }

        }

        private void FrmDodge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                left = false;
            }
            if (e.KeyData == Keys.Right)
            {
                right = false;
            }

        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (left) // if left arrow pressed
            {
                if (areaSpaceship.X < 10) //check to see if spaceship within 10 of left side
                {
                    areaSpaceship.X = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    areaSpaceship.X -= 7; //else move 5 to the left
                }
            }

            if (right) // if right arrow key pressed
            {
                if (areaSpaceship.X > PnlGame.Width - 40)// is spaceship within 40 of right side
                {
                    areaSpaceship.X = PnlGame.Width - 40;
                }
                else
                {
                    areaSpaceship.X += 7;
                }
            }


        }
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over, you scored an INCREDIBLE score of ... " + score + "!");
                if (score > highScore)
                {
                    highScore = score;
                    HighScore.Text = highScore.ToString();
                    MessageBox.Show("Congratulations, you got a new high score of ..." + highScore + "!");
                }
                score = 0;
                lives = 0;
                menuStrip1.Enabled = false;
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                secretStuffz = false;
                start.Enabled = true;
                secretStuffz2 = true;
                instructions.Enabled = true;
                redeemButton.Enabled = true;
            }
        }

        private void hacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = score + 999999999;
            LblScore.Text = score.ToString();
        }

        private void FrmDodge_DoubleClick(object sender, EventArgs e)
        {
            hacksToolStripMenuItem.Visible = true;
            lmfaoToolStripMenuItem.Visible = true;
            youLoseToolStripMenuItem.Visible = true;
            idkToolStripMenuItem.Visible = true;
            iHakUToolStripMenuItem.Visible = true;
            menuStrip1.Visible = true;
        }

        private void lmfaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = score - 999999999;
            LblScore.Text = score.ToString();
        }

        private void iHakUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = lives + 999999999;
            LblLives.Text = lives.ToString(); 
        }

        private void start_Click(object sender, EventArgs e)
        {
            TmrPlanet.Enabled = true;
            TmrShip.Enabled = true;
            start.Enabled = false;
            instructions.Enabled = false;
            redeemButton.Enabled = false;

            score = 0 - scoreSetBack + scoreBoost;
            lives = 5 - livesSetBack + livesBoost;
            secretStuffz = true;

            LblLives.Text = lives.ToString();
            LblScore.Text = score.ToString();

            speed.Next(5, 10);
            if(menuVis == true)
            {
                menuStrip1.Visible = true;
                menuStrip1.Enabled = true;
            }
            else
            {
                menuStrip1.Visible = false;
                menuStrip1.Enabled = true;
            }
        }

        private void youLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 0;
            CheckLives();
        }

        private void FrmDodge_Click(object sender, EventArgs e)
        {
            hacksToolStripMenuItem.Visible = false;
            lmfaoToolStripMenuItem.Visible = false;
            iHakUToolStripMenuItem.Visible = false;
            menuStrip1.Visible = false;
            youLoseToolStripMenuItem.Visible = false;
        }

        private void idkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDK = idk.Next(0, 100);
            if(IDK > -1 && IDK < 33)
            {
                score = score + 200;
                LblScore.Text = score.ToString();
            }
           else if (IDK > 32 && IDK < 67)
            {
                score = score - 200;
                LblScore.Text = score.ToString();
            }
            else
            {
                lives = 0;
                CheckLives();
            }
        }

        private void instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right arrow keys to control the spaceship. Let a spaceship reach the bottom of the screen to get a point. Lose a life if you hit a planet. The planets will speed up over time. Try not to lose all your lives!");
        }

        private void redeemCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void redeemButton_Click(object sender, EventArgs e)
        {
            if (redeemCode.Text == "lmao")
            {
                MessageBox.Show("You lose a life at the start of next game! LMAO!");
                livesSetBack = 1;
            }
            else if (redeemCode.Text == "Matthew Is a God" || redeemCode.Text == "Matthew is a god" || redeemCode.Text == "MATTHEW IS A GOD" || redeemCode.Text == "matthew is a god")
            {
                MessageBox.Show("You Are Amazing! You Recieve A Secret Cheat Menu!");
                menuStrip1.Visible = true;
                menuVis = true;
            }
            else if (redeemButton.Text == "RG")
            {
                MessageBox.Show("I Hate You.");
                livesSetBack = 5;
            }
            else if (redeemButton.Text == "Hog Rider")
            {
                MessageBox.Show("You have good taste! Have an extra 10 points!");
                scoreBoost = 10;
            }
            else if (redeemButton.Text == "1234567890")
            {
                MessageBox.Show("Have an extra 5 points!");
                scoreBoost = 5;
            }
            else if (redeemButton.Text == "")
            {
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Sorry, invalid code.");
            }
        }

        Image planet1 = Image.FromFile(Application.StartupPath + @"\planet1.png");


        public FrmDodge()
        {
            InitializeComponent();
            start.Enabled = true;
            instructions.Enabled = true;
            redeemButton.Enabled = true;
            areaSpaceship = new Rectangle(x2, y2, 30, 30);
            for (int i = 0; i < 7; i++)
            {
                area[i] = new Rectangle(x + 70 * i, y, 40, 40);
                planetSpeed[i] = speed.Next(5, 10);
            }
        }

        private void FrmDodge_Load(object sender, EventArgs e)
        {
            
        }
    }
}
// Stuff to fix:
// When restarts, planet speed back to normal
// Powerups?!?
// Codes
