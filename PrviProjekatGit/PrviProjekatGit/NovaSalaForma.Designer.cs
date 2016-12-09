namespace PrviProjekatGit
{
    partial class NovaSalaForma
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
            this.textBoxRedova = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelRedova = new System.Windows.Forms.Label();
            this.labelKolona = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCnc = new System.Windows.Forms.Button();
            this.textBoxKolona = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRedova
            // 
            this.textBoxRedova.Location = new System.Drawing.Point(66, 94);
            this.textBoxRedova.Name = "textBoxRedova";
            this.textBoxRedova.Size = new System.Drawing.Size(268, 20);
            this.textBoxRedova.TabIndex = 0;
            this.textBoxRedova.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            this.textBoxRedova.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRedova_KeyPress);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(66, 68);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(268, 20);
            this.textBoxNaziv.TabIndex = 2;
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(25, 71);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 3;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelRedova
            // 
            this.labelRedova.AutoSize = true;
            this.labelRedova.Location = new System.Drawing.Point(15, 97);
            this.labelRedova.Name = "labelRedova";
            this.labelRedova.Size = new System.Drawing.Size(45, 13);
            this.labelRedova.TabIndex = 4;
            this.labelRedova.Text = "Redova";
            // 
            // labelKolona
            // 
            this.labelKolona.AutoSize = true;
            this.labelKolona.Location = new System.Drawing.Point(20, 123);
            this.labelKolona.Name = "labelKolona";
            this.labelKolona.Size = new System.Drawing.Size(40, 13);
            this.labelKolona.TabIndex = 5;
            this.labelKolona.Text = "Kolona";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(241, 305);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCnc
            // 
            this.buttonCnc.Location = new System.Drawing.Point(322, 305);
            this.buttonCnc.Name = "buttonCnc";
            this.buttonCnc.Size = new System.Drawing.Size(75, 23);
            this.buttonCnc.TabIndex = 7;
            this.buttonCnc.Text = "Cancel";
            this.buttonCnc.UseVisualStyleBackColor = true;
            this.buttonCnc.Click += new System.EventHandler(this.buttonCnc_Click);
            // 
            // textBoxKolona
            // 
            this.textBoxKolona.Location = new System.Drawing.Point(66, 120);
            this.textBoxKolona.Name = "textBoxKolona";
            this.textBoxKolona.Size = new System.Drawing.Size(268, 20);
            this.textBoxKolona.TabIndex = 8;
            this.textBoxKolona.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // NovaSalaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 340);
            this.Controls.Add(this.textBoxKolona);
            this.Controls.Add(this.buttonCnc);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelKolona);
            this.Controls.Add(this.labelRedova);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.textBoxRedova);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaSalaForma";
            this.Text = "Dodaj novu salu";
            this.Load += new System.EventHandler(this.NovaSalaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRedova;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelRedova;
        private System.Windows.Forms.Label labelKolona;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCnc;
        private System.Windows.Forms.TextBox textBoxKolona;
    }
}