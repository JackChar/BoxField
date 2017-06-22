using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace BoxField
{
    public partial class Menu : UserControl
    {
        int index = 0;
        int lastIndex = 0;
        
        public Menu()
        {
            
            InitializeComponent();
            titleLabel.Parent = pictureBox1;
            practiceLabel.Parent = pictureBox1;
            highScoreLabel.Parent = pictureBox1;
            exitLabel.Parent = pictureBox1;
            startLabel.Parent = pictureBox1;
        }
        

        private void startLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs); 
        }

        

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
           
            
        }


        private void Menu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastIndex = index;
            Form form = this.FindForm();
            //to make sure that if you click to the bottom or top you will go to the other end instead of just stopping
            switch (e.KeyCode)
            {
                case Keys.Up:

                    //play sound
                    Form1.pick.Stop();
                    Form1.pick.Play();

                    if (index != 0)
                        index--;
                    else
                    {
                        index = 3;
                    }
                    break;
                case Keys.Down:

                    //play sound
                    Form1.pick.Stop();
                    Form1.pick.Play();

                    if (index != 3)
                        index++;
                    else
                    {
                        index = 0;
                    }
                    break;

                case Keys.Space:
                    switch (index)
                    {
                        //start button
                        case 0:

                            //play sound
                            Form1.pick.Stop();
                            Form1.pick.Play();
                            //Gamemode set to original
                            Form1.gamemode = 1;

                            MusicScreen ms = new MusicScreen();
                            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                            form.Controls.Add(ms);
                            form.Controls.Remove(this);

                            break;

                        //highscore button
                        case 1:

                            //play sound
                            Form1.pick.Stop();
                            Form1.pick.Play();

                            HighscoreScreen hs = new HighscoreScreen();
                            form.Controls.Add(hs);
                            form.Controls.Remove(this);

                            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);

                            break;

                        //practise button
                        case 2:

                            //play sound
                            Form1.pick.Stop();
                            Form1.pick.Play();
                            //Gamemode set to practise
                            Form1.gamemode = 2;

                            MusicScreen ms2 = new MusicScreen();
                            ms2.Location = new Point((form.Width - ms2.Width) / 2, (form.Height - ms2.Height) / 2);

                            form.Controls.Add(ms2);
                            form.Controls.Remove(this);

                            break;

                        //exit button
                        case 3:

                            //play sound
                            Form1.pick.Stop();
                            Form1.pick.Play();
                            Thread.Sleep(1000);

                            Application.Exit();
                            break;
                    }
                    break;
            }
            switch (lastIndex)
            {
                case 0:
                    startLabel.ForeColor = Color.White;
                    break;
                case 1:
                    highScoreLabel.ForeColor = Color.White;
                    break;
                case 2:
                    practiceLabel.ForeColor = Color.White;
                    break;
                case 3:
                    exitLabel.ForeColor = Color.White;
                    break;
            }

            //set selected button to red
            switch (index)
            {
                case 0:
                    startLabel.ForeColor = Color.Red;
                    break;
                case 1:
                    highScoreLabel.ForeColor = Color.Red;
                    break;
                case 2:
                    practiceLabel.ForeColor = Color.Red;
                    break;
                case 3:
                    exitLabel.ForeColor = Color.Red;
                    break;
            }

        }
    }
}
