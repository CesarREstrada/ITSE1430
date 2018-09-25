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
            this._txtNameLabel.Location = new System.Drawing.Point(28, 39);
            this._txtNameLabel.Name = "_txtNameLabel";
            this._txtNameLabel.Size = new System.Drawing.Size(35, 13);
            this._txtNameLabel.TabIndex = 0;
            this._txtNameLabel.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(104, 36);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(189, 20);
            this._txtName.TabIndex = 1;
            // 
            // _txtDescriptionLabel
            // 
            this._txtDescriptionLabel.AutoSize = true;
            this._txtDescriptionLabel.Location = new System.Drawing.Point(28, 72);
            this._txtDescriptionLabel.Name = "_txtDescriptionLabel";
            this._txtDescriptionLabel.Size = new System.Drawing.Size(56, 13);
            this._txtDescriptionLabel.TabIndex = 2;
            this._txtDescriptionLabel.Text = "Discription";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(104, 69);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(169, 68);
            this._txtDescription.TabIndex = 3;
            // 
            // _txtReleaseLabel
            // 
            this._txtReleaseLabel.AutoSize = true;
            this._txtReleaseLabel.Location = new System.Drawing.Point(27, 162);
            this._txtReleaseLabel.Name = "_txtReleaseLabel";
            this._txtReleaseLabel.Size = new System.Drawing.Size(71, 13);
            this._txtReleaseLabel.TabIndex = 4;
            this._txtReleaseLabel.Text = "Release Year";
            // 
            // _txtReleaseYear
            // 
            this._txtReleaseYear.Location = new System.Drawing.Point(104, 155);
            this._txtReleaseYear.Name = "_txtReleaseYear";
            this._txtReleaseYear.Size = new System.Drawing.Size(69, 20);
            this._txtReleaseYear.TabIndex = 5;
            // 
            // __txtRunlabel
            // 
            this.@__txtRunlabel.AutoSize = true;
            this.@__txtRunlabel.Location = new System.Drawing.Point(28, 190);
            this.@__txtRunlabel.Name = "__txtRunlabel";
            this.@__txtRunlabel.Size = new System.Drawing.Size(63, 13);
            this.@__txtRunlabel.TabIndex = 6;
            this.@__txtRunlabel.Text = "Run Lenght";
            // 
            // _txtRunLenght
            // 
            this._txtRunLenght.Location = new System.Drawing.Point(104, 187);
            this._txtRunLenght.Name = "_txtRunLenght";
            this._txtRunLenght.Size = new System.Drawing.Size(69, 20);
            this._txtRunLenght.TabIndex = 7;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(126, 220);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 8;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.onSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(207, 220);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.onCancel);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 287);
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
            this.Name = "MovieForm";
            this.ShowInTaskbar = false;
            this.Text = "Movie Details";
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