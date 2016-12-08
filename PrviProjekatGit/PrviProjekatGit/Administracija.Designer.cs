namespace PrviProjekatGit
{
    partial class Administracija
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Filmovi = new System.Windows.Forms.TabPage();
            this.labelFilmovi = new System.Windows.Forms.Label();
            this.buttonFilmDet = new System.Windows.Forms.Button();
            this.buttonFilmRemove = new System.Windows.Forms.Button();
            this.buttonFilmAdd = new System.Windows.Forms.Button();
            this.listBoxFilmovi = new System.Windows.Forms.ListBox();
            this.Sale = new System.Windows.Forms.TabPage();
            this.Karte = new System.Windows.Forms.TabPage();
            this.Projekcije = new System.Windows.Forms.TabPage();
            this.labelSale = new System.Windows.Forms.Label();
            this.buttonDelSale = new System.Windows.Forms.Button();
            this.buttonAddSale = new System.Windows.Forms.Button();
            this.listBoxSale = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.Filmovi.SuspendLayout();
            this.Sale.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Filmovi);
            this.tabControl.Controls.Add(this.Sale);
            this.tabControl.Controls.Add(this.Karte);
            this.tabControl.Controls.Add(this.Projekcije);
            this.tabControl.Location = new System.Drawing.Point(-1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(752, 414);
            this.tabControl.TabIndex = 0;
            // 
            // Filmovi
            // 
            this.Filmovi.Controls.Add(this.labelFilmovi);
            this.Filmovi.Controls.Add(this.buttonFilmDet);
            this.Filmovi.Controls.Add(this.buttonFilmRemove);
            this.Filmovi.Controls.Add(this.buttonFilmAdd);
            this.Filmovi.Controls.Add(this.listBoxFilmovi);
            this.Filmovi.Location = new System.Drawing.Point(4, 22);
            this.Filmovi.Name = "Filmovi";
            this.Filmovi.Size = new System.Drawing.Size(744, 388);
            this.Filmovi.TabIndex = 0;
            this.Filmovi.Text = "Filmovi";
            this.Filmovi.UseVisualStyleBackColor = true;
            // 
            // labelFilmovi
            // 
            this.labelFilmovi.AutoSize = true;
            this.labelFilmovi.Location = new System.Drawing.Point(4, 4);
            this.labelFilmovi.Name = "labelFilmovi";
            this.labelFilmovi.Size = new System.Drawing.Size(117, 13);
            this.labelFilmovi.TabIndex = 4;
            this.labelFilmovi.Text = "Lista dostupnih filmova:";
            // 
            // buttonFilmDet
            // 
            this.buttonFilmDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilmDet.Location = new System.Drawing.Point(663, 90);
            this.buttonFilmDet.Name = "buttonFilmDet";
            this.buttonFilmDet.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmDet.TabIndex = 3;
            this.buttonFilmDet.Text = "Detalji";
            this.buttonFilmDet.UseVisualStyleBackColor = true;
            this.buttonFilmDet.Click += new System.EventHandler(this.buttonFilmDet_Click);
            // 
            // buttonFilmRemove
            // 
            this.buttonFilmRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilmRemove.Location = new System.Drawing.Point(663, 61);
            this.buttonFilmRemove.Name = "buttonFilmRemove";
            this.buttonFilmRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmRemove.TabIndex = 2;
            this.buttonFilmRemove.Text = "Izbrisi";
            this.buttonFilmRemove.UseVisualStyleBackColor = true;
            this.buttonFilmRemove.Click += new System.EventHandler(this.buttonFilmRemove_Click);
            // 
            // buttonFilmAdd
            // 
            this.buttonFilmAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilmAdd.Location = new System.Drawing.Point(663, 32);
            this.buttonFilmAdd.Name = "buttonFilmAdd";
            this.buttonFilmAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmAdd.TabIndex = 1;
            this.buttonFilmAdd.Text = "Dodaj";
            this.buttonFilmAdd.UseVisualStyleBackColor = true;
            this.buttonFilmAdd.Click += new System.EventHandler(this.buttonFilmAdd_Click);
            // 
            // listBoxFilmovi
            // 
            this.listBoxFilmovi.FormattingEnabled = true;
            this.listBoxFilmovi.Location = new System.Drawing.Point(3, 28);
            this.listBoxFilmovi.Name = "listBoxFilmovi";
            this.listBoxFilmovi.Size = new System.Drawing.Size(471, 329);
            this.listBoxFilmovi.TabIndex = 0;
            this.listBoxFilmovi.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmovi_SelectedIndexChanged);
            // 
            // Sale
            // 
            this.Sale.Controls.Add(this.labelSale);
            this.Sale.Controls.Add(this.buttonDelSale);
            this.Sale.Controls.Add(this.buttonAddSale);
            this.Sale.Controls.Add(this.listBoxSale);
            this.Sale.Location = new System.Drawing.Point(4, 22);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(744, 388);
            this.Sale.TabIndex = 1;
            this.Sale.Text = "Sale";
            this.Sale.UseVisualStyleBackColor = true;
            // 
            // Karte
            // 
            this.Karte.Location = new System.Drawing.Point(4, 22);
            this.Karte.Name = "Karte";
            this.Karte.Size = new System.Drawing.Size(744, 388);
            this.Karte.TabIndex = 2;
            this.Karte.Text = "Karte";
            this.Karte.UseVisualStyleBackColor = true;
            // 
            // Projekcije
            // 
            this.Projekcije.Location = new System.Drawing.Point(4, 22);
            this.Projekcije.Name = "Projekcije";
            this.Projekcije.Size = new System.Drawing.Size(744, 388);
            this.Projekcije.TabIndex = 3;
            this.Projekcije.Text = "Projekcije";
            this.Projekcije.UseVisualStyleBackColor = true;
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(6, 18);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(103, 13);
            this.labelSale.TabIndex = 8;
            this.labelSale.Text = "Lista dostupnih sala:";
            // 
            // buttonDelSale
            // 
            this.buttonDelSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelSale.Location = new System.Drawing.Point(665, 75);
            this.buttonDelSale.Name = "buttonDelSale";
            this.buttonDelSale.Size = new System.Drawing.Size(75, 23);
            this.buttonDelSale.TabIndex = 7;
            this.buttonDelSale.Text = "Izbrisi";
            this.buttonDelSale.UseVisualStyleBackColor = true;
            this.buttonDelSale.Click += new System.EventHandler(this.buttonDelSale_Click);
            // 
            // buttonAddSale
            // 
            this.buttonAddSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSale.Location = new System.Drawing.Point(665, 46);
            this.buttonAddSale.Name = "buttonAddSale";
            this.buttonAddSale.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSale.TabIndex = 6;
            this.buttonAddSale.Text = "Dodaj";
            this.buttonAddSale.UseVisualStyleBackColor = true;
            this.buttonAddSale.Click += new System.EventHandler(this.buttonAddSale_Click);
            // 
            // listBoxSale
            // 
            this.listBoxSale.FormattingEnabled = true;
            this.listBoxSale.Location = new System.Drawing.Point(5, 42);
            this.listBoxSale.Name = "listBoxSale";
            this.listBoxSale.Size = new System.Drawing.Size(471, 329);
            this.listBoxSale.TabIndex = 5;
            this.listBoxSale.SelectedIndexChanged += new System.EventHandler(this.listBoxSale_SelectedIndexChanged);
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 416);
            this.Controls.Add(this.tabControl);
            this.Name = "Administracija";
            this.Text = "Administracija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administracija_FormClosed);
            this.Load += new System.EventHandler(this.Administracija_Load);
            this.Resize += new System.EventHandler(this.Administracija_Resize);
            this.tabControl.ResumeLayout(false);
            this.Filmovi.ResumeLayout(false);
            this.Filmovi.PerformLayout();
            this.Sale.ResumeLayout(false);
            this.Sale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Filmovi;
        private System.Windows.Forms.TabPage Sale;
        private System.Windows.Forms.TabPage Karte;
        private System.Windows.Forms.TabPage Projekcije;
        private System.Windows.Forms.Button buttonFilmDet;
        private System.Windows.Forms.Button buttonFilmRemove;
        private System.Windows.Forms.Button buttonFilmAdd;
        private System.Windows.Forms.ListBox listBoxFilmovi;
        private System.Windows.Forms.Label labelFilmovi;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Button buttonDelSale;
        private System.Windows.Forms.Button buttonAddSale;
        private System.Windows.Forms.ListBox listBoxSale;
    }
}