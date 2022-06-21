namespace SuperMario
{
    partial class EndScreen
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(32, 165);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(136, 20);
            this.inputText.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Super Mario 256", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(32, 213);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Font = new System.Drawing.Font("Super Mario 256", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.Location = new System.Drawing.Point(30, 120);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(48, 12);
            this.yourScoreLabel.TabIndex = 2;
            this.yourScoreLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Super Mario 256", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Over";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperMario.Properties.Resources.mi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inputText);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(600, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label label1;
    }
}
