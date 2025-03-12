using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romão_Barber
{
    public class Servico
    {
        public int id_servico { get; set; }
        [DisplayName("Serviço")]
        public string descricao { get; set; }
        [DisplayName("Preço")]
        public float preco { get; set; }

        public Servico(int id_servico, string descricao, float preco)
        {
            this.id_servico = id_servico;
            this.descricao = descricao;
            this.preco = preco;
        }
    }
}
