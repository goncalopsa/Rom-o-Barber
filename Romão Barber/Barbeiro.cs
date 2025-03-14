using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Romão_Barber
{
    public class Barbeiro
    {
        public int iD_Barbeiro { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string NIF { get; set; }
        public int Ativo { get; set; }

        public Barbeiro(int iD_Barbeiro, string nome, DateTime data_Nascimento)
        {
            this.iD_Barbeiro = iD_Barbeiro;
            Nome = nome;
            Data_Nascimento = data_Nascimento;
        }

        public Barbeiro(int iD_Barbeiro, string nome)
        {
            this.iD_Barbeiro = iD_Barbeiro;
            Nome = nome;
        }

        public Barbeiro(int iD_Barbeiro, string nome, DateTime data_Nascimento, string nIF, int ativo) : this(iD_Barbeiro, nome, data_Nascimento)
        {
            NIF = nIF;
            Ativo = ativo;
        }
    }
}
