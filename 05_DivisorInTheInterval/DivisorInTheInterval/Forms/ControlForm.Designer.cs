namespace DivisorInTheInterval.Forms
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
            this.intervalStartTextBox = new System.Windows.Forms.TextBox();
            this.intervalEndTextBox = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.dividerTextBox = new System.Windows.Forms.TextBox();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // intervalStartTextBox
            // 
            this.intervalStartTextBox.Location = new System.Drawing.Point(107, 36);
            this.intervalStartTextBox.Name = "intervalStartTextBox";
            this.intervalStartTextBox.Size = new System.Drawing.Size(100, 20);
            this.intervalStartTextBox.TabIndex = 0;
            this.intervalStartTextBox.Tag = "IntervalStart";
            // 
            // intervalEndTextBox
            // 
            this.intervalEndTextBox.Location = new System.Drawing.Point(107, 62);
            this.intervalEndTextBox.Name = "intervalEndTextBox";
            this.intervalEndTextBox.Size = new System.Drawing.Size(100, 20);
            this.intervalEndTextBox.TabIndex = 1;
            this.intervalEndTextBox.Tag = "IntervalEnd";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(12, 39);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(68, 13);
            this.startLabel.TabIndex = 2;
            this.startLabel.Tag = "1";
            this.startLabel.Text = "Interval start:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(12, 65);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(66, 13);
            this.endLabel.TabIndex = 3;
            this.endLabel.Tag = "2";
            this.endLabel.Text = "Interval end:";
            // 
            // dividerTextBox
            // 
            this.dividerTextBox.Location = new System.Drawing.Point(310, 49);
            this.dividerTextBox.Name = "dividerTextBox";
            this.dividerTextBox.Size = new System.Drawing.Size(100, 20);
            this.dividerTextBox.TabIndex = 4;
            this.dividerTextBox.Tag = "Divider";
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Location = new System.Drawing.Point(223, 52);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(81, 13);
            this.dividerLabel.TabIndex = 5;
            this.dividerLabel.Tag = "3";
            this.dividerLabel.Text = "Divider number:";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(176, 105);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 6;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.ExecutemButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputRichTextBox.Location = new System.Drawing.Point(1, 145);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(421, 149);
            this.outputRichTextBox.TabIndex = 7;
            this.outputRichTextBox.Text = "";
            // 
            // toolbarMenuStrip
            // 
            this.toolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMenuItem,
            this.editToolStripMenuItem});
            this.toolbarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.toolbarMenuStrip.Name = "toolbarMenuStrip";
            this.toolbarMenuStrip.Size = new System.Drawing.Size(422, 24);
            this.toolbarMenuStrip.TabIndex = 8;
            this.toolbarMenuStrip.Text = "Eszköztár";
            // 
            // fileTSMenuItem
            // 
            this.fileTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTSMenuItem,
            this.saveTSMenuItem});
            this.fileTSMenuItem.Name = "fileTSMenuItem";
            this.fileTSMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileTSMenuItem.Text = "File";
            // 
            // openTSMenuItem
            // 
            this.openTSMenuItem.Name = "openTSMenuItem";
            this.openTSMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openTSMenuItem.Text = "&Open";
            this.openTSMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // saveTSMenuItem
            // 
            this.saveTSMenuItem.Name = "saveTSMenuItem";
            this.saveTSMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveTSMenuItem.Text = "&Save";
            this.saveTSMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontTSMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontTSMenuItem
            // 
            this.fontTSMenuItem.Name = "fontTSMenuItem";
            this.fontTSMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fontTSMenuItem.Text = "&Font Type";
            this.fontTSMenuItem.Click += new System.EventHandler(this.Font_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 294);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.dividerTextBox);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.intervalEndTextBox);
            this.Controls.Add(this.intervalStartTextBox);
            this.Controls.Add(this.toolbarMenuStrip);
            this.MainMenuStrip = this.toolbarMenuStrip;
            this.Name = "ControlForm";
            this.Text = "Divisor in the Interval";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.toolbarMenuStrip.ResumeLayout(false);
            this.toolbarMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intervalStartTextBox;
        private System.Windows.Forms.TextBox intervalEndTextBox;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox dividerTextBox;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.MenuStrip toolbarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontTSMenuItem;
    }
}

