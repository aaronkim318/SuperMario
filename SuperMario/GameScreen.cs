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
using System.Threading;
using System.Xml;

namespace SuperMario
{

    public partial class GameScreen : UserControl
    {
        #region global variables

        //space bar boolean
        Boolean jumpOk = true;

        int jumpCounter;

        Mario mario;

        //list of goombas
        List<Goomba> goombaList = new List<Goomba>();
        //list of blocks
        List<Block> blocks = new List<Block>();

        //the hieght of the ground 
        int groundHeight = 70;

        //speed of block
        int blockSpeed = 8;

        int goombaSpeed = 6;

        //random value
        int blockRandValue;
        int goombaRandValue;
        Random rand = new Random();

        int lifeCounter = 3;

        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            lifeCounterLabel.Text = "";
            lifeCounterLabel.Text = $"{lifeCounter}";
        }

        public void OnStart()
        {

            mario = new Mario(60, this.Height - groundHeight - 95, 100);
        }
        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {

                case Keys.Space:
                    jumpOk = true;
                    if (jumpOk == true)
                    {
                        jumpOk = false;
                    }
                    break;
                case Keys.Enter:
                    if (gameTicker.Enabled)
                    {
                        gameTicker.Enabled = false;
                    }
                    else
                    {
                        gameTicker.Enabled = true;
                    }
                    break;



            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    jumpOk = false;
                    break;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //the brackground of the game
            e.Graphics.FillRectangle(Brushes.SkyBlue, 0, 0, this.Width, this.Height);
            e.Graphics.FillRectangle(Brushes.Lime, 0, this.Height - groundHeight, this.Width, groundHeight);
            //drawing mario
            e.Graphics.DrawImage(Properties.Resources.Running_mario_Gif, mario.x, mario.y, mario.size, mario.size);

            //draw the rectangles
            foreach (Block b in blocks)
            {
                e.Graphics.DrawImage(Properties.Resources.mario_block, b.x, b.y, b.length, b.height);
            }
            //draw the Goombas
            foreach (Goomba g in goombaList)
            {
                e.Graphics.DrawImage(Properties.Resources.goomba, g.x, g.y, g.size, g.size);
            }
        }
        public void GoUp()
        {
            //jumping up code
            if (jumpCounter <= 24)
            {
                mario.y -= 6;
            }
            else if (jumpCounter <= 48)
            {
                mario.y += 6;
            }
            else
            {
                jumpCounter = 0;
                jumpOk = true;
            }
            jumpCounter++;
        }

        private void gameTicker_Tick(object sender, EventArgs e)
        {
            //move the balls
            foreach (Block b in blocks)
            {
                b.x -= blockSpeed;
            }
            //move goomba
            foreach (Goomba g in goombaList)
            {
                g.x -= goombaSpeed;
            }
            //checking to see if a rectangle should be added
            blockRandValue = rand.Next(1, 1000);
            if (blockRandValue < 4)
            {
                int x = 15;
                int y = 60;
                int height = 30;
                int length = 60;
                blocks.Add(new Block(this.Width - x, y, height, length));
            }
            else if (blockRandValue < 8)
            {
                int x = 15;
                int y = 275;
                int height = 30;
                int length = 60;
                blocks.Add(new Block(this.Width - x, y, height, length));
            }
            //checking to see if a goomba should be added
            goombaRandValue = rand.Next(1, 200);
            if (goombaRandValue < 2)
            {
                int size = 40;
                int y = this.Height - groundHeight - size;
                int x = this.Width - 10;
                goombaList.Add(new Goomba(x, y, size));
            }
            //the jump mechanic
            if (jumpOk == false)
            {
                GoUp();
            }
            //removes block when it hits the left wall
            foreach (Block b in blocks)
            {
                if (b.x <= 0)
                {
                    blocks.Remove(b);
                    break;
                }
            }
            //removes the goomba when it hits the left wall
            foreach (Goomba g in goombaList)
            {
                if (g.x <= 0)
                {
                    goombaList.Remove(g);
                    break;
                }

            }
            //checks for collison between mario and a block
            Rectangle marioRec = new Rectangle(mario.x, mario.y, mario.size, mario.size);

            foreach (Block b in blocks)
            {
                Rectangle sideBlockRec = new Rectangle(b.x, b.y, b.length - 50, b.height - 5);
                //if mario collides with the left side of the block, push mario back
                if (marioRec.IntersectsWith(sideBlockRec))
                {
                    //if they have collided, push mario back.
                    mario.x = b.x - b.length;
                }
                else if (mario.x < 1)
                { 
                    lifeCounterLabel.Text = "";
                    lifeCounter = lifeCounter - 1;
                    lifeCounterLabel.Text = $"{lifeCounter}";
                    mario.x = 60;
                    mario.y = this.Height - groundHeight - 95;
                    gameTicker.Enabled = false;
                    blocks.Remove(b);

                    foreach (Goomba g in goombaList)
                    {
                        goombaList.Remove(g);
                        break;
                    }
                    break;
                }
            }
            //if mario collides with the top of the block, have mario on top of the block
            foreach (Block b in blocks)
            {
                Rectangle topBlockRec = new Rectangle(b.x, b.y, b.length, b.height - 20);

                if (marioRec.IntersectsWith(topBlockRec))
                {
                    mario.y = b.y - b.height;
                }
                else
                {
                    mario.y = this.Height - groundHeight - 95;
                }
            }

            Refresh();
        }

    }
}
