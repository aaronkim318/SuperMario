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

namespace SuperMario
{
    public partial class EndScreen : UserControl
    {
        public static string nameR,highscoreR;
        public EndScreen()
        {
            InitializeComponent();
            yourScoreLabel.Text = $"Your Score was:{GameScreen.scoreCount}";

            if (GameScreen.prevScore < GameScreen.scoreCount)
            {
                inputText.Visible = true;
                yourScoreLabel.Visible = true;
                saveButton.Visible = true;
                label1.Visible = true;
            }
            else
            {
                inputText.Visible = false;
                yourScoreLabel.Visible = false;
                saveButton.Visible = true;
                label1.Visible = true;
            }
        }
        public void saveDB()
        {
            XmlWriter writer = XmlWriter.Create("Resources/HighScore.xml", null);

            writer.WriteStartElement("Player");


            writer.WriteElementString("Name", inputText.Text);

            writer.WriteElementString("HighScore", Convert.ToString(GameScreen.scoreCount));

            writer.WriteEndElement();
            writer.Close();


        }
        public void loadDB()
        {
            XmlReader reader = XmlReader.Create("Resources/HighScore.xml", null);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {

                    string name = reader.ReadString();

                    reader.ReadToNextSibling("HighScore");
                    string highscore = reader.ReadString();

                    nameR = name;
                    highscoreR = highscore;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (GameScreen.prevScore < GameScreen.scoreCount)
            {
                saveDB();

                inputText.Visible = false;
                yourScoreLabel.Visible = false;
                saveButton.Visible = false;
                label1.Visible = false;

                MenuScreen mn = new MenuScreen();
                this.Controls.Add(mn);

                mn.Location = new Point((this.Width - mn.Width) / 2, (this.Height - mn.Height) / 2);
            }
 
       
        }
    }
}
