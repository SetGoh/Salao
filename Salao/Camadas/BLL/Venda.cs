using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Camadas.BLL
{
    public class Venda
    {
        public List<Model.Venda> Select()
        {
            DAL.Venda dalVend = new DAL.Venda();
            return dalVend.Select();
        }
        public void Insert(Model.Venda venda)
        {
            DAL.Venda dalVend = new DAL.Venda();
//            if (venda.cliente != 0) Preciso arrumar
                dalVend.Insert(venda);
        }

        public void Update(Model.Venda venda)
        {
            DAL.Venda dalVend = new DAL.Venda();
//            if (venda.cliente != 0) Preciso arrumar
                dalVend.Update(venda);
        }

        public void Delete(int id)
        {
            DAL.Venda dalVend = new DAL.Venda();
            if (id > 0)
                dalVend.Delete(id);

        }
    }
}
