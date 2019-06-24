using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Camadas.BLL
{
    public class Servico
    {
        public List<Model.Servico> Select()
        {
            DAL.Servico dalServ = new DAL.Servico();
            return dalServ.Select();
        }
        public void Insert(Model.Servico servico)
        {
            DAL.Servico dalServ = new DAL.Servico();
            if (servico.descricao != string.Empty)
                dalServ.Insert(servico);
        }

        public void Update(Model.Servico servico)
        {
            DAL.Servico dalServ = new DAL.Servico();
            if (servico.descricao != "")
                dalServ.Update(servico);
        }

        public void Delete(int id)
        {
            DAL.Servico dalServ = new DAL.Servico();
            if (id > 0)
                dalServ.Delete(id);
        }
        public List<Model.Servico> SelectById(int id)
        {
            DAL.Servico dalServ = new DAL.Servico();
            return dalServ.SelectById(id);
        }
        public List<Model.Servico> SelectByDescricao(string descricao)
        {
            DAL.Servico dalServ = new DAL.Servico();
            return dalServ.SelectByDescricao(descricao);
        }
    }
}
