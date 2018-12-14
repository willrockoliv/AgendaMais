using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.VOs
{
    public class ProdutoVO
    {
        private int id;
        private string descricao;
        private string cod_barras;
        private double vl_custo;
        private double vl_venda;
        private int qtd_estoque;
        private int id_grupo_produto;
        private bool controla_estoque;

        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new Exception("id não pode ser menor ou igual a zero");
                else
                    id = value;
            }
        }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Cod_barras { get => cod_barras; set => cod_barras = value; }
        public double Vl_custo
        {
            get => Math.Round(vl_custo, 2);
            set
            {
                if (value < 0)
                    throw new Exception("Valor de Custo não pode ser negativo");
                else
                    vl_custo = Math.Round(value, 2);
            }
        }
        public double Vl_venda
        {
            get => Math.Round(vl_venda, 2);
            set
            {
                if (value < 0)
                    throw new Exception("Valor de Venda não pode ser negativo");
                else
                    vl_venda = Math.Round(value, 2);
            }
        }
        public int Qtd_estoque
        {
            get => qtd_estoque; set
            {
                if (value < 0)
                    throw new Exception("Quantidade em estoque não pode ser negativo");
                else
                    qtd_estoque = value;
            }
        }
        public int Id_grupo_produto
        {
            get => id_grupo_produto; set
            {
                if (value <= 0)
                    throw new Exception("id do grupo de produto não pode ser menor ou igual a zero");
                else
                    id_grupo_produto = value;
            }
        }
        public bool Controla_estoque { get => controla_estoque; set => controla_estoque = value; }
    }
}
