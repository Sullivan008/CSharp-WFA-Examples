namespace INIApplicationDemo
{
	partial class ControlForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.readValueLabel = new System.Windows.Forms.Label();
            this.saveSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.readValueResultLabel = new System.Windows.Forms.Label();
            this.userNameResultLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.readValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(16, 29);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User name:";
            // 
            // readValueLabel
            // 
            this.readValueLabel.AutoSize = true;
            this.readValueLabel.Location = new System.Drawing.Point(16, 60);
            this.readValueLabel.Name = "readValueLabel";
            this.readValueLabel.Size = new System.Drawing.Size(65, 13);
            this.readValueLabel.TabIndex = 1;
            this.readValueLabel.Text = "Read value:";
            // 
            // saveSettingsCheckBox
            // 
            this.saveSettingsCheckBox.AutoSize = true;
            this.saveSettingsCheckBox.Location = new System.Drawing.Point(19, 113);
            this.saveSettingsCheckBox.Name = "saveSettingsCheckBox";
            this.saveSettingsCheckBox.Size = new System.Drawing.Size(90, 17);
            this.saveSettingsCheckBox.TabIndex = 5;
            this.saveSettingsCheckBox.Text = "Save settings";
            this.saveSettingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // readValueResultLabel
            // 
            this.readValueResultLabel.AutoSize = true;
            this.readValueResultLabel.Location = new System.Drawing.Point(16, 258);
            this.readValueResultLabel.Name = "readValueResultLabel";
            this.readValueResultLabel.Size = new System.Drawing.Size(65, 13);
            this.readValueResultLabel.TabIndex = 4;
            this.readValueResultLabel.Text = "Read value:";
            // 
            // userNameResultLabel
            // 
            this.userNameResultLabel.AutoSize = true;
            this.userNameResultLabel.Location = new System.Drawing.Point(16, 227);
            this.userNameResultLabel.Name = "userNameResultLabel";
            this.userNameResultLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameResultLabel.TabIndex = 3;
            this.userNameResultLabel.Text = "User name:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(138, 166);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(112, 26);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.userNameTextBox.TabIndex = 7;
            // 
            // readValueTextBox
            // 
            this.readValueTextBox.Location = new System.Drawing.Point(112, 57);
            this.readValueTextBox.Name = "readValueTextBox";
            this.readValueTextBox.Size = new System.Drawing.Size(209, 20);
            this.readValueTextBox.TabIndex = 8;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 316);
            this.Controls.Add(this.readValueTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveSettingsCheckBox);
            this.Controls.Add(this.readValueResultLabel);
            this.Controls.Add(this.userNameResultLabel);
            this.Controls.Add(this.readValueLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "ControlForm";
            this.Text = "INI Application Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label userNameLabel;
		private System.Windows.Forms.Label readValueLabel;
		private System.Windows.Forms.CheckBox saveSettingsCheckBox;
		private System.Windows.Forms.Label readValueResultLabel;
		private System.Windows.Forms.Label userNameResultLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.TextBox readValueTextBox;
	}
}

