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
        BindingList<Utilizador> utilizadores = new BindingList<Utilizador>();
        MySqlConnection ligacao;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            saidapequena.Hide();
            saidagrande.Show();
        }

        private void saidagrande_MouseLeave(object sender, EventArgs e)
        {
            saidagrande.Hide();
            saidapequena.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbemail.Text == "" || tbpass.Text == "")
            {
                MessageBox.Show("Palavra Passe ou Nome Incorretos", "Erro");
            }
            else
            {
                try
                {
                    MySqlConnection ligacao;
                    using (ligacao = new MySqlConnection("Persist Security Info=false; server=localhost; database=Barbearia; uid=root; SslMode=none"))
                    {
                        ligacao.Open();
                        string sql = "SELECT * FROM utilizador Where Email_Utilizador=@nome and Palavra_Passe= AES_Encrypt(@palavra, '1234')";
                        using (MySqlCommand comando = new MySqlCommand(sql, ligacao))
                        {
                            comando.Parameters.AddWithValue("@nome", tbemail.Text);
                            comando.Parameters.AddWithValue("@palavra", tbpass.Text);

                            int nRegistos = 0;
                            using (MySqlDataReader registo = comando.ExecuteReader())
                            {
                                while (registo.Read())
                                {
                                    nRegistos++;
                                    VariaveisGlobais.NomeUtilApp = registo["Nome_Utilizador"].ToString();
                                    VariaveisGlobais.TipoUtilApp = registo["Tipo"].ToString();
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

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
