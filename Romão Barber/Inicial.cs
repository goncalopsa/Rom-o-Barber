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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Barbeiros b = new Barbeiros();
            b.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Servicos j = new Servicos();
            j.ShowDialog();
        }
        private void Inicial_Load(object sender, EventArgs e)
        {
            lbtipo.Text = VariaveisGlobais.TipoUtilApp;
            lbnome.Text = VariaveisGlobais.NomeUtilApp;
            if (VariaveisGlobais.TipoUtilApp == "Barbeiro")
            {
                pbc.Visible = true;
                lbc.Visible = true;
            }
            else
            {

                pbc.Visible = false;
                lbc.Visible = false;
            }
        }
        private void pbc_Click(object sender, EventArgs e)
        {
            Clientes d = new Clientes();
            d.ShowDialog();
        }
        private void pbpa_Click(object sender, EventArgs e)
        {
            Login d = new Login();
            d.ShowDialog();
        }
        private void pbpf_MouseHover(object sender, EventArgs e)
        {
            pbpf.Hide();
            pbpa.Show();
        }
        private void pbpa_MouseLeave(object sender, EventArgs e)
        {
            pbpa.Hide();
            pbpf.Show();
        }
    }//jorge
}
