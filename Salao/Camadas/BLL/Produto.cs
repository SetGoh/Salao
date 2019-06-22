using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Camadas.BLL
{
    public class Produto
    {
        public List<Model.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }
        public void Insert(Model.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.nomeProd != string.Empty)
                dalProd.Insert(produto);
        }

        public void Update(Model.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.nomeProd != "")
                dalProd.Update(produto);
        }

        public void Delete(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (id > 0)
                dalProd.Delete(id);
        }
        public List<Model.Produto> SelectById(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectById(id);
        }
        public List<Model.Produto> SelectByNome(string nomeProd)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByNome(nomeProd);
        }

        public List<Model.Produto> SelectByMarca(string marca)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByMarca(marca);
        }

    }
}
