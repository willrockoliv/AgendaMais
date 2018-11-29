using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes
{
    class LayoutProdutos
    {
        public static string[] LayoutProduto(DataTable Produtos)
        {
            #region Variáveis
            string[] temp = new string[2];
            int cont = 0;
            int qtdEspacos;
            string[] layout = new string[Produtos.Rows.Count];
            #endregion

            foreach (DataRow row in Produtos.Rows)
            {
                //Descrição
                temp[0] = row["descricao"].ToString();

                if (temp[0].Trim().Length >= 38)
                    temp[0] = temp[0].Substring(0, 38);
                else
                {
                    qtdEspacos = 38 - temp[0].Length;
                    for (int j = 0; j < qtdEspacos; j++)
                    {
                        temp[0] = temp[0] + " ";
                    }
                }

                //Valor de Venda
                temp[1] = row["vl_venda"].ToString();

                layout[cont++] = temp[0] + " R$" + temp[1];
            }
            return layout;
        }

        public static string LayoutProduto(DataRow Produto)
        {
            #region Variáveis
            string[] temp = new string[2];
            int qtdEspacos;
            string layout;
            #endregion

            //Descrição
            temp[0] = Produto["descricao"].ToString();

            if (temp[0].Trim().Length >= 38)
                temp[0] = temp[0].Substring(0, 38);
            else
            {
                qtdEspacos = 38 - temp[0].Length;
                for (int j = 0; j < qtdEspacos; j++)
                {
                    temp[0] = temp[0] + " ";
                }
            }

            //Valor de Venda
            temp[1] = Produto["vl_venda"].ToString();

            layout = temp[0] + " R$" + temp[1];

            return layout;
        }
    }
}
