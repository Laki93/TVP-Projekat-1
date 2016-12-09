namespace PrviProjekatGit
{
    partial class RezervacijaKarata
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCena = new System.Windows.Forms.ComboBox();
            this.labelCena = new System.Windows.Forms.Label();
            this.buttonKupi = new System.Windows.Forms.Button();
            this.buttonOceni = new System.Windows.Forms.Button();
            this.textBoxOcena = new System.Windows.Forms.TextBox();
            this.labelOcena = new System.Windows.Forms.Label();
            this.panelFull = new System.Windows.Forms.Panel();
            this.labelPuno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(555, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(555, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLATNO";
            // 
            // comboBoxCena
            // 
            this.comboBoxCena.FormattingEnabled = true;
            this.comboBoxCena.Location = new System.Drawing.Point(13, 46);
            this.comboBoxCena.Name = "comboBoxCena";
            this.comboBoxCena.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCena.TabIndex = 2;
            this.comboBoxCena.SelectedIndexChanged += new System.EventHandler(this.textBoxOcena_TextChanged);
            this.comboBoxCena.TextUpdate += new System.EventHandler(this.textBoxOcena_TextChanged);
            this.comboBoxCena.SelectedValueChanged += new System.EventHandler(this.textBoxOcena_TextChanged);
            this.comboBoxCena.TextChanged += new System.EventHandler(this.textBoxOcena_TextChanged);
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(13, 27);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(32, 13);
            this.labelCena.TabIndex = 3;
            this.labelCena.Text = "Cena";
            // 
            // buttonKupi
            // 
            this.buttonKupi.Location = new System.Drawing.Point(141, 44);
            this.buttonKupi.Name = "buttonKupi";
            this.buttonKupi.Size = new System.Drawing.Size(75, 23);
            this.buttonKupi.TabIndex = 4;
            this.buttonKupi.Text = "Kupi";
            this.buttonKupi.UseVisualStyleBackColor = true;
            this.buttonKupi.Click += new System.EventHandler(this.buttonKupi_Click);
            // 
            // buttonOceni
            // 
            this.buttonOceni.Location = new System.Drawing.Point(141, 129);
            this.buttonOceni.Name = "buttonOceni";
            this.buttonOceni.Size = new System.Drawing.Size(75, 23);
            this.buttonOceni.TabIndex = 5;
            this.buttonOceni.Text = "Oceni";
            this.buttonOceni.UseVisualStyleBackColor = true;
            this.buttonOceni.Click += new System.EventHandler(this.buttonOceni_Click);
            // 
            // textBoxOcena
            // 
            this.textBoxOcena.Location = new System.Drawing.Point(16, 131);
            this.textBoxOcena.Name = "textBoxOcena";
            this.textBoxOcena.Size = new System.Drawing.Size(119, 20);
            this.textBoxOcena.TabIndex = 6;
            this.textBoxOcena.TextChanged += new System.EventHandler(this.textBoxOcena_TextChanged);
            this.textBoxOcena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOcena_KeyPress);
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(40, 115);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(57, 13);
            this.labelOcena.TabIndex = 7;
            this.labelOcena.Text = "Ocena 1-5";
            // 
            // panelFull
            // 
            this.panelFull.Location = new System.Drawing.Point(13, 409);
            this.panelFull.Name = "panelFull";
            this.panelFull.Size = new System.Drawing.Size(862, 31);
            this.panelFull.TabIndex = 8;
            // 
            // labelPuno
            // 
            this.labelPuno.AutoSize = true;
            this.labelPuno.Location = new System.Drawing.Point(430, 385);
            this.labelPuno.Name = "labelPuno";
            this.labelPuno.Size = new System.Drawing.Size(94, 13);
            this.labelPuno.TabIndex = 9;
            this.labelPuno.Text = "Popunjeno  % sale";
            // 
            // RezervacijaKarata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 452);
            this.Controls.Add(this.labelPuno);
            this.Controls.Add(this.panelFull);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.textBoxOcena);
            this.Controls.Add(this.buttonOceni);
            this.Controls.Add(this.buttonKupi);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.comboBoxCena);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RezervacijaKarata";
            this.Text = "RezervacijaKarata";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RezervacijaKarata_FormClosing);
            this.Load += new System.EventHandler(this.RezervacijaKarata_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RezervacijaKarata_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCena;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Button buttonKupi;
        private System.Windows.Forms.Button buttonOceni;
        private System.Windows.Forms.TextBox textBoxOcena;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Panel panelFull;
        private System.Windows.Forms.Label labelPuno;
    }
}