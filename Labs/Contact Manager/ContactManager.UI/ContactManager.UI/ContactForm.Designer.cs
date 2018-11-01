namespace ContactManager.UI
{
	partial class ContactForm
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
			this._txtName = new System.Windows.Forms.TextBox();
			this._txtEmailAddress = new System.Windows.Forms.TextBox();
			this.OnSave = new System.Windows.Forms.Button();
			this.OnCancel = new System.Windows.Forms.Button();
			this._errors = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contact Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email Address";
			// 
			// _txtName
			// 
			this._txtName.Location = new System.Drawing.Point(177, 23);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(310, 22);
			this._txtName.TabIndex = 2;
			this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
			// 
			// _txtEmailAddress
			// 
			this._txtEmailAddress.Location = new System.Drawing.Point(177, 67);
			this._txtEmailAddress.Name = "_txtEmailAddress";
			this._txtEmailAddress.Size = new System.Drawing.Size(310, 22);
			this._txtEmailAddress.TabIndex = 3;
			this._txtEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingEmail);
			// 
			// OnSave
			// 
			this.OnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OnSave.Location = new System.Drawing.Point(250, 110);
			this.OnSave.Name = "OnSave";
			this.OnSave.Size = new System.Drawing.Size(100, 32);
			this.OnSave.TabIndex = 4;
			this.OnSave.Text = "Save";
			this.OnSave.UseVisualStyleBackColor = true;
			this.OnSave.Click += new System.EventHandler(this.OnSave_Click);
			// 
			// OnCancel
			// 
			this.OnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OnCancel.Location = new System.Drawing.Point(386, 110);
			this.OnCancel.Name = "OnCancel";
			this.OnCancel.Size = new System.Drawing.Size(100, 32);
			this.OnCancel.TabIndex = 5;
			this.OnCancel.Text = "Cancel";
			this.OnCancel.UseVisualStyleBackColor = true;
			this.OnCancel.Click += new System.EventHandler(this.OnCancel_Click);
			// 
			// _errors
			// 
			this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this._errors.ContainerControl = this;
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(532, 164);
			this.ControlBox = false;
			this.Controls.Add(this.OnCancel);
			this.Controls.Add(this.OnSave);
			this.Controls.Add(this._txtEmailAddress);
			this.Controls.Add(this._txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ContactForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Contact";
			((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txtName;
		private System.Windows.Forms.TextBox _txtEmailAddress;
		private System.Windows.Forms.Button OnSave;
		private System.Windows.Forms.Button OnCancel;
		private System.Windows.Forms.ErrorProvider _errors;
	}
}