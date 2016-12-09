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
            this.labelSale = new System.Windows.Forms.Label();
            this.buttonDelSale = new System.Windows.Forms.Button();
            this.buttonAddSale = new System.Windows.Forms.Button();
            this.listBoxSale = new System.Windows.Forms.ListBox();
            this.Karte = new System.Windows.Forms.TabPage();
            this.Projekcije = new System.Windows.Forms.TabPage();
            this.comboBoxFilmovi = new System.Windows.Forms.ComboBox();
            this.comboBoxSale = new System.Windows.Forms.ComboBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.buttonNapraviKarte = new System.Windows.Forms.Button();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelSala = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxKarte = new System.Windows.Forms.ListBox();
            this.labelListaKarata = new System.Windows.Forms.Label();
            this.dateTimePickerVreme = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProjSale = new System.Windows.Forms.ComboBox();
            this.comboBoxProjFilmovi = new System.Windows.Forms.ComboBox();
            this.labelProjFilm = new System.Windows.Forms.Label();
            this.labelProjSala = new System.Windows.Forms.Label();
            this.labelVreme = new System.Windows.Forms.Label();
            this.buttonProjNapravi = new System.Windows.Forms.Button();
            this.listBoxProjekcije = new System.Windows.Forms.ListBox();
            this.labelProjListBox = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Filmovi.SuspendLayout();
            this.Sale.SuspendLayout();
            this.Karte.SuspendLayout();
            this.Projekcije.SuspendLayout();
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
            // Karte
            // 
            this.Karte.Controls.Add(this.labelListaKarata);
            this.Karte.Controls.Add(this.listBoxKarte);
            this.Karte.Controls.Add(this.label3);
            this.Karte.Controls.Add(this.labelSala);
            this.Karte.Controls.Add(this.labelFilm);
            this.Karte.Controls.Add(this.buttonNapraviKarte);
            this.Karte.Controls.Add(this.textBoxCena);
            this.Karte.Controls.Add(this.comboBoxSale);
            this.Karte.Controls.Add(this.comboBoxFilmovi);
            this.Karte.Location = new System.Drawing.Point(4, 22);
            this.Karte.Name = "Karte";
            this.Karte.Size = new System.Drawing.Size(744, 388);
            this.Karte.TabIndex = 2;
            this.Karte.Text = "Karte";
            this.Karte.UseVisualStyleBackColor = true;
            // 
            // Projekcije
            // 
            this.Projekcije.Controls.Add(this.labelProjListBox);
            this.Projekcije.Controls.Add(this.listBoxProjekcije);
            this.Projekcije.Controls.Add(this.buttonProjNapravi);
            this.Projekcije.Controls.Add(this.labelVreme);
            this.Projekcije.Controls.Add(this.labelProjSala);
            this.Projekcije.Controls.Add(this.labelProjFilm);
            this.Projekcije.Controls.Add(this.comboBoxProjFilmovi);
            this.Projekcije.Controls.Add(this.comboBoxProjSale);
            this.Projekcije.Controls.Add(this.dateTimePickerVreme);
            this.Projekcije.Location = new System.Drawing.Point(4, 22);
            this.Projekcije.Name = "Projekcije";
            this.Projekcije.Size = new System.Drawing.Size(744, 388);
            this.Projekcije.TabIndex = 3;
            this.Projekcije.Text = "Projekcije";
            this.Projekcije.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilmovi
            // 
            this.comboBoxFilmovi.FormattingEnabled = true;
            this.comboBoxFilmovi.Location = new System.Drawing.Point(9, 50);
            this.comboBoxFilmovi.Name = "comboBoxFilmovi";
            this.comboBoxFilmovi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmovi.TabIndex = 0;
            this.comboBoxFilmovi.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxFilmovi.TextUpdate += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxFilmovi.SelectedValueChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxFilmovi.TextChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            // 
            // comboBoxSale
            // 
            this.comboBoxSale.FormattingEnabled = true;
            this.comboBoxSale.Location = new System.Drawing.Point(136, 50);
            this.comboBoxSale.Name = "comboBoxSale";
            this.comboBoxSale.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSale.TabIndex = 1;
            this.comboBoxSale.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxSale.TextUpdate += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxSale.SelectedValueChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxSale.TextChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(263, 50);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCena.TabIndex = 2;
            this.textBoxCena.TextChanged += new System.EventHandler(this.textBoxCena_TextChanged);
            this.textBoxCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCena_KeyPress);
            // 
            // buttonNapraviKarte
            // 
            this.buttonNapraviKarte.Location = new System.Drawing.Point(369, 48);
            this.buttonNapraviKarte.Name = "buttonNapraviKarte";
            this.buttonNapraviKarte.Size = new System.Drawing.Size(75, 23);
            this.buttonNapraviKarte.TabIndex = 3;
            this.buttonNapraviKarte.Text = "Napravi";
            this.buttonNapraviKarte.UseVisualStyleBackColor = true;
            this.buttonNapraviKarte.Click += new System.EventHandler(this.buttonNapraviKarte_Click);
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(47, 34);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(25, 13);
            this.labelFilm.TabIndex = 4;
            this.labelFilm.Text = "Film";
            // 
            // labelSala
            // 
            this.labelSala.AutoSize = true;
            this.labelSala.Location = new System.Drawing.Point(176, 34);
            this.labelSala.Name = "labelSala";
            this.labelSala.Size = new System.Drawing.Size(28, 13);
            this.labelSala.TabIndex = 5;
            this.labelSala.Text = "Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena";
            // 
            // listBoxKarte
            // 
            this.listBoxKarte.FormattingEnabled = true;
            this.listBoxKarte.Location = new System.Drawing.Point(4, 156);
            this.listBoxKarte.Name = "listBoxKarte";
            this.listBoxKarte.Size = new System.Drawing.Size(440, 225);
            this.listBoxKarte.TabIndex = 7;
            // 
            // labelListaKarata
            // 
            this.labelListaKarata.AutoSize = true;
            this.labelListaKarata.Location = new System.Drawing.Point(1, 140);
            this.labelListaKarata.Name = "labelListaKarata";
            this.labelListaKarata.Size = new System.Drawing.Size(106, 13);
            this.labelListaKarata.TabIndex = 8;
            this.labelListaKarata.Text = "Lista trenutnih karata";
            // 
            // dateTimePickerVreme
            // 
            this.dateTimePickerVreme.CustomFormat = "dd.MM.yyyy. / HH:mm";
            this.dateTimePickerVreme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVreme.Location = new System.Drawing.Point(263, 39);
            this.dateTimePickerVreme.Name = "dateTimePickerVreme";
            this.dateTimePickerVreme.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVreme.TabIndex = 0;
            // 
            // comboBoxProjSale
            // 
            this.comboBoxProjSale.FormattingEnabled = true;
            this.comboBoxProjSale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxProjSale.Location = new System.Drawing.Point(136, 38);
            this.comboBoxProjSale.Name = "comboBoxProjSale";
            this.comboBoxProjSale.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProjSale.TabIndex = 1;
            this.comboBoxProjSale.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxProjSale.TextUpdate += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxProjSale.SelectedValueChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxProjSale.TextChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            // 
            // comboBoxProjFilmovi
            // 
            this.comboBoxProjFilmovi.FormattingEnabled = true;
            this.comboBoxProjFilmovi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxProjFilmovi.Location = new System.Drawing.Point(9, 38);
            this.comboBoxProjFilmovi.Name = "comboBoxProjFilmovi";
            this.comboBoxProjFilmovi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProjFilmovi.TabIndex = 2;
            this.comboBoxProjFilmovi.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxProjFilmovi.TextUpdate += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxProjFilmovi.SelectedValueChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            this.comboBoxProjFilmovi.TextChanged += new System.EventHandler(this.comboBoxFilmovi_SelectedIndexChanged);
            // 
            // labelProjFilm
            // 
            this.labelProjFilm.AutoSize = true;
            this.labelProjFilm.Location = new System.Drawing.Point(55, 23);
            this.labelProjFilm.Name = "labelProjFilm";
            this.labelProjFilm.Size = new System.Drawing.Size(25, 13);
            this.labelProjFilm.TabIndex = 3;
            this.labelProjFilm.Text = "Film";
            // 
            // labelProjSala
            // 
            this.labelProjSala.AutoSize = true;
            this.labelProjSala.Location = new System.Drawing.Point(183, 23);
            this.labelProjSala.Name = "labelProjSala";
            this.labelProjSala.Size = new System.Drawing.Size(28, 13);
            this.labelProjSala.TabIndex = 4;
            this.labelProjSala.Text = "Sala";
            // 
            // labelVreme
            // 
            this.labelVreme.AutoSize = true;
            this.labelVreme.Location = new System.Drawing.Point(332, 23);
            this.labelVreme.Name = "labelVreme";
            this.labelVreme.Size = new System.Drawing.Size(37, 13);
            this.labelVreme.TabIndex = 5;
            this.labelVreme.Text = "Vreme";
            // 
            // buttonProjNapravi
            // 
            this.buttonProjNapravi.Location = new System.Drawing.Point(469, 36);
            this.buttonProjNapravi.Name = "buttonProjNapravi";
            this.buttonProjNapravi.Size = new System.Drawing.Size(75, 23);
            this.buttonProjNapravi.TabIndex = 6;
            this.buttonProjNapravi.Text = "Napravi";
            this.buttonProjNapravi.UseVisualStyleBackColor = true;
            this.buttonProjNapravi.Click += new System.EventHandler(this.buttonProjNapravi_Click);
            // 
            // listBoxProjekcije
            // 
            this.listBoxProjekcije.FormattingEnabled = true;
            this.listBoxProjekcije.Location = new System.Drawing.Point(9, 147);
            this.listBoxProjekcije.Name = "listBoxProjekcije";
            this.listBoxProjekcije.Size = new System.Drawing.Size(535, 238);
            this.listBoxProjekcije.TabIndex = 7;
            // 
            // labelProjListBox
            // 
            this.labelProjListBox.AutoSize = true;
            this.labelProjListBox.Location = new System.Drawing.Point(9, 131);
            this.labelProjListBox.Name = "labelProjListBox";
            this.labelProjListBox.Size = new System.Drawing.Size(101, 13);
            this.labelProjListBox.TabIndex = 8;
            this.labelProjListBox.Text = "Trenutne projekcije:";
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
            this.Karte.ResumeLayout(false);
            this.Karte.PerformLayout();
            this.Projekcije.ResumeLayout(false);
            this.Projekcije.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSala;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Button buttonNapraviKarte;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.ComboBox comboBoxSale;
        private System.Windows.Forms.ComboBox comboBoxFilmovi;
        private System.Windows.Forms.ListBox listBoxKarte;
        private System.Windows.Forms.Label labelListaKarata;
        private System.Windows.Forms.DateTimePicker dateTimePickerVreme;
        private System.Windows.Forms.Button buttonProjNapravi;
        private System.Windows.Forms.Label labelVreme;
        private System.Windows.Forms.Label labelProjSala;
        private System.Windows.Forms.Label labelProjFilm;
        private System.Windows.Forms.ComboBox comboBoxProjFilmovi;
        private System.Windows.Forms.ComboBox comboBoxProjSale;
        private System.Windows.Forms.Label labelProjListBox;
        private System.Windows.Forms.ListBox listBoxProjekcije;
    }
}