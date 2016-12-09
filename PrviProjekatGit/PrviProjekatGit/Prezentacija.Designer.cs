namespace PrviProjekatGit
{
    partial class Prezentacija
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.listBoxFilmovi = new System.Windows.Forms.ListBox();
            this.listBoxProjekcije = new System.Windows.Forms.ListBox();
            this.buttonFilmDetalji = new System.Windows.Forms.Button();
            this.buttonProjDetalji = new System.Windows.Forms.Button();
            this.labelFilmovi = new System.Windows.Forms.Label();
            this.labelProjekcije = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(793, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // listBoxFilmovi
            // 
            this.listBoxFilmovi.FormattingEnabled = true;
            this.listBoxFilmovi.Location = new System.Drawing.Point(12, 59);
            this.listBoxFilmovi.Name = "listBoxFilmovi";
            this.listBoxFilmovi.Size = new System.Drawing.Size(340, 342);
            this.listBoxFilmovi.TabIndex = 1;
            this.listBoxFilmovi.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmovi_SelectedIndexChanged);
            // 
            // listBoxProjekcije
            // 
            this.listBoxProjekcije.FormattingEnabled = true;
            this.listBoxProjekcije.Location = new System.Drawing.Point(477, 59);
            this.listBoxProjekcije.Name = "listBoxProjekcije";
            this.listBoxProjekcije.Size = new System.Drawing.Size(351, 342);
            this.listBoxProjekcije.TabIndex = 2;
            this.listBoxProjekcije.SelectedIndexChanged += new System.EventHandler(this.listBoxProjekcije_SelectedIndexChanged);
            // 
            // buttonFilmDetalji
            // 
            this.buttonFilmDetalji.Location = new System.Drawing.Point(116, 407);
            this.buttonFilmDetalji.Name = "buttonFilmDetalji";
            this.buttonFilmDetalji.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmDetalji.TabIndex = 3;
            this.buttonFilmDetalji.Text = "Detalji";
            this.buttonFilmDetalji.UseVisualStyleBackColor = true;
            this.buttonFilmDetalji.Click += new System.EventHandler(this.buttonFilmDetalji_Click);
            // 
            // buttonProjDetalji
            // 
            this.buttonProjDetalji.Location = new System.Drawing.Point(619, 407);
            this.buttonProjDetalji.Name = "buttonProjDetalji";
            this.buttonProjDetalji.Size = new System.Drawing.Size(75, 23);
            this.buttonProjDetalji.TabIndex = 4;
            this.buttonProjDetalji.Text = "Detalji";
            this.buttonProjDetalji.UseVisualStyleBackColor = true;
            this.buttonProjDetalji.Click += new System.EventHandler(this.buttonProjDetalji_Click);
            // 
            // labelFilmovi
            // 
            this.labelFilmovi.AutoSize = true;
            this.labelFilmovi.Location = new System.Drawing.Point(138, 43);
            this.labelFilmovi.Name = "labelFilmovi";
            this.labelFilmovi.Size = new System.Drawing.Size(55, 13);
            this.labelFilmovi.TabIndex = 5;
            this.labelFilmovi.Text = "svi filmovi:";
            // 
            // labelProjekcije
            // 
            this.labelProjekcije.AutoSize = true;
            this.labelProjekcije.Location = new System.Drawing.Point(607, 43);
            this.labelProjekcije.Name = "labelProjekcije";
            this.labelProjekcije.Size = new System.Drawing.Size(87, 13);
            this.labelProjekcije.TabIndex = 6;
            this.labelProjekcije.Text = "projekcije za film:";
            // 
            // Prezentacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 452);
            this.Controls.Add(this.labelProjekcije);
            this.Controls.Add(this.labelFilmovi);
            this.Controls.Add(this.buttonProjDetalji);
            this.Controls.Add(this.buttonFilmDetalji);
            this.Controls.Add(this.listBoxProjekcije);
            this.Controls.Add(this.listBoxFilmovi);
            this.Controls.Add(this.labelUsername);
            this.Name = "Prezentacija";
            this.Text = "Prezentacija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prezentacija_FormClosed);
            this.Load += new System.EventHandler(this.Prezentacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ListBox listBoxFilmovi;
        private System.Windows.Forms.ListBox listBoxProjekcije;
        private System.Windows.Forms.Button buttonFilmDetalji;
        private System.Windows.Forms.Button buttonProjDetalji;
        private System.Windows.Forms.Label labelFilmovi;
        private System.Windows.Forms.Label labelProjekcije;
    }
}