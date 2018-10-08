namespace Lab_2_CreaterCreator
{
	partial class CharacterForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._txtName = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this._txtDescription = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Profession:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Attributes:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Race:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description:";
			// 
			// _txtName
			// 
			this._txtName.Location = new System.Drawing.Point(136, 21);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(181, 22);
			this._txtName.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.AllowDrop = true;
			this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
			this.comboBox1.Location = new System.Drawing.Point(136, 53);
			this.comboBox1.MaxDropDownItems = 5;
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(181, 24);
			this.comboBox1.TabIndex = 6;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
			this.comboBox2.Location = new System.Drawing.Point(136, 89);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(181, 24);
			this.comboBox2.TabIndex = 7;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "Strength",
            "Intelligence",
            "Agility",
            "Constitution",
            "Charisma"});
			this.comboBox3.Location = new System.Drawing.Point(136, 125);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(181, 24);
			this.comboBox3.TabIndex = 8;
			// 
			// _txtDescription
			// 
			this._txtDescription.Location = new System.Drawing.Point(136, 164);
			this._txtDescription.Multiline = true;
			this._txtDescription.Name = "_txtDescription";
			this._txtDescription.Size = new System.Drawing.Size(181, 105);
			this._txtDescription.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(54, 286);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 35);
			this.button1.TabIndex = 10;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// _btnCancel
			// 
			this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btnCancel.Location = new System.Drawing.Point(196, 286);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(99, 35);
			this._btnCancel.TabIndex = 11;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// CharacterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 344);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this._txtDescription);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this._txtName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CharacterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CharactorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _txtName;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.TextBox _txtDescription;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button _btnCancel;
	}
}