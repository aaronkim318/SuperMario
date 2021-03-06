using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
namespace SuperMario
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            highScoreLabel.Text = "";
            nameLabel.Text = "";

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Go to the instruction screen
            InstructionScreen ins = new InstructionScreen();
            this.Controls.Add(ins);

            ins.Location = new Point((this.Width - ins.Width) / 2, (this.Height - ins.Height) / 2);

            startButton.Visible = false;
            exitButton.Visible = false;
            titleLabel.Visible = false;
        }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit if the button is clicked
            Application.Exit();
        }

    }
}
