using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Salao.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> listaCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.aniversario = Convert.ToDateTime(dados["aniversario"].ToString());
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.celular = dados["celular"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.numero = dados["numero"].ToString();
                    cliente.bairro = dados["bairro"].ToString();
                    cliente.cidade = dados["cidade"].ToString();
                    cliente.uf = dados["uf"].ToString();
                    cliente.cep = dados["cep"].ToString();
                    listaCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Select do cliente");
            }
            finally
            {
                conexao.Close();
            }

            return listaCliente;
        }

        public void Insert(Camadas.Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values (@nome, @aniversario, @telefone, @celular, @endereco, @numero, @bairro, @cidade, @uf, @cep)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@uf", cliente.uf);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); //Não traz dados só envia dados
            }
            catch
            {
                Console.WriteLine("Erro - insert do cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, aniversario=@aniversario, telefone=@telefone, celular=@celular, endereco=@endereco, numero=@numero, bairro=@bairro, cidade=@cidade, uf=@uf, cep=@cep where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@uf", cliente.uf);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro - Update do cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("Erro - Delete do cliente");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
