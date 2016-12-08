namespace PrviProjekatGit
{
    partial class NoviFilmForma
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
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxZanr = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelZanr = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCncl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(92, 38);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(431, 20);
            this.textBoxNaziv.TabIndex = 1;
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // textBoxZanr
            // 
            this.textBoxZanr.Location = new System.Drawing.Point(92, 91);
            this.textBoxZanr.Name = "textBoxZanr";
            this.textBoxZanr.Size = new System.Drawing.Size(431, 20);
            this.textBoxZanr.TabIndex = 2;
            this.textBoxZanr.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(92, 148);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(431, 140);
            this.textBoxOpis.TabIndex = 3;
            this.textBoxOpis.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(51, 41);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 4;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(58, 151);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(28, 13);
            this.labelOpis.TabIndex = 5;
            this.labelOpis.Text = "Opis";
            // 
            // labelZanr
            // 
            this.labelZanr.AutoSize = true;
            this.labelZanr.Location = new System.Drawing.Point(56, 94);
            this.labelZanr.Name = "labelZanr";
            this.labelZanr.Size = new System.Drawing.Size(29, 13);
            this.labelZanr.TabIndex = 6;
            this.labelZanr.Text = "Zanr";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(358, 294);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCncl
            // 
            this.buttonCncl.Location = new System.Drawing.Point(448, 294);
            this.buttonCncl.Name = "buttonCncl";
            this.buttonCncl.Size = new System.Drawing.Size(75, 23);
            this.buttonCncl.TabIndex = 8;
            this.buttonCncl.Text = "Cancel";
            this.buttonCncl.UseVisualStyleBackColor = true;
            this.buttonCncl.Click += new System.EventHandler(this.buttonCncl_Click);
            // 
            // NoviFilmForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 418);
            this.Controls.Add(this.buttonCncl);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelZanr);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxZanr);
            this.Controls.Add(this.textBoxNaziv);
            this.MaximizeBox = false;
            this.Name = "NoviFilmForma";
            this.Text = "Dodavanje novog filma";
            this.Load += new System.EventHandler(this.NoviFilmForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxZanr;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelZanr;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCncl;
    }
}