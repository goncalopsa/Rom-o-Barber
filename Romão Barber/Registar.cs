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
    public partial class Registar : Form
    {
        MySqlConnection ligacao;
        public Registar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO clientes VALUES (@Nome , @NIF, @Palavra_Passe, @@Data_Nascimento)";
                using (MySqlCommand cmd = new MySqlCommand(sql, ligacao))
                {
                    cmd.Parameters.AddWithValue("@Nome", tbnome.Text);
                    cmd.Parameters.AddWithValue("@NIF", tbnif.Text);
                    cmd.Parameters.AddWithValue("@Palavra_Passe", tbpass.Text);
                    cmd.Parameters.AddWithValue("@Data_Nascimento", dtp.Text);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
