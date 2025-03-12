using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romão_Barber
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        [DisplayName("Nome")]
        public string nome { get; set; }
        [DisplayName("Nif")]
        public string nif { get; set; }
        [DisplayName("Data de Nascimento")]
        public DateTime data_nascimento { get; set; }

        public Cliente(int id_cliente, string nome, string nif, DateTime data_nascimento)
        {
            this.id_cliente = id_cliente;
            this.nome = nome;
            this.nif = nif;
            this.data_nascimento = data_nascimento;
        }
    }

}
