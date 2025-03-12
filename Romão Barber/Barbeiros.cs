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
            try
            {
                string sql = "select * from barbeiros where Nome like @nome;";
                barbeiros = new BindingList<Barbeiro>();
                using (MySqlCommand cmd = new MySqlCommand(sql, ligacao))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + tbpesquisar.Text + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            barbeiros.Add(new Barbeiro(reader.GetInt32("iD_Barbeiro"),
                                reader.GetString("Nome")));
                        }
                    }
                }
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgv.MultiSelect = false;
                dgv.DataSource = barbeiros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listaBarbeiros()
        {
            try
            {
                string sql = "select * from barbeiros ";

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

                            Barbeiro x = new Barbeiro(reader.GetInt32("iD_Barbeiro"), reader.GetString("nome"));

                            barbeiros.Add(x);

                        }
                    }
                }
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgv.MultiSelect = false;
                dgv.DataSource = barbeiros;
                dgv.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Funcionarios_Load(object sender, EventArgs e)
        {

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
            Application.Exit();
        }
    }
}
