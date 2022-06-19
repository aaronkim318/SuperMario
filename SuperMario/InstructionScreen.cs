using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMario
{
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
        }

      
      

        private void backButton_Click_1(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            backButton.Visible = false;
            startButton.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // go the the gamescreen at the center
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);

            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);


            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            backButton.Visible = false;
            startButton.Visible = false;
        }
    }
}
