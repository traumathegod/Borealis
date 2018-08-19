namespace Borealis
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.HostnameTextBox = new System.Windows.Forms.TextBox();
            this.settingsCancel = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.PortNumericUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hostname";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(12, 83);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(380, 20);
            this.UserTextBox.TabIndex = 7;
            // 
            // HostnameTextBox
            // 
            this.HostnameTextBox.Location = new System.Drawing.Point(12, 25);
            this.HostnameTextBox.Name = "HostnameTextBox";
            this.HostnameTextBox.Size = new System.Drawing.Size(301, 20);
            this.HostnameTextBox.TabIndex = 6;
            // 
            // settingsCancel
            // 
            this.settingsCancel.Location = new System.Drawing.Point(317, 109);
            this.settingsCancel.Name = "settingsCancel";
            this.settingsCancel.Size = new System.Drawing.Size(75, 23);
            this.settingsCancel.TabIndex = 13;
            this.settingsCancel.Text = "Cancel";
            this.settingsCancel.UseVisualStyleBackColor = true;
            this.settingsCancel.Click += new System.EventHandler(this.SettingsOk_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 109);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(341, 9);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(26, 13);
            this.Port.TabIndex = 16;
            this.Port.Text = "Port";
            // 
            // PortNumericUD
            // 
            this.PortNumericUD.Location = new System.Drawing.Point(320, 26);
            this.PortNumericUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PortNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PortNumericUD.Name = "PortNumericUD";
            this.PortNumericUD.Size = new System.Drawing.Size(72, 20);
            this.PortNumericUD.TabIndex = 17;
            this.PortNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 152);
            this.Controls.Add(this.PortNumericUD);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.settingsCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.HostnameTextBox);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox HostnameTextBox;
        private System.Windows.Forms.Button settingsCancel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.NumericUpDown PortNumericUD;
    }
}