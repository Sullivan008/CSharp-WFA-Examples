namespace QuadraticEquation.Forms
{
    partial class Control
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
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.calculationButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveStateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(40, 21);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(54, 20);
            this.aTextBox.TabIndex = 3;
            this.aTextBox.Tag = "a";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(12, 24);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(22, 13);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "a =";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(203, 21);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(54, 20);
            this.bTextBox.TabIndex = 5;
            this.bTextBox.Tag = "b";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(175, 24);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(22, 13);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "b =";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(360, 21);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(54, 20);
            this.cTextBox.TabIndex = 7;
            this.cTextBox.Tag = "c";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(332, 24);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(22, 13);
            this.cLabel.TabIndex = 6;
            this.cLabel.Text = "c =";
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(91, 97);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(91, 25);
            this.calculationButton.TabIndex = 8;
            this.calculationButton.Text = "Calculate";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultRichTextBox.Location = new System.Drawing.Point(-1, 164);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.ReadOnly = true;
            this.resultRichTextBox.Size = new System.Drawing.Size(426, 60);
            this.resultRichTextBox.TabIndex = 9;
            this.resultRichTextBox.Text = "";
            // 
            // saveStateButton
            // 
            this.saveStateButton.Location = new System.Drawing.Point(248, 97);
            this.saveStateButton.Name = "saveStateButton";
            this.saveStateButton.Size = new System.Drawing.Size(91, 25);
            this.saveStateButton.TabIndex = 10;
            this.saveStateButton.Text = "Saving Status";
            this.saveStateButton.UseVisualStyleBackColor = true;
            this.saveStateButton.Click += new System.EventHandler(this.SaveStateButton_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 225);
            this.Controls.Add(this.saveStateButton);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.aLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Control";
            this.Text = "Quadratic Equation Solving Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Control_FormClosing);
            this.Load += new System.EventHandler(this.Control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox aTextBox;
		private System.Windows.Forms.Label aLabel;
		private System.Windows.Forms.TextBox bTextBox;
		private System.Windows.Forms.Label bLabel;
		private System.Windows.Forms.TextBox cTextBox;
		private System.Windows.Forms.Label cLabel;
		private System.Windows.Forms.Button calculationButton;
		private System.Windows.Forms.RichTextBox resultRichTextBox;
		private System.Windows.Forms.Button saveStateButton;
	}
}

