using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salao.Relatorio
{
    class relVenda
    {
        public static void impRelVenda()
        {
            Camadas.BLL.Venda bllVend = new Camadas.BLL.Venda();
            List<Camadas.Model.Venda> listaVenda = new List<Camadas.Model.Venda>();
            listaVenda = bllVend.Select();

            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelVenda.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h2 class='display-4'>Relatório de Venda</h1>");
                sw.WriteLine("<br/>");
                sw.WriteLine("<table class='table table-sm table-striped'>");
                sw.WriteLine("<thead class='thead-dark'>");
                sw.WriteLine("<tr scope='row'>");
                sw.WriteLine("<th scope='col'>ID</th>");
                sw.WriteLine("<th scope='col'>Data</th>");
                sw.WriteLine("<th scope='col'>Cliente</th>");
                sw.WriteLine("<th scope='col'>Nome</th>");
                sw.WriteLine("<th scope='col'>Servico</th>");
                sw.WriteLine("<th scope='col'>Descricao</th>");
                sw.WriteLine("<th scope='col'>ValorServ</th>");
                sw.WriteLine("<th scope='col'>Produto</th>");
                sw.WriteLine("<th scope='col'>NomeProd</th>");
                sw.WriteLine("<th scope='col'>Quantidade</th>");
                sw.WriteLine("<th scope='col'>ValorProd</th>");
                sw.WriteLine("<th scope='col'>Total</th>");
                sw.WriteLine("</tr>");
                sw.WriteLine("</thead>");

                int cont = 0;
                float somaGeral = 0;

                foreach (Camadas.Model.Venda venda in listaVenda)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr scope='row'>");
                    else
                        sw.WriteLine("<tr scope='row'>");
                    sw.WriteLine("<td scope='col'>" + venda.id + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.data + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.cliente + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.nome + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.servico + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.descricao + "</td>");
                    sw.WriteLine("<td scope='col'>" + string.Format("{0:C2}", venda.valorServ) + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.produto + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.nomeProd + "</td>");
                    sw.WriteLine("<td scope='col'>" + venda.quantidade + "</td>");
                    sw.WriteLine("<td scope='col'>" + string.Format("{0:C2}", venda.valorProd) + "</td>");
                    somaGeral = somaGeral + venda.total;
                    sw.WriteLine("<td scope='col'>" + string.Format("{0:C2}", venda.total) + "</td>");
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
