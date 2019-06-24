using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Salao.Camadas.DAL
{
    public class Venda
    {

        private string strCon = Conexao.getConexao();

        public List<Model.Venda> Select()
        {
            List<Model.Venda> listaVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select Venda.id, Venda.data, Venda.cliente, Cliente.nome, Venda.servico, Servico.descricao, Servico.valorServ, Venda.produto, Produto.nomeProd, Venda.quantidade, Produto.valorProd from Venda inner join Cliente on Venda.cliente = Cliente.id inner join Servico on Venda.servico = Servico.id inner join Produto on Venda.produto = Produto.id";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.id = Convert.ToInt32(dados["id"].ToString());
                    venda.data = Convert.ToDateTime(dados["data"].ToString());
                    venda.cliente = Convert.ToInt32(dados["cliente"].ToString());
                    venda.nome = dados["nome"].ToString();
                    venda.servico = Convert.ToInt32(dados["servico"].ToString());
                    venda.descricao = dados["descricao"].ToString();
                    venda.valorServ = Convert.ToSingle(dados["valorServ"].ToString());
                    venda.produto = Convert.ToInt32(dados["produto"].ToString());
                    venda.nomeProd = dados["nomeProd"].ToString();
                    venda.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    venda.valorProd = Convert.ToSingle(dados["valorProd"].ToString());
                    listaVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Select da Venda");
            }
            finally
            {
                conexao.Close();
            }

            return listaVenda;
        }

        public void Insert(Camadas.Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Venda values (@data, @cliente, @servico, @produto, @quantidade)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", venda.data);
            cmd.Parameters.AddWithValue("@cliente", venda.cliente);
            cmd.Parameters.AddWithValue("@servico", venda.servico);
            cmd.Parameters.AddWithValue("@produto", venda.produto);
            cmd.Parameters.AddWithValue("@quantidade", venda.quantidade);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - insert da Venda");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Venda set data=@data, cliente=@cliente, servico=@servico, produto=@produto, quantidade=@quantidade where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", venda.id);
            cmd.Parameters.AddWithValue("@data", venda.data);
            cmd.Parameters.AddWithValue("@cliente", venda.cliente);
            cmd.Parameters.AddWithValue("@servico", venda.servico);
            cmd.Parameters.AddWithValue("@produto", venda.produto);
            cmd.Parameters.AddWithValue("@quantidade", venda.quantidade);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - Update da Venda");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Venda where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("Erro - Delete da Venda");
            }
            finally
            {
                conexao.Close();
            }

        }
        public List<Model.Venda> SelectById(int id)
        {
            List<Model.Venda> listaVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select Venda.id, Venda.data, Venda.cliente, Cliente.nome, Venda.servico, Servico.descricao, Servico.valorServ, Venda.produto, Produto.nomeProd, Venda.quantidade, Produto.valorProd from Venda inner join Cliente on Venda.cliente = Cliente.id inner join Servico on Venda.servico = Servico.id inner join Produto on Venda.produto = Produto.id where Venda.id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.id = Convert.ToInt32(dados["id"].ToString());
                    venda.data = Convert.ToDateTime(dados["data"].ToString());
                    venda.cliente = Convert.ToInt32(dados["cliente"].ToString());
                    venda.nome = dados["nome"].ToString();
                    venda.servico = Convert.ToInt32(dados["servico"].ToString());
                    venda.descricao = dados["descricao"].ToString();
                    venda.valorServ = Convert.ToSingle(dados["valorServ"].ToString());
                    venda.produto = Convert.ToInt32(dados["produto"].ToString());
                    venda.nomeProd = dados["nomeProd"].ToString();
                    venda.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    venda.valorProd = Convert.ToSingle(dados["valorProd"].ToString());
                    listaVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Consulta Select de Venda");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return listaVenda;
        }
    }
}
