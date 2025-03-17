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
    public partial class DetalhesBarbeiro : Form
    {
        MySqlConnection ligacao;
        public DetalhesBarbeiro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            ligacao.Open();
            string sql = "INSERT INTO barbeiros VALUES (null, @Nome, @NIF, @Palavra_Passe, @Data_Nascimento, @Ativo)";
            using (MySqlCommand cmd = new MySqlCommand(sql, ligacao))

            {
                cmd.Parameters.AddWithValue("@Nome", tbnome.Text);
                cmd.Parameters.AddWithValue("@NIF", tbnif.Text);
                cmd.Parameters.AddWithValue("@Palavra_Passe", tbpass.Text);
                cmd.Parameters.AddWithValue("@Data_Nascimento", dtp.Text);
                cmd.Parameters.AddWithValue("@Ativo", dtp.Text);
                cmd.ExecuteNonQuery();
            }
            ligacao.Close();
            this.Close();
        }

        private void DetalhesBarbeiro_Load(object sender, EventArgs e)
        {
            ligacao = new MySqlConnection("Persist Security Info=false; server=localhost; database=Barbearia; uid=root; SslMode=none");
        }
    }
}
