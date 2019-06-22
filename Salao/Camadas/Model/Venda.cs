using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Camadas.Model
{
    public class Venda
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public int cliente { get; set; }
        public virtual string nome { get; set; }
        public int servico { get; set; }
        public virtual string descricao { get; set; }
        public virtual float valorServ { get; set; }
        public int produto { get; set; }
        public virtual string nomeProd { get; set; }
        public int quantidade { get; set; }
        public virtual float valorProd { get; set; }
        public virtual float total { get { return valorServ + quantidade * valorProd; } }
    }
}
