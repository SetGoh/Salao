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
            BLL.Produto bllProd = new Produto();

            Model.Produto produto = new Model.Produto();
            
            produto = bllProd.SelectById(venda.produto)[0];
            produto.quantidade = produto.quantidade - venda.quantidade;

            bllProd.Update(produto);  
            dalVend.Insert(venda);
        }

        public void Update(Model.Venda venda)
        {
            DAL.Venda dalVend = new DAL.Venda();
                dalVend.Update(venda);
        }

        public void Delete(int id)
        {
            DAL.Venda dalVend = new DAL.Venda();
            if (id > 0)
                dalVend.Delete(id);

        }
        public List<Model.Venda> SelectById(int id)
        {
            DAL.Venda dalVend = new DAL.Venda();
            return dalVend.SelectById(id);
        }
    }
}
