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
    public partial class MusicScreen : UserControl
    {
        int index = 0;
        int lastIndex = 0;

        public MusicScreen()
        {
            InitializeComponent();

            //Label1.Parent = pictureBox1;
            titleLabel.Parent = pictureBox1;

            practiceLabel.Parent = pictureBox1;
            highScoreLabel.Parent = pictureBox1;
            exitLabel.Parent = pictureBox1;
            startLabel.Parent = pictureBox1;
        }

        private void MusicScreen_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    

        private void MusicScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                        index = 8;
                    }
                    break;
                case Keys.Down:

                    //play sound
                    Form1.pick.Stop();
                    Form1.pick.Play();

                    if (index != 8)
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

                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Flames.mp3")));


                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs = new GameScreen();
                            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

                            form.Controls.Add(gs);
                            form.Controls.Remove(this);

                            break;

                        //highscore button
                        case 1:

                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Love.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs2 = new GameScreen();
                            gs2.Location = new Point((form.Width - gs2.Width) / 2, (form.Height - gs2.Height) / 2);

                            form.Controls.Add(gs2);
                            form.Controls.Remove(this);

                            break;

                        //practise button
                        case 2:
                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Moonlight.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs3 = new GameScreen();
                            gs3.Location = new Point((form.Width - gs3.Width) / 2, (form.Height - gs3.Height) / 2);

                            form.Controls.Add(gs3);
                            form.Controls.Remove(this);

                            break;

                        //exit button
                        case 3:
                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Poker.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs4 = new GameScreen();
                            gs4.Location = new Point((form.Width - gs4.Width) / 2, (form.Height - gs4.Height) / 2);

                            form.Controls.Add(gs4);
                            form.Controls.Remove(this);

                            break;
                        case 4:
                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Requiem.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs5 = new GameScreen();
                            gs5.Location = new Point((form.Width - gs5.Width) / 2, (form.Height - gs5.Height) / 2);

                            form.Controls.Add(gs5);
                            form.Controls.Remove(this);
                            break;
                        case 5:
                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Skyrim.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs6 = new GameScreen();
                            gs6.Location = new Point((form.Width - gs6.Width) / 2, (form.Height - gs6.Height) / 2);

                            form.Controls.Add(gs6);
                            form.Controls.Remove(this);
                            break;
                        case 6:
                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Touch.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs7 = new GameScreen();
                            gs7.Location = new Point((form.Width - gs7.Width) / 2, (form.Height - gs7.Height) / 2);

                            form.Controls.Add(gs7);
                            form.Controls.Remove(this);
                            break;
                        case 7:
                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Take.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs8 = new GameScreen();
                            gs8.Location = new Point((form.Width - gs8.Width) / 2, (form.Height - gs8.Height) / 2);

                            form.Controls.Add(gs8);
                            form.Controls.Remove(this);
                            break;
                        case 8:
                            Form1.Background.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Countdown.mp3")));

                            //play sound
                            Form1.Background.Stop();
                            Form1.Background.Play();

                            GameScreen gs9 = new GameScreen();
                            gs9.Location = new Point((form.Width - gs9.Width) / 2, (form.Height - gs9.Height) / 2);

                            form.Controls.Add(gs9);
                            form.Controls.Remove(this);
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
                case 4:
                    label1.ForeColor = Color.White;
                    break;
                case 5:
                    label2.ForeColor = Color.White;
                    break;
                case 6:
                    label3.ForeColor = Color.White;
                    break;
                case 7:
                    label4.ForeColor = Color.White;
                    break;
                case 8:
                    label5.ForeColor = Color.White;
                    break;

            }

            //set selected button to red
            switch (index)
            {
                case 0:
                    startLabel.ForeColor = Color.Purple;
                    break;
                case 1:
                    highScoreLabel.ForeColor = Color.Purple;
                    break;
                case 2:
                    practiceLabel.ForeColor = Color.Purple;
                    break;
                case 3:
                    exitLabel.ForeColor = Color.Purple;
                    break;
                case 4:
                    label1.ForeColor = Color.Purple;
                    break;
                case 5:
                    label2.ForeColor = Color.Purple;
                    break;
                case 6:
                    label3.ForeColor = Color.Purple;
                    break;
                case 7:
                    label4.ForeColor = Color.Purple;
                    break;
                case 8:
                    label5.ForeColor = Color.Purple;
                    break;

            }
            if (e.KeyCode == Keys.Escape)
            {
                Menu ms = new Menu();
                form = this.FindForm();

                form.Controls.Add(ms);
                form.Controls.Remove(this);

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            }
        }
    }
}
