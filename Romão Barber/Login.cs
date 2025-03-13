using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Http;

namespace Romão_Barber
{
    public partial class Login : Form
    {
        //private static readonly HttpClient client = new HttpClient();
        //private const string ServerUrl = "http://localhost:8080";
        //private HttpListener listener;

        // Constructor
        public Login()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e) {


        }


     }
}

        //// HTTP Listener to handle login requests
        //private async Task HandleRequests()
        //{
        //    while (listener.IsListening)
        //    {
        //        var context = await listener.GetContextAsync();
        //        var request = context.Request;
        //        var response = context.Response;

        //        if (request.Url.AbsolutePath == "/login" && request.HttpMethod == "POST")
        //        {
        //            using (var reader = new System.IO.StreamReader(request.InputStream, request.ContentEncoding))
        //            {
        //                string body = await reader.ReadToEndAsync();
        //                var loginData = JsonSerializer.Deserialize<LoginRequest>(body);

        //                bool loginSuccess = CheckUserCredentials(loginData.NIF, loginData.Password);
        //                var responseData = new ResponseModel
        //                {
        //                    success = loginSuccess,
        //                    message = loginSuccess ? "Login bem-sucedido" : "Credenciais inválidas"
        //                };

        //                if (loginSuccess)
        //                {
        //                    Invoke(new Action(() =>
        //                    {
        //                        Inicial formApp = new Inicial();
        //                        formApp.Show();
        //                        this.Hide();
        //                    }));
        //                }

        //                string jsonResponse = JsonSerializer.Serialize(responseData);
        //                byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
        //                response.ContentLength64 = buffer.Length;
        //                await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
        //            }
        //        }

        //        response.Close();
        //    }
        //}

        //// Check if the user credentials are correct
        ////private bool CheckUserCredentials(string nif, string password)
        //{
        //    using (var connection = new MySqlConnection("Persist Security Info=false; server=localhost; database=Barbearia; uid=root; SslMode=none"))
        //    {
        //        connection.Open();
        //        string sql = "SELECT * FROM barbeiros WHERE NIF=@nif AND Palavra_Passe= AES_Encrypt(@palavra, @chave)";
        //        using (var command = new MySqlCommand(sql, connection))
        //        {
        //            command.Parameters.AddWithValue("@nif", nif);
        //            command.Parameters.AddWithValue("@palavra", password);
        //            command.Parameters.AddWithValue("@chave", VariaveisGlobais.ChaveEncrypt);

        //            using (var reader = command.ExecuteReader())
        //            {
        //                return reader.HasRows;
        //            }
        //        }
        //    }
        //}
//    }
//}

//        // Class to handle login requests
//        public class LoginRequest
//        {
//            public string NIF { get; set; }
//            public string Password { get; set; }
//        }

//        // Start the HTTP Listener to accept requests
//        //private void StartServer()
//        //{
//        //    listener = new HttpListener();
//        //    listener.Prefixes.Add(ServerUrl + "/");
//        //    listener.Start();
//        //    Task.Run(() => HandleRequests());
//        //}

//        // Button click event to perform login
//private async void pictureBox1_Click(object sender, EventArgs e)
//{
//    if (tbemail.Text == "" || tbpassword.Text == "")
//    {
//        MessageBox.Show("Preencha todos os campos", "Erro");
//    }
//    else
//    {
//        try
//        {
//            // Prepare the login data to be sent to the server
//            var loginData = new
//            {
//                NIF = tbemail.Text,
//                Password = tbpassword.Text
//            };

//            var json = JsonSerializer.Serialize(loginData);
//            var content = new StringContent(json, Encoding.UTF8, "application/json");

//            // Send a POST request to the server to validate credentials
//            HttpResponseMessage response = await client.PostAsync(ServerUrl + "/login", content);
//            string responseBody = await response.Content.ReadAsStringAsync();
//            var result = JsonSerializer.Deserialize<ResponseModel>(responseBody);

//            if (result.success)
//            {
//                Inicial formApp = new Inicial();
//                formApp.Show();
//                this.Hide();
//            }
//            else
//            {
//                MessageBox.Show(result.message, "Erro");
//            }
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show(ex.Message);
////        }
//    }
//}

//        //// Close application when the user clicks on the close button
//        //private void pictureBox2_Click(object sender, EventArgs e)
//        //{
//        //    Application.Exit();
//        //}

//        // Show password
//        private void pictureBox3_Click(object sender, EventArgs e)
//        {
//            pbolhofechado.Hide();
//            tbpassword.PasswordChar = '*';
//        }

//        // Hide password
//        private void pbolhoaberto_Click(object sender, EventArgs e)
//        {
//            pbolhofechado.Show();
//            tbpassword.PasswordChar = '\0';
//        }

//        // Show registration form
//        private void pictureBox1_Click_1(object sender, EventArgs e)
//        {
//            Registar f = new Registar();
//            f.ShowDialog();
//        }

//        //// Start the server when the form loads
//        //private void Login_Load(object sender, EventArgs e)
//        //{
//        //    StartServer();
//        //}

//        // Response model for server responses
//        public class ResponseModel
//        {
//            public bool success { get; set; }
//            public string message { get; set; }
//        }
//    }
//}
