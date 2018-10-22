namespace CharacterCreator.Winforms
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
			this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnCharacterNew = new System.Windows.Forms.ToolStripMenuItem();
			this.OnEditCharacter = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this._listCharacters = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.characterToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(282, 28);
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
			this.OnFileExit.Text = "E&xit";
			this.OnFileExit.Click += new System.EventHandler(this.OnExit);
			// 
			// characterToolStripMenuItem
			// 
			this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnCharacterNew,
            this.OnEditCharacter,
            this.deleteToolStripMenuItem});
			this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
			this.characterToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
			this.characterToolStripMenuItem.Text = "Character";
			// 
			// OnCharacterNew
			// 
			this.OnCharacterNew.Name = "OnCharacterNew";
			this.OnCharacterNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.OnCharacterNew.Size = new System.Drawing.Size(167, 26);
			this.OnCharacterNew.Text = "New";
			this.OnCharacterNew.Click += new System.EventHandler(this.OnNew);
			// 
			// OnEditCharacter
			// 
			this.OnEditCharacter.Name = "OnEditCharacter";
			this.OnEditCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OnEditCharacter.Size = new System.Drawing.Size(216, 26);
			this.OnEditCharacter.Text = "Edit";
			this.OnEditCharacter.Click += new System.EventHandler(this.OnEdit);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.OnDelete);
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
			this.OnHelpAbout.Text = "&About";
			this.OnHelpAbout.Click += new System.EventHandler(this.OnAbout);
			// 
			// _listCharacters
			// 
			this._listCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
			this._listCharacters.FormattingEnabled = true;
			this._listCharacters.ItemHeight = 16;
			this._listCharacters.Location = new System.Drawing.Point(0, 28);
			this._listCharacters.Name = "_listCharacters";
			this._listCharacters.Size = new System.Drawing.Size(282, 375);
			this._listCharacters.TabIndex = 1;
			this._listCharacters.DoubleClick += new System.EventHandler(this.OnDoubleClick);
			this._listCharacters.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnListKeyUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(282, 403);
			this.Controls.Add(this._listCharacters);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(260, 420);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Charactor Creator";
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
		private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OnCharacterNew;
		private System.Windows.Forms.ToolStripMenuItem OnEditCharacter;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ListBox _listCharacters;
	}
}

