﻿using AgendaMais.Classes.VOs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.DAOs
{
    class ProdutoDAO : DB
    {
        static ProdutoVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                ProdutoVO produtoVO = new ProdutoVO();
                produtoVO.Id = Convert.ToInt32(row["id"]);
                produtoVO.Descricao = row["descricao"].ToString();
                produtoVO.Cod_barras = row["cod_barras"].ToString();
                produtoVO.Vl_custo = Convert.ToDouble(row["vl_custo"]);
                produtoVO.Vl_venda = Convert.ToDouble(row["vl_venda"]);
                produtoVO.Qtd_estoque = Convert.ToInt32(row["qtd_estoque"]);
                produtoVO.Id_grupo_produto = Convert.ToInt32(row["id_grupo_produto"]);
                produtoVO.Controla_estoque = Convert.ToBoolean(row["controla_estoque"]);
                produtoVO.Ativo = Convert.ToBoolean(row["ativo"]);
                return produtoVO;
            }
            else
                return null;
        }

        static List<ProdutoVO> MontaListVO(DataTable table)
        {
            if (table != null)
            {
                List<ProdutoVO> listProdutos = new List<ProdutoVO>();

                for (int i = 0; i < table.Rows.Count; i++)
                    listProdutos.Add(MontaVO(table.Rows[i]));

                return listProdutos;
            }
            else
                return null;
        }

        public static List<ProdutoVO> GetTodosRegistrosAtivos()
        {
            return MontaListVO(DAO.GetTodosRegistrosAtivos("produto"));
        }

        public static List<ProdutoVO> GetTodosRegistrosNaoAtivos()
        {
            return MontaListVO(DAO.GetTodosRegistrosNaoAtivos("produto"));
        }

        public static List<ProdutoVO> GetTodosRegistros()
        {
            return MontaListVO(DAO.GetTodosRegistros("produto"));
        }

        public static ProdutoVO GetRegistroPorId(int id)
        {
            return MontaVO(DAO.GetRegistroPorId("produto", id).Rows[0]);
        }

        public static List<ProdutoVO> GetRegistros(string condicao)
        {
            return MontaListVO(DAO.GetRegistros("produto", condicao));
        }

        public static List<ProdutoVO> GetRegistrosAtivosPorGrupo(int id_grupo_produto)
        {
            return MontaListVO(DAO.GetRegistros("produto", $"where id_grupo_produto={id_grupo_produto} and ativo=true"));
        }

        public static List<ProdutoVO> GetRegistrosNaoAtivosPorGrupo(int id_grupo_produto)
        {
            return MontaListVO(DAO.GetRegistros("produto", $"where id_grupo_produto={id_grupo_produto} and ativo=false"));
        }

        public static List<ProdutoVO> GetRegistrosPorGrupo(int id_grupo_produto)
        {
            return MontaListVO(DAO.GetRegistros("produto", $"where id_grupo_produto={id_grupo_produto}"));
        }

        public static void InserirRegistros(ProdutoVO produto)
        {
            string sql = "Insert Into produto(" +
                            "descricao, " +
                            "cod_barras, " +
                            "vl_custo, " +
                            "vl_venda, " +
                            "qtd_estoque, " +
                            "id_grupo_produto, " +
                            "controla_estoque," +
                            "ativo) " +
                          "values(" +
                            $"'{produto.Descricao}'," +
                            $"'{produto.Cod_barras}'," +
                            $"{produto.Vl_custo.ToString().Replace(',', '.')}," +
                            $"{produto.Vl_venda.ToString().Replace(',', '.')}," +
                            $"{produto.Qtd_estoque}," +
                            $"{produto.Id_grupo_produto}," +
                            $"{produto.Controla_estoque}," +
                            $"{produto.Ativo})";
            DAO.ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(ProdutoVO produto)
        {
            string sql = "UPDATE produto SET " +
                            $"descricao='{produto.Descricao}'," +
                            $"cod_barras='{produto.Cod_barras}'," +
                            $"vl_custo={produto.Vl_custo.ToString().Replace(',', '.')}," +
                            $"vl_venda={produto.Vl_venda.ToString().Replace(',', '.')}," +
                            $"qtd_estoque={ produto.Qtd_estoque}," +
                            $"id_grupo_produto={produto.Id_grupo_produto}," +
                            $"controla_estoque={produto.Controla_estoque}," +
                            $"ativo={produto.Ativo} " +
                         $"WHERE id={produto.Id}";
            DAO.ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            //List<string> sql = new List<string>();
            //sql.Add($"DELETE from item_venda WHERE id_produto={id}");
            //sql.Add($"DELETE from produto WHERE id={id}");
            //DAO.ExecutaSQL(sql);
            ExecutaSelect($"UPDATE produto SET ativo={false} WHERE id={id}");
        }
    }
}
