namespace JaggedArrayApplicationDemo
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
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.arrayLengthRadioButton = new System.Windows.Forms.RadioButton();
            this.generatingElementsRadioButton = new System.Windows.Forms.RadioButton();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.cleanRadioButton = new System.Windows.Forms.RadioButton();
            this.executeButton = new System.Windows.Forms.Button();
            this.toolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioGroupBox.SuspendLayout();
            this.toolbarMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultRichTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultRichTextBox.Location = new System.Drawing.Point(0, 143);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.resultRichTextBox.Size = new System.Drawing.Size(694, 247);
            this.resultRichTextBox.TabIndex = 0;
            this.resultRichTextBox.Text = "";
            this.resultRichTextBox.WordWrap = false;
            this.resultRichTextBox.TextChanged += new System.EventHandler(this.ResultRichTextBox_TextChanged);
            // 
            // arrayLengthRadioButton
            // 
            this.arrayLengthRadioButton.AutoSize = true;
            this.arrayLengthRadioButton.Location = new System.Drawing.Point(18, 19);
            this.arrayLengthRadioButton.Name = "arrayLengthRadioButton";
            this.arrayLengthRadioButton.Size = new System.Drawing.Size(86, 17);
            this.arrayLengthRadioButton.TabIndex = 1;
            this.arrayLengthRadioButton.TabStop = true;
            this.arrayLengthRadioButton.Tag = "0";
            this.arrayLengthRadioButton.Text = "Arrays length";
            this.arrayLengthRadioButton.UseVisualStyleBackColor = true;
            // 
            // generatingElementsRadioButton
            // 
            this.generatingElementsRadioButton.AutoSize = true;
            this.generatingElementsRadioButton.Location = new System.Drawing.Point(17, 42);
            this.generatingElementsRadioButton.Name = "generatingElementsRadioButton";
            this.generatingElementsRadioButton.Size = new System.Drawing.Size(122, 17);
            this.generatingElementsRadioButton.TabIndex = 2;
            this.generatingElementsRadioButton.TabStop = true;
            this.generatingElementsRadioButton.Tag = "1";
            this.generatingElementsRadioButton.Text = "Generating elements";
            this.generatingElementsRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.cleanRadioButton);
            this.radioGroupBox.Controls.Add(this.arrayLengthRadioButton);
            this.radioGroupBox.Controls.Add(this.generatingElementsRadioButton);
            this.radioGroupBox.Location = new System.Drawing.Point(12, 40);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(158, 86);
            this.radioGroupBox.TabIndex = 3;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Options";
            // 
            // cleanRadioButton
            // 
            this.cleanRadioButton.AutoSize = true;
            this.cleanRadioButton.Location = new System.Drawing.Point(17, 65);
            this.cleanRadioButton.Name = "cleanRadioButton";
            this.cleanRadioButton.Size = new System.Drawing.Size(52, 17);
            this.cleanRadioButton.TabIndex = 3;
            this.cleanRadioButton.TabStop = true;
            this.cleanRadioButton.Tag = "2";
            this.cleanRadioButton.Text = "Clean";
            this.cleanRadioButton.UseVisualStyleBackColor = true;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(231, 70);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(110, 40);
            this.executeButton.TabIndex = 4;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // toolbarMenuStrip
            // 
            this.toolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMenuItem});
            this.toolbarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.toolbarMenuStrip.Name = "toolbarMenuStrip";
            this.toolbarMenuStrip.Size = new System.Drawing.Size(694, 24);
            this.toolbarMenuStrip.TabIndex = 5;
            this.toolbarMenuStrip.Text = "Eszköztár";
            // 
            // fileTSMenuItem
            // 
            this.fileTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTSMenuItem,
            this.saveTSMenuItem,
            this.toolStripSeparator1,
            this.exitTSMenuItem});
            this.fileTSMenuItem.Name = "fileTSMenuItem";
            this.fileTSMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileTSMenuItem.Text = "File";
            // 
            // openTSMenuItem
            // 
            this.openTSMenuItem.Name = "openTSMenuItem";
            this.openTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openTSMenuItem.Tag = "Open";
            this.openTSMenuItem.Text = "Open";
            this.openTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // saveTSMenuItem
            // 
            this.saveTSMenuItem.Enabled = false;
            this.saveTSMenuItem.Name = "saveTSMenuItem";
            this.saveTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveTSMenuItem.Tag = "Save";
            this.saveTSMenuItem.Text = "Save";
            this.saveTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitTSMenuItem
            // 
            this.exitTSMenuItem.Name = "exitTSMenuItem";
            this.exitTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitTSMenuItem.Tag = "Close";
            this.exitTSMenuItem.Text = "Exit";
            this.exitTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 392);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.toolbarMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.toolbarMenuStrip;
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.Text = "Jagged Array Application Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.toolbarMenuStrip.ResumeLayout(false);
            this.toolbarMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox resultRichTextBox;
		private System.Windows.Forms.RadioButton arrayLengthRadioButton;
		private System.Windows.Forms.RadioButton generatingElementsRadioButton;
		private System.Windows.Forms.GroupBox radioGroupBox;
		private System.Windows.Forms.Button executeButton;
		private System.Windows.Forms.MenuStrip toolbarMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveTSMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitTSMenuItem;
		private System.Windows.Forms.RadioButton cleanRadioButton;
	}
}

