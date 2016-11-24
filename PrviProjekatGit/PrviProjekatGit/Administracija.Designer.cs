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
            this.Sale = new System.Windows.Forms.TabPage();
            this.Karte = new System.Windows.Forms.TabPage();
            this.Projekcije = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
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
            this.Filmovi.Location = new System.Drawing.Point(4, 22);
            this.Filmovi.Name = "Filmovi";
            this.Filmovi.Size = new System.Drawing.Size(744, 388);
            this.Filmovi.TabIndex = 0;
            this.Filmovi.Text = "Filmovi";
            this.Filmovi.UseVisualStyleBackColor = true;
            // 
            // Sale
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Filmovi;
        private System.Windows.Forms.TabPage Sale;
        private System.Windows.Forms.TabPage Karte;
        private System.Windows.Forms.TabPage Projekcije;
    }
}