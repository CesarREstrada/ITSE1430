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
			this._cbxProfession = new System.Windows.Forms.ComboBox();
			this._cbxRace = new System.Windows.Forms.ComboBox();
			this._txtDescription = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this._txtAttrStrenght = new System.Windows.Forms.TextBox();
			this._txtAttrIntelligence = new System.Windows.Forms.TextBox();
			this._txtAttrAgility = new System.Windows.Forms.TextBox();
			this._txtAttrConstitution = new System.Windows.Forms.TextBox();
			this._txtAttrCharisma = new System.Windows.Forms.TextBox();
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
			this.label5.Location = new System.Drawing.Point(21, 287);
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
			// _cbxProfession
			// 
			this._cbxProfession.AllowDrop = true;
			this._cbxProfession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this._cbxProfession.FormattingEnabled = true;
			this._cbxProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
			this._cbxProfession.Location = new System.Drawing.Point(136, 53);
			this._cbxProfession.MaxDropDownItems = 5;
			this._cbxProfession.Name = "_cbxProfession";
			this._cbxProfession.Size = new System.Drawing.Size(181, 24);
			this._cbxProfession.TabIndex = 6;
			// 
			// _cbxRace
			// 
			this._cbxRace.FormattingEnabled = true;
			this._cbxRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
			this._cbxRace.Location = new System.Drawing.Point(136, 89);
			this._cbxRace.Name = "_cbxRace";
			this._cbxRace.Size = new System.Drawing.Size(181, 24);
			this._cbxRace.TabIndex = 7;
			// 
			// _txtDescription
			// 
			this._txtDescription.Location = new System.Drawing.Point(136, 287);
			this._txtDescription.Multiline = true;
			this._txtDescription.Name = "_txtDescription";
			this._txtDescription.Size = new System.Drawing.Size(181, 105);
			this._txtDescription.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(128, 412);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 35);
			this.button1.TabIndex = 10;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// _btnCancel
			// 
			this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btnCancel.Location = new System.Drawing.Point(247, 412);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(99, 35);
			this._btnCancel.TabIndex = 11;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(136, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Strenght:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(136, 161);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "Intelligence:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(136, 188);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Agility:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(136, 215);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 17);
			this.label9.TabIndex = 15;
			this.label9.Text = "Constitution";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(136, 242);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 17);
			this.label10.TabIndex = 16;
			this.label10.Text = "Charisma";
			// 
			// _txtAttrStrenght
			// 
			this._txtAttrStrenght.Location = new System.Drawing.Point(247, 134);
			this._txtAttrStrenght.Name = "_txtAttrStrenght";
			this._txtAttrStrenght.Size = new System.Drawing.Size(70, 22);
			this._txtAttrStrenght.TabIndex = 17;
			// 
			// _txtAttrIntelligence
			// 
			this._txtAttrIntelligence.Location = new System.Drawing.Point(247, 161);
			this._txtAttrIntelligence.Name = "_txtAttrIntelligence";
			this._txtAttrIntelligence.Size = new System.Drawing.Size(70, 22);
			this._txtAttrIntelligence.TabIndex = 18;
			// 
			// _txtAttrAgility
			// 
			this._txtAttrAgility.Location = new System.Drawing.Point(247, 188);
			this._txtAttrAgility.Name = "_txtAttrAgility";
			this._txtAttrAgility.Size = new System.Drawing.Size(70, 22);
			this._txtAttrAgility.TabIndex = 19;
			// 
			// _txtAttrConstitution
			// 
			this._txtAttrConstitution.Location = new System.Drawing.Point(247, 215);
			this._txtAttrConstitution.Name = "_txtAttrConstitution";
			this._txtAttrConstitution.Size = new System.Drawing.Size(70, 22);
			this._txtAttrConstitution.TabIndex = 20;
			// 
			// _txtAttrCharisma
			// 
			this._txtAttrCharisma.Location = new System.Drawing.Point(247, 242);
			this._txtAttrCharisma.Name = "_txtAttrCharisma";
			this._txtAttrCharisma.Size = new System.Drawing.Size(70, 22);
			this._txtAttrCharisma.TabIndex = 21;
			// 
			// CharacterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 467);
			this.Controls.Add(this._txtAttrCharisma);
			this.Controls.Add(this._txtAttrConstitution);
			this.Controls.Add(this._txtAttrAgility);
			this.Controls.Add(this._txtAttrIntelligence);
			this.Controls.Add(this._txtAttrStrenght);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this._txtDescription);
			this.Controls.Add(this._cbxRace);
			this.Controls.Add(this._cbxProfession);
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
		private System.Windows.Forms.ComboBox _cbxProfession;
		private System.Windows.Forms.ComboBox _cbxRace;
		private System.Windows.Forms.TextBox _txtDescription;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox _txtAttrStrenght;
		private System.Windows.Forms.TextBox _txtAttrIntelligence;
		private System.Windows.Forms.TextBox _txtAttrAgility;
		private System.Windows.Forms.TextBox _txtAttrConstitution;
		private System.Windows.Forms.TextBox _txtAttrCharisma;
	}
}