using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //used to draw boxes on screen
        SolidBrush boxBrush = new SolidBrush(Color.White);

        //list to hold column of boxes
        List<Box> boxes = new List<Box>();

        //box values
        int boxSize, boxyspeed, newBoxCounter;

        Box hero;
        int heroyspeed;
        int sideCounter = 0;
        int doorCounter;
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        /// <summary>
        /// Set initial game values here
        /// </summary>
        public void OnStart()
        {
            boxes.Clear();
            sideCounter = 0;
            this.BackColor = System.Drawing.Color.LightSlateGray;
                        
            boxSize = 20;
            boxyspeed = 5;
            newBoxCounter = 0;
            doorCounter = 0;

            //TODO - set game start values
            Box b = new Box(200,0, boxSize, boxyspeed, 0);

            heroyspeed = 7;
            hero = new BoxField.Box(50, 250, 20, heroyspeed, 0);

            boxes.Add(b);

            leftArrowDown = false;
            rightArrowDown = false;
            downArrowDown = false;
            upArrowDown = false;

            gameLoop.Enabled = true;
        }
        public void level1()
        {
            if (newBoxCounter <= 20)
            {
                Box b = new Box(200, 0, boxSize, boxyspeed, 0);
                boxes.Add(b);
                Box a = new Box(400, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter >= 20)
            {
                Box b = new Box(600, 0, boxSize, boxyspeed, 0);
                boxes.Add(b);
                Box a = new Box(800, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level2()
        {
            this.BackColor = System.Drawing.Color.DarkBlue;
            if (newBoxCounter <= 20)
            {
                Box b = new Box(200, 0, boxSize, boxyspeed, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter >= 20)
            {
                Box b = new Box(600, 0, 20, 10, 0);
                boxes.Add(b);
                Box a = new Box(800, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level3()
        {
            this.BackColor = System.Drawing.Color.Blue;
            if (newBoxCounter <= 20)
            {
                Box b = new Box(200, 500, boxSize, -boxyspeed, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter >= 20)
            {
                Box b = new Box(500, 0, 20, 10, 0);
                boxes.Add(b);
                Box a = new Box(800, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(700, 500, boxSize, -boxyspeed, 0);
                boxes.Add(c);
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level4()
        {
            this.BackColor = System.Drawing.Color.DeepPink;
            if (newBoxCounter > 20 && newBoxCounter < 40)
            {
                Box b = new Box(200, 500, boxSize, -boxyspeed, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter > 120 && newBoxCounter < 140)
            {
                Box b = new Box(200, 500, boxSize, -boxyspeed, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter == 100)
            {
                Box c = new Box(200, 0, 40, 0, 2);
                boxes.Add(c);
                Box d = new Box(200, 40, 40, 0, 2);
                boxes.Add(d);
                Box e = new Box(200, 80, 40, 0, 2);
                boxes.Add(e);
                Box f = new Box(200, 120, 40, 0, 2);
                boxes.Add(f);
                Box r = new Box(200, 160, 40, 0, 2);
                boxes.Add(r);
                Box t = new Box(200, 200, 40, 0, 2);
                boxes.Add(t);
                Box y = new Box(200, 240, 40, 0, 2);
                boxes.Add(y);
                Box w = new Box(200, 280, 40, 0, 2);
                boxes.Add(w);
                Box q = new Box(200, 320, 40, 0, 2);
                boxes.Add(q);
                Box a = new Box(200, 360, 40, 0, 2);
                boxes.Add(a);
                Box v = new Box(200, 400, 40, 0, 2);
                boxes.Add(v);
                Box p = new Box(200, 440, 40, 0, 2);
                boxes.Add(p);
                Box o = new Box(200, 480, 40, 0, 2);
                boxes.Add(o);
            }
            if (newBoxCounter > 20 && newBoxCounter < 40)
            {
                Box b = new Box(500, 0, 20, 10, 0);
                boxes.Add(b);
                Box a = new Box(800, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(700, 500, boxSize, -boxyspeed, 0);
                boxes.Add(c);
            }
            if (newBoxCounter > 80 && newBoxCounter < 120)
            {
                Box b = new Box(500, 0, 20, 10, 0);
                boxes.Add(b);
                Box a = new Box(800, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(700, 500, boxSize, -boxyspeed, 0);
                boxes.Add(c);
            }
            if (newBoxCounter == 200)
            {
                newBoxCounter = 0;
            }
        }
        public void level5()
        {
            
            this.BackColor = System.Drawing.Color.Green;
            if (newBoxCounter <= 20)
            {
                Box b = new Box(200, 500, 15, -5, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
            }
            if (newBoxCounter >= 25)
            {
                Box b = new Box(500, 0, 20, 10, 0);
                boxes.Add(b);
                Box d = new Box(600, 250, 30, -6, 0);
                boxes.Add(d);
                Box f = new Box(600, 250, 30, 6, 0);
                boxes.Add(f);
                Box a = new Box(800, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(700, 500, boxSize, -boxyspeed + 5, 0);
                boxes.Add(c);
            }
            if (newBoxCounter >= 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level6()
        {
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            if (newBoxCounter <= 15)
            {
                Box b = new Box(200, 500, 15, -5, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(400, 0, 2, 20, 0);
                boxes.Add(c);
            }
            if (newBoxCounter >= 25)
            {
                Box b = new Box(500, 0, 20, 10, 0);
                boxes.Add(b);
                Box d = new Box(600, 250, 30, -5, 0);
                boxes.Add(d);
                Box f = new Box(600, 250, 30, 5, 0);
                boxes.Add(f);
                Box a = new Box(800, 0, boxSize, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(700, 500, boxSize, -17, 0);
                boxes.Add(c);
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level7()
        {
            this.BackColor = System.Drawing.Color.Purple;
            if (newBoxCounter <= 2)
            {
                Box b = new Box(200, this.Height, 50, -4, 0);
                boxes.Add(b);
                Box a = new Box(325, 0, 50, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(425, 0, 25, 20, 0);
                boxes.Add(c);
            }
            if (newBoxCounter >= 38)
            {
                Box b = new Box(500, 0, 25, 4, 0);
                boxes.Add(b);
                Box d = new Box(600, this.Height, 50, -4, 0);
                boxes.Add(d);
                Box a = new Box(800, this.Height, 50, -13, 0);
                boxes.Add(a);
                Box c = new Box(700, this.Height, 25, -32, 0);
                boxes.Add(c);
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level8()
        {
            this.BackColor = System.Drawing.Color.DarkGreen;
            if (newBoxCounter <= 20)
            {
                Box b = new Box(200, 500, 50, -10, 0);
                boxes.Add(b);
                Box a = new Box(325, 0, 3, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(425, 0, 3, 20, 0);
                boxes.Add(c);
            }
            if (newBoxCounter >= 38)
            {
                Box b = new Box(500, 0, 20, 10, 0);
                boxes.Add(b);
                Box d = new Box(600, 500, 10, -6, 0);
                boxes.Add(d);
                Box f = new Box(610, 500, 10, -5, 0);
                boxes.Add(f);
                Box a = new Box(800, 500, 50, -boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(700, 500, 8, -50, 0);
                boxes.Add(c);
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level9()
        {
            this.BackColor = System.Drawing.Color.Yellow;
            if (newBoxCounter <= 25)
            {
                Box b = new Box(200, 0, 25, 7, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, 25, 7, 0);
                boxes.Add(a);
                Box c = new Box(250, 0, 25, 7, 0);
                boxes.Add(c);

                Box f = new Box(395, this.Height, 50, -7, 0);
                boxes.Add(f);
                Box d = new Box(455, this.Height, 50, -7, 0);
                boxes.Add(d);
            }
            if (newBoxCounter >= 38)
            {
                Box b = new Box(570, 0, 50, 7, 0);
                boxes.Add(b);
                Box d = new Box(620, 0, 50, 7, 0);
                boxes.Add(d);
                Box a = new Box(670, this.Height, 50, -7, 0);
                boxes.Add(a);
                Box c = new Box(720, this.Height, 50, -7, 0);
                boxes.Add(c);
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level10()
        {
            titleLabel.Text = "ADIDAS";
            this.BackColor = System.Drawing.Color.FromArgb(255, 55, 55);
            if (newBoxCounter <= 2)
            {
                Box b = new Box(200, this.Height, 20, -4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 4)
            {
                Box b = new Box(230, this.Height, 20, -4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 6)
            {
                Box b = new Box(260, this.Height, 20, -4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 8)
            {
                Box b = new Box(290, this.Height, 20, -4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 10)
            {
                Box b = new Box(320, this.Height, 20, -4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 12)
            {
                Box b = new Box(350, this.Height, 20, -4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 14)
            {
                Box b = new Box(380, this.Height, 20, -4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 16)
            {
                Box b = new Box(410, this.Height, 20, -4, 0);
                boxes.Add(b);
            }

            if (newBoxCounter <= 2)
            {
                Box b = new Box(500, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 4)
            {
                Box b = new Box(530, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 6)
            {
                Box b = new Box(560, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 8)
            {
                Box b = new Box(590, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 10)
            {
                Box b = new Box(620, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter <= 12)
            {
                Box b = new Box(650, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter >= 10)
            {
                Box b = new Box(750, this.Height, 25, -7, 0);
                boxes.Add(b);
            }

            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level11()
        {
            titleLabel.Text = "Piano Keys";
            this.BackColor = System.Drawing.Color.FromArgb(70, 200, 255);
            if (newBoxCounter == 38)
            {
                Box b = new Box(200, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 36)
            {
                Box b = new Box(230, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 34)
            {
                Box b = new Box(260, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 32)
            {
                Box b = new Box(290, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 30)
            {
                Box b = new Box(320, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 28)
            {
                Box b = new Box(350, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 26)
            {
                Box b = new Box(380, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 24)
            {
                Box b = new Box(410, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 22)
            {
                Box b = new Box(440, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 20)
            {
                Box b = new Box(470, 0, 20, 4, 0);
                boxes.Add(b);
            }

            if (newBoxCounter == 18)
            {
                Box b = new Box(500, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 16)
            {
                Box b = new Box(530, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 14)
            {
                Box b = new Box(560, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 12)
            {
                Box b = new Box(590, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 10)
            {
                Box b = new Box(620, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 8)
            {
                Box b = new Box(650, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 6)
            {
                Box b = new Box(680, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 4)
            {
                Box b = new Box(710, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 2)
            {
                Box b = new Box(740, 0, 20, 4, 0);
                boxes.Add(b);
            }

            if (newBoxCounter == 48)
            {
                newBoxCounter = 0;
            }
        }
        public void level12()
        {
            titleLabel.Text = "Pew Pew Pew";
            this.BackColor = System.Drawing.Color.LightGreen;
            if (newBoxCounter >= 30)
            {
                Box b = new Box(100, 100, 10, 0, 4);
                boxes.Add(b);
                Box c = new Box(600, 0, 10, 4, 0);
                boxes.Add(c);
                Box a = new Box(100, 300, 10, -3, 4);
                boxes.Add(a);
                Box d = new Box(750, 0, 10, 5, 0);
                boxes.Add(d);
            }
            if (newBoxCounter >= 30)
            {
                Box b = new Box(300, 0, 10, 3, 1);
                boxes.Add(b);
                Box a = new Box(100, 500, 10, -3, 4);
                boxes.Add(a);
                Box c = new Box(300, 500, 10, -3, 4);
                boxes.Add(c);
            }
            if (newBoxCounter >= 40)
            {
                newBoxCounter = 0;
            }
        }
        public void level13()
        {
            titleLabel.Text = "Hurry";
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            if (newBoxCounter <= 15)
            {
                Box b = new Box(200, 500, 5, -5, 0);
                boxes.Add(b);
                Box a = new Box(300, 0, 5, boxyspeed, 0);
                boxes.Add(a);
                Box c = new Box(370, 0, 5, 20, 0);
                boxes.Add(c);
            }
            if (newBoxCounter == 34)
            {
                Box b = new Box(440, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 26)
            {
                Box b = new Box(470, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 18)
            {
                Box b = new Box(500, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 12)
            {
                Box b = new Box(530, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (newBoxCounter == 6)
            {
                Box b = new Box(560, 0, 20, 4, 0);
                boxes.Add(b);
            }
            if (doorCounter >= 12)
            {
                if (newBoxCounter == 10)
                {
                    Box a = new Box(700, 500, 70, -1, 0);
                    boxes.Add(a);
                }
            }
            if (newBoxCounter == 40)
            {
                newBoxCounter = 0;
                doorCounter ++;
            }
        }
        public void level14()
        {
            titleLabel.Text = "Invisible Grid";
            this.BackColor = System.Drawing.Color.Ivory;
            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Jungle.mp3")));
            Form1.Background.Stop();
            Form1.Background.Play();

            if (newBoxCounter >= 30)
            {
                Box b = new Box(650, 0, 10, 4, 0);
                //boxes.Add(b);
                Box c = new Box(700, 0, 10, 4, 0);
                boxes.Add(c);
                Box a = new Box(200, 0, 10, 5, 0);
                boxes.Add(a);
                Box d = new Box(250, 0, 10, 4, 0);
                //boxes.Add(d);
                Box e = new Box(300, 0, 10, 6, 0);
                boxes.Add(e);
                Box g = new Box(350, 0, 10, 4, 0);
                //boxes.Add(g);
                Box f = new Box(400, 0, 10, 4, 0);
                boxes.Add(f);
                Box h = new Box(450, 0, 10, 4, 0);
                //boxes.Add(h);
                Box i = new Box(500, 0, 10, 7, 0);
                boxes.Add(i);
                //Box j = new Box(550, 0, 10, 4, 0);
                //boxes.Add(j);
                Box k = new Box(600, 0, 10, 4, 0);
                boxes.Add(k);

            }
            if (newBoxCounter >= 30)
            {
                Box b = new Box(200, 50, 10, 0, 4);
                boxes.Add(b);
                Box a = new Box(200, 100, 10, 0, 4);
                //boxes.Add(a);
                Box c = new Box(200, 150, 10, 0, 4);
                boxes.Add(c);
                Box d = new Box(200, 200, 10, 0, 4);
                //boxes.Add(d);
                Box e = new Box(200, 250, 10, 0, 4);
                boxes.Add(e);
                Box g = new Box(200, 300, 10, 0, 8);
                //boxes.Add(g);
                Box f = new Box(200, 350, 10, 0, 4);
                boxes.Add(f);
                Box h = new Box(200, 400, 10, 0, 4);
                //boxes.Add(h);
                Box i = new Box(200, 450, 10, 0, 6);
                boxes.Add(i);
            }
            if (newBoxCounter >= 40)
            {
                newBoxCounter = 0;
            }

        }
        public void level15()
        {
            titleLabel.Text = "Welcome to the Jungle";
            this.BackColor = System.Drawing.Color.Black;
            if (newBoxCounter >= 30)
            {
                Box b = new Box(100, 0, 10, 4, 0);
                boxes.Add(b);
                Box c = new Box(150, 0, 10, 4, 0);
                boxes.Add(c);
                Box a = new Box(200, 500, 10, -4, 0);
                boxes.Add(a);
                Box d = new Box(250, 0, 10, 4, 0);
                boxes.Add(d);
                Box e = new Box(300, 0, 10, 4, 2);
                boxes.Add(e);
                Box g = new Box(350, 0, 10, 4, 0);
                boxes.Add(g);
                Box f = new Box(400, 0, 10, 4, 0);
                boxes.Add(f);
                Box h = new Box(450, 500, 10, -4, 0);
                boxes.Add(h);
                Box i = new Box(500, 0, 10, 4, 0);
                boxes.Add(i);
                Box j = new Box(550, 0, 10, 4, 0);
                boxes.Add(j);
                Box k = new Box(600, 0, 10, 4, -2);
                boxes.Add(k);
                Box x = new Box(650, 0, 10, 4, 0);
                boxes.Add(x);
                Box z = new Box(700, 200, 10, -4, 0);
                boxes.Add(z);
                Box v = new Box(750, 0, 10, 4, 0);
                boxes.Add(v);
                Box m = new Box(800, 0, 10, 4, 0);
                boxes.Add(m);

            }
            if (newBoxCounter >= 30)
            {
                Box b = new Box(100, 50, 10, 0, 4);
                boxes.Add(b);
                Box a = new Box(700, 100, 10, 0, -4);
                boxes.Add(a);
                Box c = new Box(100, 150, 10, 0, 4);
                boxes.Add(c);
                Box d = new Box(100, 200, 10, 0, 4);
                boxes.Add(d);
                Box e = new Box(700, 250, 10, 0, -4);
                boxes.Add(e);
                Box g = new Box(100, 300, 10, 0, 4);
                boxes.Add(g);
                Box f = new Box(100, 350, 10, 0, 4);
                boxes.Add(f);
                Box h = new Box(700, 400, 10, 0, -4);
                boxes.Add(h);
                Box i = new Box(200, 450, 10, 0, 4);
                boxes.Add(i);
            }
            if (newBoxCounter >= 40)
            {
                newBoxCounter = 0;
            }

        }



        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Form1.Background.Stop();
                
                Menu ms = new Menu();
                Form form = this.FindForm();

                form.Controls.Add(ms);
                form.Controls.Remove(this);

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //TODO - update location of all boxes (drop down screen)
            foreach (Box b in boxes)
            {
                b.Move();
                //check for collision between hero and boxes               
            }
            Form1.currentScore = sideCounter;
            scoreLabel.Text = "Levels Completed: " + Convert.ToString(sideCounter);

            //add new box if it is time
            newBoxCounter++;
            //Level 1
            if (sideCounter == 0)
            {
                level1();      
            }   
            //Level 2
            if (sideCounter == 1)
            {
                level2();               
            }
            //level 3
            if (sideCounter == 2)
            {
                level3();   
            }
            //level 4
            if (sideCounter == 3)
            {
                level4();        
            }
            //level 5
            if (sideCounter == 4)
            {
                level5();            
            }
            //level 6
            if (sideCounter == 5)
            {
                level6();
            }
            //level 7
            if (sideCounter == 6)
            {
                level7();
            }
            //level 8
            if (sideCounter == 7)
            {
                level8();
            }
            //level 9
            if (sideCounter == 8)
            {
                level9();
            }
            //level 10
            if (sideCounter == 9)
            {
                level10();
            }
            //level 11
            if (sideCounter == 10)
            {
                level11();
            }
            if (sideCounter == 11)
            {
                level12();
            }
            if (sideCounter == 12)
            {
                level13();
            }
            if (sideCounter == 13)
            {
                level14();
            }
            if (sideCounter == 14)
            {
                if (Form1.gamemode == 2)
                {
                    gameLoop.Stop();

                    Form form = this.FindForm();
                    Menu ms = new Menu();
                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);
                }
                if (Form1.gamemode == 1)
                {
                    level15();
                }            
            }
            if (sideCounter == 15)
            {
                gameLoop.Stop();


                LoseScreen ls = new LoseScreen();
                Form form = this.FindForm();
                ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);

                form.Controls.Add(ls);
                form.Controls.Remove(this);
            }
            //this is a placeholder for more levels
            //sideCounter = 0;

            List<int> boxesToRemove = new List<int>();
            //remove box if it has gone of screen vertical
            foreach (Box b in boxes)
            {
                if (b.yspeed < 0 && (b.y + b.size) < -100)
                {
                    boxesToRemove.Add(boxes.IndexOf(b));
                    
                }
                if (b.yspeed > 0 && (b.y + b.size) > this.Height + 100)
                {
                    boxesToRemove.Add(boxes.IndexOf(b));
                    
                }           
            }
            boxesToRemove.Sort();
            boxesToRemove.Reverse();

            //remove boxes from its original list based on index values
            foreach (int i in boxesToRemove)
            {
                boxes.RemoveAt(i);
            }

            boxesToRemove.Clear();

            //remove box if it has gone of screen horizontal
            foreach (Box b in boxes)
            {
                if (b.xspeed < 0 && (b.x + b.size) < this.Width - 800)
                {
                    boxesToRemove.Add(boxes.IndexOf(b));
                   
                }
                if (b.xspeed > 0 && (b.x + b.size) > this.Width - 100)
                {
                    boxesToRemove.Add(boxes.IndexOf(b));
                    
                }
            }
            boxesToRemove.Sort();
            boxesToRemove.Reverse();

            //remove boxes from its original list based on index values
            foreach (int i in boxesToRemove)
            {
                boxes.RemoveAt(i);
            }

            if (hero.x > this.Width - 50)
            {
                //Random randonGen = new Random();
                //Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
                //randonGen.Next(255));
                sideCounter++;
                hero.Move("right");
                hero.Move("right");
            }

            //move hero
            if (leftArrowDown)
            {
                hero.Move("left");                
            }
            if (rightArrowDown)
            {
                hero.Move("right");
            }
            if (upArrowDown)
            {
                hero.Move("up");
            }
            if (downArrowDown)
            {
                hero.Move("down");
            }

            foreach (Box b in boxes)
            {
                if (hero.Collision(b))
                {
                    if (Form1.gamemode == 1)
                    {
                        gameLoop.Stop();

                        
                        LoseScreen ls = new LoseScreen();
                        Form form = this.FindForm();
                        ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);

                        form.Controls.Add(ls);
                        form.Controls.Remove(this);
                        break;
                    }
                    if (Form1.gamemode == 2)
                    {
                        hero = new Box(50, 250, 20, heroyspeed, 0);
                        break;
                    }
                }
            }
            Refresh();   
        }


        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw boxes to screen
            foreach (Box b in boxes)
            {
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
            }
            e.Graphics.FillRectangle(boxBrush, hero.x, hero.y, hero.size, hero.size);
        }
    }
}
