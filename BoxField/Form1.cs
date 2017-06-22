using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Media;
using System.IO;

namespace BoxField
{
    public partial class Form1 : Form
    {
        public static SoundPlayer pickPlayer;

        public static List<Highscore> highscoreList = new List<Highscore>();
        public static int gamemode;
        public static int currentScore;
        

        //sound library
        public static System.Windows.Media.MediaPlayer pick;
        public static System.Windows.Media.MediaPlayer Background;
        


        public Form1()
        {
            InitializeComponent();

            pickPlayer = new SoundPlayer(Properties.Resources.Pick);

            pick = new System.Windows.Media.MediaPlayer();
            pick.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources/Beep_1.wav")));
            pick.Volume = 1;
            
            Background = new System.Windows.Media.MediaPlayer();
            //Background.Volume = 1;
        } 

        private void loadHighscores() //method for loading any saved highscores in the highscoreDB xml file
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("highscoreDB.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                Highscore hs = new Highscore(null, null);
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    if (grandChild.Name == "name")
                    {
                        hs.name = grandChild.InnerText;
                    }
                    if (grandChild.Name == "score")
                    {
                        hs.score = grandChild.InnerText;
                    }
                }
                highscoreList.Add(hs);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Program goes directly to the GameScreen method on start
            Menu ms = new Menu();
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);

            //GameScreen gs = new GameScreen();
            //this.Controls.Add(gs);
            loadHighscores();

        }
    }
}
