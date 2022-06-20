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
        public EndScreen()
        {
            InitializeComponent();
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
    }
}
