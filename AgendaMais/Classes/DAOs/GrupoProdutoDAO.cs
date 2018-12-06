using AgendaMais.Classes.VOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.DAOs
{
    class GrupoProdutoDAO : DAO
    {
        static GrupoProdutoVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                GrupoProdutoVO grupoProdutoVO = new GrupoProdutoVO();
                grupoProdutoVO.Id = Convert.ToInt32(row["id"]);
                grupoProdutoVO.Descricao = row["nome"].ToString();
                return grupoProdutoVO;
            }
            else
                return null;
        }

        static List<GrupoProdutoVO> MontaListVO(DataTable table)
        {
            if (table != null)
            {
                List<GrupoProdutoVO> listGrupoProdutoVO = new List<GrupoProdutoVO>();
                for (int i = 0; i < table.Rows.Count; i++)
                    listGrupoProdutoVO.Add(MontaVO(table.Rows[i]));
                return listGrupoProdutoVO;
            }
            else
                return null;
        }

        public static List<GrupoProdutoVO> GetTodosRegistros()
        {
            return MontaListVO(DAO.GetTodosRegistros("grupo_produto"));
        }

        public static GrupoProdutoVO GetRegistroPorId(int id)
        {
            return MontaVO(DAO.GetRegistroPorId("grupo_produto", id).Rows[0]);
        }

        public static List<GrupoProdutoVO> GetRegistros(string condicao)
        {
            return MontaListVO(DAO.GetRegistros("grupo_produto", condicao));
        }

        public static void InserirRegistros(GrupoProdutoVO grupo_produto)
        {
            string sql = "Insert Into grupo_produto(nome) values('" + grupo_produto.Descricao + "')";
            DAO.ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(GrupoProdutoVO grupo_produto)
        {
            string sql = "UPDATE grupo_produto SET " +
                            "descricao='" + grupo_produto.Descricao + "'" +
                          "WHERE id=" + grupo_produto.Id;
            DAO.ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            List<ProdutoVO> listProdutoVO = ProdutoDAO.GetRegistrosPorGrupo(id);
            int id_produto;
            string sql_delete_item_venda = "delete from item_venda where id_produto in (";
            string sql_delete_produtos = "delete from produto where id in (";
            for (int i = 0; i < listProdutoVO.Count; i++)
            {
                id_produto = listProdutoVO[i].Id;

                if (i == listProdutoVO.Count - 1)
                {
                    sql_delete_item_venda += id_produto + ")";
                    sql_delete_produtos += id_produto + ")";
                    break;
                }

                sql_delete_item_venda += id_produto + ",";
                sql_delete_produtos += id_produto + ",";
            }

            List<string> sql = new List<string>();
            sql.Add(sql_delete_item_venda);
            sql.Add(sql_delete_produtos);
            sql.Add($"DELETE grupo_produto WHERE id={id}");
            DAO.ExecutaSQL(sql);
        }
    }
}
