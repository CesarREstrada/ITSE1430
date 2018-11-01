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
			this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactNew = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._listContacts = new System.Windows.Forms.ListBox();
			this._emailSent = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(456, 28);
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
			this.OnFileExit.Size = new System.Drawing.Size(161, 26);
			this.OnFileExit.Text = "Exit";
			this.OnFileExit.Click += new System.EventHandler(this.OnFileExit_Click);
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
			this.OnContactNew.ShortcutKeys = System.Windows.Forms.Keys.Insert;
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
			this.OnHelpAbout.Size = new System.Drawing.Size(149, 26);
			this.OnHelpAbout.Text = "About";
			this.OnHelpAbout.Click += new System.EventHandler(this.OnHelpAbout_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._listContacts);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this._emailSent);
			this.splitContainer1.Size = new System.Drawing.Size(456, 325);
			this.splitContainer1.SplitterDistance = 152;
			this.splitContainer1.TabIndex = 1;
			// 
			// _listContacts
			// 
			this._listContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this._listContacts.FormattingEnabled = true;
			this._listContacts.ItemHeight = 16;
			this._listContacts.Location = new System.Drawing.Point(0, 0);
			this._listContacts.Name = "_listContacts";
			this._listContacts.Size = new System.Drawing.Size(152, 325);
			this._listContacts.TabIndex = 0;
			this._listContacts.DoubleClick += new System.EventHandler(this.OnContactDoubleClick);
			this._listContacts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnListKeyUp);
			// 
			// _emailSent
			// 
			this._emailSent.Dock = System.Windows.Forms.DockStyle.Fill;
			this._emailSent.FormattingEnabled = true;
			this._emailSent.ItemHeight = 16;
			this._emailSent.Location = new System.Drawing.Point(0, 0);
			this._emailSent.Name = "_emailSent";
			this._emailSent.Size = new System.Drawing.Size(300, 325);
			this._emailSent.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(456, 353);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contact Manager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
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
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox _listContacts;
		private System.Windows.Forms.ListBox _emailSent;
	}
}

