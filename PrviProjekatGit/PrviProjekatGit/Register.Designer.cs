namespace PrviProjekatGit
{
    partial class Register
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
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCnc = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.checkBoxShwPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReg.Location = new System.Drawing.Point(73, 204);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(75, 23);
            this.buttonReg.TabIndex = 0;
            this.buttonReg.Text = "Register";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCnc
            // 
            this.buttonCnc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCnc.Location = new System.Drawing.Point(194, 204);
            this.buttonCnc.Name = "buttonCnc";
            this.buttonCnc.Size = new System.Drawing.Size(75, 23);
            this.buttonCnc.TabIndex = 1;
            this.buttonCnc.Text = "Cancel";
            this.buttonCnc.UseVisualStyleBackColor = true;
            this.buttonCnc.Click += new System.EventHandler(this.buttonCnc_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUser.Location = new System.Drawing.Point(97, 81);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUser_KeyPress);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPass.Location = new System.Drawing.Point(97, 107);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUser_KeyPress);
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(38, 84);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 13);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "Username";
            // 
            // labelPass
            // 
            this.labelPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(38, 110);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 5;
            this.labelPass.Text = "Password";
            // 
            // checkBoxShwPass
            // 
            this.checkBoxShwPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxShwPass.AutoSize = true;
            this.checkBoxShwPass.Location = new System.Drawing.Point(204, 109);
            this.checkBoxShwPass.Name = "checkBoxShwPass";
            this.checkBoxShwPass.Size = new System.Drawing.Size(101, 17);
            this.checkBoxShwPass.TabIndex = 6;
            this.checkBoxShwPass.Text = "Show password";
            this.checkBoxShwPass.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 304);
            this.Controls.Add(this.checkBoxShwPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.buttonCnc);
            this.Controls.Add(this.buttonReg);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCnc;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.CheckBox checkBoxShwPass;
    }
}