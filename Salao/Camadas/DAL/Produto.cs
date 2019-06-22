using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Salao.Camadas.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Produto> Select()
        {
            List<Model.Produto> listaProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produto";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.nomeProd = dados["nomeProd"].ToString();
                    produto.linha = dados["linha"].ToString();
                    produto.marca = dados["marca"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.valorProd = Convert.ToSingle(dados["valorProd"].ToString());
                    listaProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Select do Produto");
            }
            finally
            {
                conexao.Close();
            }

            return listaProduto;
        }

        public void Insert(Camadas.Model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produto values (@nomeProd, @linha, @marca, @quantidade, @valorProd)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@nomeProd", produto.nomeProd);
            cmd.Parameters.AddWithValue("@linha", produto.linha);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@valorProd", produto.valorProd);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - insert do Produto");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.Model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set nomeProd=@nomeProd, linha=@linha, marca=@marca, quantidade=@quantidade, valorProd=@valorProd where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@nomeProd", produto.nomeProd);
            cmd.Parameters.AddWithValue("@linha", produto.linha);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@valorProd", produto.valorProd);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - Update do Produto");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - Delete do Produto");
            }
            finally
            {
                conexao.Close();
            }

        }

        public List<Model.Produto> SelectById(int id)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produto where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.nomeProd = dados["nomeProd"].ToString();
                    produto.linha = dados["linha"].ToString();
                    produto.marca = dados["marca"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.valorProd = Convert.ToSingle(dados["valorProd"].ToString());
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Consulta Select de Produto");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstProduto;
        }

        public List<Model.Produto> SelectByNome(string nomeProd)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produto where (nomeProd like @nomeProd);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomeProd", "%" + nomeProd + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.nomeProd = dados["nomeProd"].ToString();
                    produto.linha = dados["linha"].ToString();
                    produto.marca = dados["marca"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.valorProd = Convert.ToSingle(dados["valorProd"].ToString());
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Consulta Select de Produto");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstProduto;
        }

        public List<Model.Produto> SelectByMarca(string marca)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produto where (marca like @marca);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@marca", "%" + marca + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.nomeProd = dados["nomeProd"].ToString();
                    produto.linha = dados["linha"].ToString();
                    produto.marca = dados["marca"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.valorProd = Convert.ToSingle(dados["valorProd"].ToString());
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Consulta Select de Produto");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstProduto;
        }
    }
}
