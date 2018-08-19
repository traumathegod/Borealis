namespace Borealis
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpOpenFormButton = new System.Windows.Forms.Button();
            this.settingsOpenFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpOpenFormButton
            // 
            this.helpOpenFormButton.Location = new System.Drawing.Point(698, 382);
            this.helpOpenFormButton.Name = "helpOpenFormButton";
            this.helpOpenFormButton.Size = new System.Drawing.Size(75, 23);
            this.helpOpenFormButton.TabIndex = 12;
            this.helpOpenFormButton.Text = "Help";
            this.helpOpenFormButton.UseVisualStyleBackColor = true;
            this.helpOpenFormButton.Click += new System.EventHandler(this.helpOpenFormButton_Click);
            // 
            // settingsOpenFormButton
            // 
            this.settingsOpenFormButton.Location = new System.Drawing.Point(698, 320);
            this.settingsOpenFormButton.Name = "settingsOpenFormButton";
            this.settingsOpenFormButton.Size = new System.Drawing.Size(75, 23);
            this.settingsOpenFormButton.TabIndex = 13;
            this.settingsOpenFormButton.Text = "Settings";
            this.settingsOpenFormButton.UseVisualStyleBackColor = true;
            this.settingsOpenFormButton.Click += new System.EventHandler(this.settingsOpenFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1470, 786);
            this.Controls.Add(this.settingsOpenFormButton);
            this.Controls.Add(this.helpOpenFormButton);
            this.Name = "MainForm";
            this.Text = "Borealis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helpOpenFormButton;
        private System.Windows.Forms.Button settingsOpenFormButton;
    }
}

