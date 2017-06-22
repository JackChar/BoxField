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
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();
        }

        private void HighscoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Menu ms = new Menu();
                Form form = this.FindForm();

                form.Controls.Add(ms);
                form.Controls.Remove(this);

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            }
        }

        private void HighscoreScreen_Load(object sender, EventArgs e)
        {
            //outputs highscores in format: (Position). NAME level# score 
            for (int i = 0; i < Form1.highscoreList.Count; i++)
            {
                 top10Output.Text += (i + 1) + ".  " + Form1.highscoreList[i].name + "   Level " + Form1.highscoreList[i].score + "\n";
            }
        }
    }
}
