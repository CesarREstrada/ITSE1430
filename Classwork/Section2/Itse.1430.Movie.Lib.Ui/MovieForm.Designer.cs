namespace Itse._1430.MovieLib.Ui
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
			this._txtNameLabel = new System.Windows.Forms.Label();
			this._txtName = new System.Windows.Forms.TextBox();
			this._txtDescriptionLabel = new System.Windows.Forms.Label();
			this._txtDescription = new System.Windows.Forms.TextBox();
			this._txtReleaseLabel = new System.Windows.Forms.Label();
			this._txtReleaseYear = new System.Windows.Forms.TextBox();
			this.@__txtRunlabel = new System.Windows.Forms.Label();
			this._txtRunLenght = new System.Windows.Forms.TextBox();
			this._btnSave = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _txtNameLabel
			// 
			this._txtNameLabel.AutoSize = true;
			this._txtNameLabel.Location = new System.Drawing.Point(37, 48);
			this._txtNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this._txtNameLabel.Name = "_txtNameLabel";
			this._txtNameLabel.Size = new System.Drawing.Size(45, 17);
			this._txtNameLabel.TabIndex = 0;
			this._txtNameLabel.Text = "Name";
			// 
			// _txtName
			// 
			this._txtName.Location = new System.Drawing.Point(139, 44);
			this._txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(251, 22);
			this._txtName.TabIndex = 1;
			// 
			// _txtDescriptionLabel
			// 
			this._txtDescriptionLabel.AutoSize = true;
			this._txtDescriptionLabel.Location = new System.Drawing.Point(37, 89);
			this._txtDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this._txtDescriptionLabel.Name = "_txtDescriptionLabel";
			this._txtDescriptionLabel.Size = new System.Drawing.Size(74, 17);
			this._txtDescriptionLabel.TabIndex = 2;
			this._txtDescriptionLabel.Text = "Discription";
			// 
			// _txtDescription
			// 
			this._txtDescription.Location = new System.Drawing.Point(139, 85);
			this._txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._txtDescription.Multiline = true;
			this._txtDescription.Name = "_txtDescription";
			this._txtDescription.Size = new System.Drawing.Size(224, 83);
			this._txtDescription.TabIndex = 3;
			// 
			// _txtReleaseLabel
			// 
			this._txtReleaseLabel.AutoSize = true;
			this._txtReleaseLabel.Location = new System.Drawing.Point(36, 199);
			this._txtReleaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this._txtReleaseLabel.Name = "_txtReleaseLabel";
			this._txtReleaseLabel.Size = new System.Drawing.Size(94, 17);
			this._txtReleaseLabel.TabIndex = 4;
			this._txtReleaseLabel.Text = "Release Year";
			// 
			// _txtReleaseYear
			// 
			this._txtReleaseYear.Location = new System.Drawing.Point(139, 191);
			this._txtReleaseYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._txtReleaseYear.Name = "_txtReleaseYear";
			this._txtReleaseYear.Size = new System.Drawing.Size(91, 22);
			this._txtReleaseYear.TabIndex = 5;
			// 
			// __txtRunlabel
			// 
			this.@__txtRunlabel.AutoSize = true;
			this.@__txtRunlabel.Location = new System.Drawing.Point(37, 234);
			this.@__txtRunlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.@__txtRunlabel.Name = "__txtRunlabel";
			this.@__txtRunlabel.Size = new System.Drawing.Size(82, 17);
			this.@__txtRunlabel.TabIndex = 6;
			this.@__txtRunlabel.Text = "Run Lenght";
			// 
			// _txtRunLenght
			// 
			this._txtRunLenght.Location = new System.Drawing.Point(139, 230);
			this._txtRunLenght.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._txtRunLenght.Name = "_txtRunLenght";
			this._txtRunLenght.Size = new System.Drawing.Size(91, 22);
			this._txtRunLenght.TabIndex = 7;
			// 
			// _btnSave
			// 
			this._btnSave.Location = new System.Drawing.Point(168, 271);
			this._btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(100, 28);
			this._btnSave.TabIndex = 8;
			this._btnSave.Text = "Save";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this.onSave);
			// 
			// _btnCancel
			// 
			this._btnCancel.Location = new System.Drawing.Point(276, 271);
			this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(100, 28);
			this._btnCancel.TabIndex = 9;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.onCancel);
			// 
			// MovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 353);
			this.ControlBox = false;
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._txtRunLenght);
			this.Controls.Add(this.@__txtRunlabel);
			this.Controls.Add(this._txtReleaseYear);
			this.Controls.Add(this._txtReleaseLabel);
			this.Controls.Add(this._txtDescription);
			this.Controls.Add(this._txtDescriptionLabel);
			this.Controls.Add(this._txtName);
			this.Controls.Add(this._txtNameLabel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MovieForm";
			this.ShowInTaskbar = false;
			this.Text = "Movie Details";
			this.Load += new System.EventHandler(this.MovieForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _txtNameLabel;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label _txtDescriptionLabel;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Label _txtReleaseLabel;
        private System.Windows.Forms.TextBox _txtReleaseYear;
        private System.Windows.Forms.Label __txtRunlabel;
        private System.Windows.Forms.TextBox _txtRunLenght;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
    }
}