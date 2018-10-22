namespace CharacterCreator.Winforms
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._txtName = new System.Windows.Forms.TextBox();
			this._cbxProfession = new System.Windows.Forms.ComboBox();
			this._cbxRace = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this._txtStrength = new System.Windows.Forms.TextBox();
			this._txtIntelligence = new System.Windows.Forms.TextBox();
			this._txtAgility = new System.Windows.Forms.TextBox();
			this._txtConstitution = new System.Windows.Forms.TextBox();
			this._txtCharisma = new System.Windows.Forms.TextBox();
			this._txtDescription = new System.Windows.Forms.TextBox();
			this._btnSave = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this._errors = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Profession:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Race:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(29, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Attributes:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(29, 317);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description:";
			// 
			// _txtName
			// 
			this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtName.Location = new System.Drawing.Point(150, 29);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(188, 22);
			this._txtName.TabIndex = 5;
			this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
			// 
			// _cbxProfession
			// 
			this._cbxProfession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._cbxProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbxProfession.FormattingEnabled = true;
			this._cbxProfession.Location = new System.Drawing.Point(150, 64);
			this._cbxProfession.Name = "_cbxProfession";
			this._cbxProfession.Size = new System.Drawing.Size(188, 24);
			this._cbxProfession.TabIndex = 6;
			// 
			// _cbxRace
			// 
			this._cbxRace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._cbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbxRace.FormattingEnabled = true;
			this._cbxRace.Location = new System.Drawing.Point(150, 101);
			this._cbxRace.Name = "_cbxRace";
			this._cbxRace.Size = new System.Drawing.Size(188, 24);
			this._cbxRace.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(150, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Stength";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(150, 180);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 20);
			this.label7.TabIndex = 9;
			this.label7.Text = "Intelligence";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(150, 210);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 20);
			this.label8.TabIndex = 10;
			this.label8.Text = "Agility";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(150, 240);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 20);
			this.label9.TabIndex = 11;
			this.label9.Text = "Constitution";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(150, 270);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 20);
			this.label10.TabIndex = 12;
			this.label10.Text = "Charisma";
			// 
			// _txtStrength
			// 
			this._txtStrength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtStrength.Location = new System.Drawing.Point(263, 150);
			this._txtStrength.Name = "_txtStrength";
			this._txtStrength.Size = new System.Drawing.Size(75, 22);
			this._txtStrength.TabIndex = 13;
			this._txtStrength.Text = "50";
			this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStrength);
			// 
			// _txtIntelligence
			// 
			this._txtIntelligence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtIntelligence.Location = new System.Drawing.Point(263, 180);
			this._txtIntelligence.Name = "_txtIntelligence";
			this._txtIntelligence.Size = new System.Drawing.Size(75, 22);
			this._txtIntelligence.TabIndex = 14;
			this._txtIntelligence.Text = "50";
			this._txtIntelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingIntelligence);
			// 
			// _txtAgility
			// 
			this._txtAgility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtAgility.Location = new System.Drawing.Point(263, 210);
			this._txtAgility.Name = "_txtAgility";
			this._txtAgility.Size = new System.Drawing.Size(75, 22);
			this._txtAgility.TabIndex = 15;
			this._txtAgility.Text = "50";
			this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingAgility);
			// 
			// _txtConstitution
			// 
			this._txtConstitution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtConstitution.Location = new System.Drawing.Point(263, 240);
			this._txtConstitution.Name = "_txtConstitution";
			this._txtConstitution.Size = new System.Drawing.Size(75, 22);
			this._txtConstitution.TabIndex = 16;
			this._txtConstitution.Text = "50";
			this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingConstitution);
			// 
			// _txtCharisma
			// 
			this._txtCharisma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtCharisma.Location = new System.Drawing.Point(263, 270);
			this._txtCharisma.Name = "_txtCharisma";
			this._txtCharisma.Size = new System.Drawing.Size(75, 22);
			this._txtCharisma.TabIndex = 17;
			this._txtCharisma.Text = "50";
			this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingCharisma);
			// 
			// _txtDescription
			// 
			this._txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtDescription.Location = new System.Drawing.Point(154, 317);
			this._txtDescription.Multiline = true;
			this._txtDescription.Name = "_txtDescription";
			this._txtDescription.Size = new System.Drawing.Size(184, 106);
			this._txtDescription.TabIndex = 18;
			// 
			// _btnSave
			// 
			this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btnSave.Location = new System.Drawing.Point(104, 446);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(99, 34);
			this._btnSave.TabIndex = 19;
			this._btnSave.Text = "Save";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this.OnSave);
			// 
			// _btnCancel
			// 
			this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btnCancel.Location = new System.Drawing.Point(239, 446);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(99, 34);
			this._btnCancel.TabIndex = 20;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// _errors
			// 
			this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this._errors.ContainerControl = this;
			// 
			// CharacterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(382, 503);
			this.ControlBox = false;
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._txtDescription);
			this.Controls.Add(this._txtCharisma);
			this.Controls.Add(this._txtConstitution);
			this.Controls.Add(this._txtAgility);
			this.Controls.Add(this._txtIntelligence);
			this.Controls.Add(this._txtStrength);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._cbxRace);
			this.Controls.Add(this._cbxProfession);
			this.Controls.Add(this._txtName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(400, 550);
			this.Name = "CharacterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Create New Character";
			this.Load += new System.EventHandler(this.CharactorForm_Load);
			((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox _txtStrength;
		private System.Windows.Forms.TextBox _txtIntelligence;
		private System.Windows.Forms.TextBox _txtAgility;
		private System.Windows.Forms.TextBox _txtConstitution;
		private System.Windows.Forms.TextBox _txtCharisma;
		private System.Windows.Forms.TextBox _txtDescription;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.ErrorProvider _errors;
	}
}