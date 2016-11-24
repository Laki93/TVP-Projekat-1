using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviProjekatGit
{
    public partial class Administracija : Form
    {
        public Administracija()
        {
            InitializeComponent();
        }

        private void Administracija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Administracija_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            tabControl.Height =this.Size.Height-43;
            tabControl.Width = this.Size.Width-14;

        }

        private void Administracija_Resize(object sender, EventArgs e)
        {
            tabControl.Height = this.Size.Height-43;
            tabControl.Width = this.Size.Width-14;
        }
    }
}
