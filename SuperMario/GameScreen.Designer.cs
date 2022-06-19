namespace SuperMario
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTicker = new System.Windows.Forms.Timer(this.components);
            this.lifeCounterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTicker
            // 
            this.gameTicker.Enabled = true;
            this.gameTicker.Interval = 10;
            this.gameTicker.Tick += new System.EventHandler(this.gameTicker_Tick);
            // 
            // lifeCounterLabel
            // 
            this.lifeCounterLabel.AutoSize = true;
            this.lifeCounterLabel.Location = new System.Drawing.Point(24, 23);
            this.lifeCounterLabel.Name = "lifeCounterLabel";
            this.lifeCounterLabel.Size = new System.Drawing.Size(35, 13);
            this.lifeCounterLabel.TabIndex = 0;
            this.lifeCounterLabel.Text = "label1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.Controls.Add(this.lifeCounterLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 375);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTicker;
        private System.Windows.Forms.Label lifeCounterLabel;
    }
}
