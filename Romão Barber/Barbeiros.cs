using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romão_Barber
{
    public partial class Barbeiros : Form
    {
        BindingList<Barbeiro> barbeiros = new BindingList<Barbeiro>();
        MySqlConnection ligacao;
        public Barbeiros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listaBarbeiros();
        }
        private void listaBarbeiros()
        {
            try
            {
                ligacao.Open();
                string sql = "select * from barbeiros where 1 ";
                barbeiros.Clear();

                if (!string.IsNullOrWhiteSpace(tbpesquisar.Text))
                {
                    sql = sql + "and Nome like @Nome ";
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, ligacao))
                {
                    if (!string.IsNullOrWhiteSpace(tbpesquisar.Text))
                    {
                        cmd.Parameters.AddWithValue("@Nome", "%" + tbpesquisar.Text + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idu = reader.GetInt32("iD_Barbeiro");
                            String nome = reader.GetString("nome");
                            DateTime data = reader.GetDateTime("data_Nascimento");
                            String nif = reader.GetString("nif");
                            int ativo = reader.GetInt32("ativo");

                            Barbeiro x = new Barbeiro(idu, nome, data, nif, ativo);

                            barbeiros.Add(x);

                        }
                    }
                }
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgv.MultiSelect = false;
                dgv.DataSource = barbeiros;
                dgv.Columns[0].Visible = false;
                ligacao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void pbpa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Barbeiros_Load(object sender, EventArgs e)
        {
            ligacao = new MySqlConnection("Persist Security Info=false; server=localhost; database=Barbearia; uid=root; SslMode=none");
            listaBarbeiros();
        }

        private void btcriar_Click(object sender, EventArgs e)
        {
            DetalhesBarbeiro x = new DetalhesBarbeiro();
            x.ShowDialog();
            listaBarbeiros();
        }
    }
}
