using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Camadas.Model
{
    public class Produto
    {
        public int id { get; set; }
        public string nomeProd { get; set; }
        public string linha { get; set; }
        public string marca { get; set; }
        public int quantidade { get; set; }
        public float valorProd { get; set; }
        public virtual float total { get { return quantidade * valorProd; } }

    }
}
