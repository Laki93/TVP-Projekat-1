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
    public partial class Prezentacija : Form
    {
        public Prezentacija()
        {
            InitializeComponent();
        }

        private void Prezentacija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Prezentacija_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
