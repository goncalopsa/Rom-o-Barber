using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Romão_Barber
{
    public class Utilizador
    {
        public int ID_Utilizador { get; set; }
        public string Palavra_Passe { get; set; }
        public string Nome_Utilizador { get; set; }
        public string Tipo { get; set; }
        public string Email_Utilizador { get; set; }

        public Utilizador(int iD_Utilizador, string nome_Utilizador, string tipo, string email_Utilizador)
        {
            ID_Utilizador = iD_Utilizador;
            Nome_Utilizador = nome_Utilizador;
            Tipo = tipo;
            Email_Utilizador = email_Utilizador;
        }
    }
}
