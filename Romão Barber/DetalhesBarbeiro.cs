using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romão_Barber
{
    public partial class DetalhesBarbeiro : Form
    {
        public DetalhesBarbeiro()
        {
            InitializeComponent();
        }

        private void DetalhesBarbeiro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
            this.Close();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {

        }
    }
}
