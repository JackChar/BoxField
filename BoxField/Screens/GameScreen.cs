using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        int boxSize, boxSpeed, newBoxCounter;

        private void restartButton_Click(object sender, EventArgs e)
        {
            pressAnyLabel.Visible = true;
            OnStart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }

        Box hero;
        int heroSpeed;
        int sideCounter = 0;

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

            restartButton.Visible = false;
            exitButton.Visible = false;

            boxSize = 20;
            boxSpeed = 5;
            newBoxCounter = 0;

            //TODO - set game start values
            Box b = new Box(200,0, boxSize, boxSpeed);

            heroSpeed = 7;
            hero = new BoxField.Box(50, 250, 20, heroSpeed);

            boxes.Add(b);
            //leftArrowDown = true;
            //rightArrowDown = true;
            //downArrowDown = true;
            //upArrowDown = true;

            leftArrowDown = false;
            rightArrowDown = false;
            downArrowDown = false;
            upArrowDown = false;

            gameLoop.Enabled = true;
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
            if(e.KeyCode == Keys.Escape) { Application.Exit(); }
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
            scoreLabel.Text = "Score: " + Convert.ToString(sideCounter);

            //add new box if it is time
            newBoxCounter++;
            //Level 1
            if (sideCounter == 0)
            {
                if (newBoxCounter <= 20)
                {
                    Box b = new Box(200, 0, boxSize, boxSpeed);
                    boxes.Add(b);
                    Box a = new Box(400, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                }
                if (newBoxCounter >= 20)
                {
                    Box b = new Box(600, 0, boxSize, boxSpeed);
                    boxes.Add(b);
                    Box a = new Box(800, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }
                
            }
            //Level 2
            if (sideCounter == 1)
            {
                this.BackColor = System.Drawing.Color.DarkBlue;
                if (newBoxCounter <= 20)
                {
                    Box b = new Box(200, 0, boxSize, boxSpeed);
                    boxes.Add(b);
                    Box a = new Box(300, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                }
                if (newBoxCounter >= 20)
                {
                    Box b = new Box(600, 0, 20, 10);
                    boxes.Add(b);
                    Box a = new Box(800, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }
                
            }
            //level 3
            if (sideCounter == 2)
            {
                this.BackColor = System.Drawing.Color.Blue;
                if (newBoxCounter <= 20)
                {
                    Box b = new Box(200, 500, boxSize, -boxSpeed);
                    boxes.Add(b);
                    Box a = new Box(300, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                }
                if (newBoxCounter >= 20)
                {
                    Box b = new Box(500, 0, 20, 10);
                    boxes.Add(b);
                    Box a = new Box(800, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                    Box c = new Box(700, 500, boxSize, -boxSpeed);
                    boxes.Add(c);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }
                
            }
            //level 4
            if (sideCounter == 3)
            {
                this.BackColor = System.Drawing.Color.Green;
                if (newBoxCounter <= 20)
                {
                    Box b = new Box(200, 500, 15, -5);
                    boxes.Add(b);
                    Box a = new Box(300, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                }
                if (newBoxCounter >= 25)
                {
                    Box b = new Box(500, 0, 20, 10);
                    boxes.Add(b);
                    Box d = new Box(600, 250, 30, -6);
                    boxes.Add(d);
                    Box f = new Box(600, 250, 30, 6);
                    boxes.Add(f);
                    Box a = new Box(800, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                    Box c = new Box(700, 500, boxSize, -boxSpeed + 5);
                    boxes.Add(c);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }
               
            }
            //level 5
            if (sideCounter == 4)
            {
                this.BackColor = System.Drawing.Color.DarkOliveGreen;
                if (newBoxCounter <= 15)
                {
                    Box b = new Box(200, 500, 15, -5);
                    boxes.Add(b);
                    Box a = new Box(300, 0, boxSize, boxSpeed);
                    boxes.Add(a);            
                    Box c = new Box(400, 0, 2, 20);
                    boxes.Add(c);
                }
                if (newBoxCounter >= 25)
                {
                    Box b = new Box(500, 0, 20, 10);
                    boxes.Add(b);
                    Box d = new Box(600, 250, 30, -5);
                    boxes.Add(d);
                    Box f = new Box(600, 250, 30, 5);
                    boxes.Add(f);
                    Box a = new Box(800, 0, boxSize, boxSpeed);
                    boxes.Add(a);
                    Box c = new Box(700, 500, boxSize, -17);
                    boxes.Add(c);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }             
            }
            //level 6
            if (sideCounter == 5)
            {
                this.BackColor = System.Drawing.Color.DarkGreen;
                if (newBoxCounter <= 20)
                {
                    Box b = new Box(200, 500, 50, -10);
                    boxes.Add(b);
                    Box a = new Box(325, 0, 3, boxSpeed);
                    boxes.Add(a);
                    Box c = new Box(425, 0, 3, 20);
                    boxes.Add(c);
                }
                if (newBoxCounter >= 38)
                {
                    Box b = new Box(500, 0, 20, 10);
                    boxes.Add(b);
                    Box d = new Box(600, 500, 10, -6);
                    boxes.Add(d);
                    Box f = new Box(610, 500, 10, -5);
                    boxes.Add(f);
                    Box a = new Box(800, 500, 50, -boxSpeed);
                    boxes.Add(a);
                    Box c = new Box(700, 500, 8, -50);
                    boxes.Add(c);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }
            }
            //level 7
            if (sideCounter == 6)
            {
                this.BackColor = System.Drawing.Color.Purple;
                if (newBoxCounter <= 2)
                {
                    Box b = new Box(200, 500, 50, -4);
                    boxes.Add(b);
                    Box a = new Box(325, 0, 50, boxSpeed);
                    boxes.Add(a);
                    Box c = new Box(425, 0, 25, 20);
                    boxes.Add(c);
                }
                if (newBoxCounter >= 38)
                {
                    Box b = new Box(500, 0, 25, 4);
                    boxes.Add(b);
                    Box d = new Box(600, 500, 50, -4);
                    boxes.Add(d);
                    Box a = new Box(800, 500, 50, -13);
                    boxes.Add(a);
                    Box c = new Box(700, 500, 25, -32);
                    boxes.Add(c);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }
            }
            //level 8
            if (sideCounter == 7)
            {
                this.BackColor = System.Drawing.Color.Yellow;
                if (newBoxCounter <= 25)
                {
                    Box b = new Box(200, 0, 25, 7);
                    boxes.Add(b);
                    Box a = new Box(300, 0, 25, 7);
                    boxes.Add(a);
                    Box c = new Box(250, 0, 25, 7);
                    boxes.Add(c);

                    Box f = new Box(395, 500, 50, -7);
                    boxes.Add(f);
                    Box d = new Box(455, 500, 50, -7);
                    boxes.Add(d);
                }
                if (newBoxCounter >= 38)
                {
                    Box b = new Box(570, 0, 50, 7);
                    boxes.Add(b);
                    Box d = new Box(620, 0, 50, 7);
                    boxes.Add(d);
                    Box a = new Box(670, 500, 50, -7);
                    boxes.Add(a);
                    Box c = new Box(720, 500, 50, -7);
                    boxes.Add(c);
                }
                if (newBoxCounter == 40)
                {
                    newBoxCounter = 0;
                }
            }
            //level 9
            if (sideCounter == 8)
            {
                //this is a placeholder for more levels
                sideCounter = 0;
            }



            //remove box if it has gone of screen 
            foreach (Box b in boxes)
            {
                if (b.speed < 0 && (b.y + b.size) < -50)
                {
                    boxes.Remove (b);
                    break;
                }
                if (b.speed > 0 && (b.y + b.size) > 550)
                {
                    boxes.Remove(b);
                    break;
                }
            }
            if (boxes[0].y > this.Height + 10)
            {
                boxes.RemoveAt(0);
            }
            if (boxes[0].y < -10)
            {
                boxes.RemoveAt(0);
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
                pressAnyLabel.Visible = false;
            }
            if (rightArrowDown)
            {
                hero.Move("right");
                pressAnyLabel.Visible = false;
            }
            if (upArrowDown)
            {
                hero.Move("up");
                pressAnyLabel.Visible = false;
            }
            if (downArrowDown)
            {
                hero.Move("down");
                pressAnyLabel.Visible = false;
            }

            foreach (Box b in boxes)
            {
                if (hero.Collision(b))
                {
                    gameLoop.Stop();
                    restartButton.Visible = true;
                    //exitButton.Visible = true;
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
