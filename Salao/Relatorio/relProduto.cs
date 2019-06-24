using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Relatorio
{
    public class relProduto
    {
        public static void impRelProduto()
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> listaProduto = new List<Camadas.Model.Produto>();
            listaProduto = bllProd.Select();

            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelProduto.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h2 class='display-4'>Relatório de Produtos</h1>");
                sw.WriteLine("<br/>");
                sw.WriteLine("<table class='table table-sm table-striped'>");
                sw.WriteLine("<thead class='thead-dark'>");
                sw.WriteLine("<tr scope='row'>");
                sw.WriteLine("<th scope='col'>ID</th>");
                sw.WriteLine("<th scope='col'>Nome</th>");
                sw.WriteLine("<th scope='col'>Linha</th>");
                sw.WriteLine("<th scope='col'>Marca</th>");
                sw.WriteLine("<th scope='col'>Quantidade</th>");
                sw.WriteLine("<th scope='col'>Valor</th>");
                sw.WriteLine("<th scope='col'>Total</th>");
                sw.WriteLine("</tr>");
                sw.WriteLine("</thead>");

                int cont = 0;
                float somaGeral = 0;

                foreach (Camadas.Model.Produto produto in listaProduto)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr scope='row'>");
                    else
                        sw.WriteLine("<tr scope='row'>");
                        sw.WriteLine("<td scope='col'>" + produto.id + "</td>");
                        sw.WriteLine("<td scope='col'>" + produto.nomeProd + "</td>");
                        sw.WriteLine("<td scope='col'>" + produto.linha + "</td>");
                        sw.WriteLine("<td scope='col'>" + produto.marca + "</td>");
                        sw.WriteLine("<td scope='col'>" + string.Format("{0:#####}", produto.quantidade) + "</td>");
                        sw.WriteLine("<td scope='col'>" + string.Format("{0:C2}", produto.valorProd) + "</td>");
                        somaGeral = somaGeral + produto.total;
                        sw.WriteLine("<td scope='col'>" + string.Format("{0:C2}", produto.total) + "</td>");
                        sw.WriteLine("</tr>");
                        cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<br/>");
                sw.WriteLine("<h3>Total Geral: " + string.Format("{0:C2}", somaGeral) + "</h2>");
                sw.WriteLine("<h4>Total de Registros impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</head>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
