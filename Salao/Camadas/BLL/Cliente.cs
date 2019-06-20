using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Camadas.BLL
{
    public class Cliente
    {
        public List<Model.Cliente> SelectById(int id)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.SelectById(id);
        }
        public List<Model.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.SelectByNome(nome);
        }

        public List<Model.Cliente> SelectByCidade(string cidade)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.SelectByCidade(cidade);
        }
        
        public List<Model.Cliente> Select()
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.Select();
        }

        public void Insert(Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            if (cliente.nome != string.Empty)
                dalCli.Insert(cliente);
        }

        public void Update(Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            if (cliente.nome != "")
                dalCli.Update(cliente);
        }

        public void Delete(int id)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            if (id > 0)
                dalCli.Delete(id);

        }

    }
}
