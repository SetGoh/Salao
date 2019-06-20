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
        public string descricao { get; set; }
        public string linha { get; set; }
        public string marca { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }

    }
}
