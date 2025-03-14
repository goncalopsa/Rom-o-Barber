using MySql.Data.MySqlClient;
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
    public partial class Clientes : Form
    {
        BindingList<Cliente> Listaclientes = new BindingList<Cliente>();
        MySqlConnection ligacao;
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registar k = new Registar();
            k.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listarClientes()
        {

            try
            {
                ligacao.Open();
                Listaclientes.Clear();
                string sql = "select * from clientes ";

                if (!string.IsNullOrWhiteSpace(tbpesquisar.Text))
                {
                    sql = sql + "where Nome like @Nome or nif like @nif";
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, ligacao))
                {
                    if (!string.IsNullOrWhiteSpace(tbpesquisar.Text))
                    {
                        cmd.Parameters.AddWithValue("@Nome", "%" + tbpesquisar.Text + "%");
                        cmd.Parameters.AddWithValue("@nif", "%" + tbpesquisar.Text + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idu = reader.GetInt32("iD_Cliente");

                            Cliente x = new Cliente(reader.GetInt32("iD_Cliente"), reader.GetString("nome"), reader.GetString("nif"), reader.GetDateTime("data_nascimento"));

                            Listaclientes.Add(x);

                        }
                    }
                }
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgv.MultiSelect = false;
                dgv.DataSource = Listaclientes;
                dgv.Columns[0].Visible = false;
                ligacao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ligacao = new MySqlConnection("Persist Security Info=false; server=localhost; database=Barbearia; uid=root; SslMode=none");
            listarClientes();
        }

        private void tbpesquisar_TextChanged(object sender, EventArgs e)
        {
            listarClientes();
        }

        private void pbpa_Click(object sender, EventArgs e)
        {
            Inicial d = new Inicial();
            d.ShowDialog();
            this.Close(); Application.Exit();
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
    }
}
