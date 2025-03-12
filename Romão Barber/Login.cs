using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Romão_Barber
{
    public partial class Login : Form
    {
        //BindingList<Barbeiro> barbeiros = new BindingList<Barbeiro>();

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbemail.Text == "" || tbpassword.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro");
            }
            else
            {
                try
                {
                    MySqlConnection ligacao;
                    using (ligacao = new MySqlConnection("Persist Security Info=false; server=localhost; database=Barbearia; uid=root; SslMode=none"))
                    {
                        ligacao.Open();
                        string sql = "SELECT * FROM barbeiros Where NIF=@nif and Palavra_Passe= AES_Encrypt(@palavra, @chave)";
                        using (MySqlCommand comando = new MySqlCommand(sql, ligacao))
                        {
                            comando.Parameters.AddWithValue("@nif", tbemail.Text);
                            comando.Parameters.AddWithValue("@palavra", tbpassword.Text);
                            comando.Parameters.AddWithValue("@chave", VariaveisGlobais.ChaveEncrypt);

                            int nRegistos = 0;
                            using (MySqlDataReader registo = comando.ExecuteReader())
                            {
                                while (registo.Read())
                                {
                                    nRegistos++;
                                    VariaveisGlobais.NomeUtilApp = registo["nome"].ToString();
                                    VariaveisGlobais.TipoUtilApp = "Barbeiro";
                                    VariaveisGlobais.IdUtilApp = (int)registo["id_barbeiro"];
                                }
                                ligacao.Close();
                                ligacao.Open();
                                string sql1 = "SELECT * FROM clientes Where NIF=@nif and Palavra_Passe= AES_Encrypt(@palavra, @chave)";
                                using (MySqlCommand comando1 = new MySqlCommand(sql1, ligacao))
                                {
                                    comando1.Parameters.AddWithValue("@nif", tbemail.Text);
                                    comando1.Parameters.AddWithValue("@palavra", tbpassword.Text);
                                    comando1.Parameters.AddWithValue("@chave", VariaveisGlobais.ChaveEncrypt);

                                    using (MySqlDataReader registo1 = comando1.ExecuteReader())
                                    {
                                        while (registo1.Read())
                                        {
                                            nRegistos++;
                                            VariaveisGlobais.NomeUtilApp = registo1["nome"].ToString();
                                            VariaveisGlobais.TipoUtilApp = "Cliente";
                                            VariaveisGlobais.IdUtilApp = (int)registo1["id_cliente"];
                                        }
                                        if (nRegistos > 0)
                                        {
                                            Inicial formapp = new Inicial();
                                            formapp.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Utilizador ou Palavra Passe não existem");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Registar f = new Registar();
            f.ShowDialog();

        }

        private void pbpa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            pbolhofechado.Hide();
            tbpassword.PasswordChar = '*';
        }

        private void pbolhoaberto_Click(object sender, EventArgs e)
        {
            pbolhofechado.Show();
            tbpassword.PasswordChar = '\0';
        }
    }
}
