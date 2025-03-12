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
    public partial class Registar : Form
    {
        public Registar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inserir clientes
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
        }
    }
}
