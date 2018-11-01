namespace ContactManager.UI
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactNew = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(493, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnFileExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// OnFileExit
			// 
			this.OnFileExit.Name = "OnFileExit";
			this.OnFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.OnFileExit.Size = new System.Drawing.Size(216, 26);
			this.OnFileExit.Text = "Exit";
			this.OnFileExit.Click += new System.EventHandler(this.OnFileExit_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnHelpAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// OnHelpAbout
			// 
			this.OnHelpAbout.Name = "OnHelpAbout";
			this.OnHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.OnHelpAbout.Size = new System.Drawing.Size(216, 26);
			this.OnHelpAbout.Text = "About";
			this.OnHelpAbout.Click += new System.EventHandler(this.OnHelpAbout_Click);
			// 
			// contactToolStripMenuItem
			// 
			this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnContactNew,
            this.OnContactEdit,
            this.OnContactDelete});
			this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
			this.contactToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
			this.contactToolStripMenuItem.Text = "&Contact";
			// 
			// OnContactNew
			// 
			this.OnContactNew.Name = "OnContactNew";
			this.OnContactNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.OnContactNew.Size = new System.Drawing.Size(216, 26);
			this.OnContactNew.Text = "New";
			this.OnContactNew.Click += new System.EventHandler(this.OnContactNew_Click);
			// 
			// OnContactEdit
			// 
			this.OnContactEdit.Name = "OnContactEdit";
			this.OnContactEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OnContactEdit.Size = new System.Drawing.Size(216, 26);
			this.OnContactEdit.Text = "Edit";
			this.OnContactEdit.Click += new System.EventHandler(this.OnContactEdit_Click);
			// 
			// OnContactDelete
			// 
			this.OnContactDelete.Name = "OnContactDelete";
			this.OnContactDelete.Size = new System.Drawing.Size(216, 26);
			this.OnContactDelete.Text = "Delete";
			this.OnContactDelete.Click += new System.EventHandler(this.OnContactDelete_Click);
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(0, 28);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(493, 448);
			this.listBox1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(493, 476);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contact Manager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OnFileExit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OnHelpAbout;
		private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OnContactNew;
		private System.Windows.Forms.ToolStripMenuItem OnContactEdit;
		private System.Windows.Forms.ToolStripMenuItem OnContactDelete;
		private System.Windows.Forms.ListBox listBox1;
	}
}

