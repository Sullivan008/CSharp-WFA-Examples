namespace MDIApplicationDemo
{
	partial class Notepad
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
			this.notepadRichTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// notepadRichTextBox
			// 
			this.notepadRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notepadRichTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.notepadRichTextBox.Location = new System.Drawing.Point(0, 0);
			this.notepadRichTextBox.Name = "notepadRichTextBox";
			this.notepadRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.notepadRichTextBox.Size = new System.Drawing.Size(386, 340);
			this.notepadRichTextBox.TabIndex = 0;
			this.notepadRichTextBox.Text = "";
			this.notepadRichTextBox.WordWrap = false;
			// 
			// Notepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 340);
			this.Controls.Add(this.notepadRichTextBox);
			this.Name = "Notepad";
			this.Text = "Notepad";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox notepadRichTextBox;
	}
}