namespace MDIApplicationDemo
{
    partial class MDI
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
            this.toolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoViewerTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeActiveTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarMenuStrip
            // 
            this.toolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolbarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.toolbarMenuStrip.Name = "toolbarMenuStrip";
            this.toolbarMenuStrip.Size = new System.Drawing.Size(829, 24);
            this.toolbarMenuStrip.TabIndex = 1;
            this.toolbarMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSMenuItem,
            this.openTSMenuItem,
            this.closeActiveTSMenuItem,
            this.closeAllTSMenuItem,
            this.exitTSMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTSMenuItem
            // 
            this.newTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadTSMenuItem,
            this.photoViewerTSMenuItem});
            this.newTSMenuItem.Name = "newTSMenuItem";
            this.newTSMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newTSMenuItem.Text = "New";
            // 
            // notepadTSMenuItem
            // 
            this.notepadTSMenuItem.Name = "notepadTSMenuItem";
            this.notepadTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notepadTSMenuItem.Tag = "Notepad";
            this.notepadTSMenuItem.Text = "Notepad";
            this.notepadTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // photoViewerTSMenuItem
            // 
            this.photoViewerTSMenuItem.Name = "photoViewerTSMenuItem";
            this.photoViewerTSMenuItem.Size = new System.Drawing.Size(180, 22);
            this.photoViewerTSMenuItem.Tag = "PhotoViewer";
            this.photoViewerTSMenuItem.Text = "Photo Viewer";
            this.photoViewerTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // openTSMenuItem
            // 
            this.openTSMenuItem.Name = "openTSMenuItem";
            this.openTSMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openTSMenuItem.Text = "Open";
            this.openTSMenuItem.Tag = "Open";
            this.openTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // closeCurrentTSMenuItem
            // 
            this.closeActiveTSMenuItem.Enabled = false;
            this.closeActiveTSMenuItem.Name = "closeCurrentTSMenuItem";
            this.closeActiveTSMenuItem.Size = new System.Drawing.Size(193, 22);
            this.closeActiveTSMenuItem.Tag = "CloseActiveChild";
            this.closeActiveTSMenuItem.Text = "Close Active Window";
            this.closeActiveTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // closeAllTSMenuItem
            // 
            this.closeAllTSMenuItem.Enabled = false;
            this.closeAllTSMenuItem.Name = "closeAllTSMenuItem";
            this.closeAllTSMenuItem.Size = new System.Drawing.Size(193, 22);
            this.closeAllTSMenuItem.Tag = "CloseAllChild";
            this.closeAllTSMenuItem.Text = "Close All Window";
            this.closeAllTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // exitTSMenuItem
            // 
            this.exitTSMenuItem.Name = "exitTSMenuItem";
            this.exitTSMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitTSMenuItem.Tag = "Exit";
            this.exitTSMenuItem.Text = "Exit";
            this.exitTSMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 451);
            this.Controls.Add(this.toolbarMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.toolbarMenuStrip;
            this.Name = "MDI";
            this.Text = "MDI Application Demo";
            this.toolbarMenuStrip.ResumeLayout(false);
            this.toolbarMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip toolbarMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeActiveTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeAllTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem notepadTSMenuItem;
		private System.Windows.Forms.ToolStripMenuItem photoViewerTSMenuItem;
	}
}

