using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Salao.Camadas.DAL
{
    public class Servico
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Servico> Select()
        {
            List<Model.Servico> listaServico = new List<Model.Servico>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Servico";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Servico servico = new Model.Servico();
                    servico.id = Convert.ToInt32(dados["id"].ToString());
                    servico.descricao = dados["descricao"].ToString();
                    servico.valorServ = Convert.ToSingle(dados["valorServ"].ToString());
                    listaServico.Add(servico);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Select do Servico");
            }
            finally
            {
                conexao.Close();
            }

            return listaServico;
        }
        public void Insert(Camadas.Model.Servico servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Servico values (@descricao, @valorServ)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", servico.id);
            cmd.Parameters.AddWithValue("@descricao", servico.descricao);
            cmd.Parameters.AddWithValue("@valorServ", servico.valorServ);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - insert do Servico");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Update(Camadas.Model.Servico servico)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Servico set descricao=@descricao, valorServ=@valorServ where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", servico.id);
            cmd.Parameters.AddWithValue("@descricao", servico.descricao);
            cmd.Parameters.AddWithValue("@valorServ", servico.valorServ);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - Update do Servico");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Servico where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - Delete do Servico");
            }
            finally
            {
                conexao.Close();
            }

        }

        public List<Model.Servico> SelectById(int id)
        {
            List<Model.Servico> lstServico = new List<Model.Servico>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Servico where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Servico servico = new Model.Servico();
                    servico.id = Convert.ToInt32(dados["id"].ToString());
                    servico.descricao = dados["descricao"].ToString();
                    servico.valorServ = Convert.ToSingle(dados["valorServ"].ToString());
                    lstServico.Add(servico);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Consulta Select de Servico");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstServico;
        }

        public List<Model.Servico> SelectByDescricao(string descricao)
        {
            List<Model.Servico> lstServico = new List<Model.Servico>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Servico where (descricao like @desc);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc", "%" + descricao + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Servico servico = new Model.Servico();
                    servico.id = Convert.ToInt32(dados["id"].ToString());
                    servico.descricao = dados["descricao"].ToString();
                    servico.valorServ = Convert.ToSingle(dados["valorServ"].ToString());
                    lstServico.Add(servico);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Consulta Select de Servico");
            }
            finally
            {
                conexao.Close();
            }
            return lstServico;
        }

    }
}
