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
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(211, 139);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(136, 20);
            this.inputText.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Super Mario 256", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(222, 206);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Font = new System.Drawing.Font("Super Mario 256", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.Location = new System.Drawing.Point(219, 93);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(48, 12);
            this.yourScoreLabel.TabIndex = 2;
            this.yourScoreLabel.Text = "label1";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
