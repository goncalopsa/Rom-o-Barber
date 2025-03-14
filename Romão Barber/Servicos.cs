using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
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
    public partial class Servicos : Form
    {
        BindingList<Servico> servicos = new BindingList<Servico>();
        MySqlConnection ligacao;
        public Servicos()
        {
            InitializeComponent();
        }
        public void listarServicos()
        {

            try
            {
                ligacao.Open();
                servicos.Clear();
                string sql = "select * from servicos ";

                if (!string.IsNullOrWhiteSpace(tbpesquisar.Text))
                {
                    sql = sql + "where descricao like @desc";
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, ligacao))
                {
                    if (!string.IsNullOrWhiteSpace(tbpesquisar.Text))
                    {
                        cmd.Parameters.AddWithValue("@desc", "%" + tbpesquisar.Text + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Servico x = new Servico(reader.GetInt32("iD_Servico"), reader.GetString("descricao"), reader.GetFloat("preco"));
                            servicos.Add(x);

                        }
                    }
                }
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgv.MultiSelect = false;
                dgv.DataSource = servicos;
                dgv.Columns[0].Visible = false;
               
                ligacao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listarServicos();
        }

        private void Servicos_Load(object sender, EventArgs e)
        {
            ligacao = new MySqlConnection("Persist Security Info=false; server=localhost; database=Barbearia; uid=root; SslMode=none");
            listarServicos();
        }

        private void pbpa_Click(object sender, EventArgs e)
        {
            Inicial d = new Inicial();
            d.ShowDialog();
            this.Close();
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
