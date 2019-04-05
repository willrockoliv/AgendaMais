using AgendaMais.Classes.DAOs;
using AgendaMais.Classes.VOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.BD.DAOs
{
    class PessoaDAO : DB
    {
        static PessoaVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                PessoaVO pessoaVO = new PessoaVO();
                pessoaVO.Tipo_pessoa = Convert.ToChar(row["tipo_pessoa"]);
                pessoaVO.Id = Convert.ToInt32(row["id"]);
                pessoaVO.Nome = row["nome"].ToString();
                pessoaVO.Tel_cel = row["tel_cel"].ToString();
                pessoaVO.Email = row["email"].ToString();
                pessoaVO.Recado = row["recado"].ToString();
                pessoaVO.Cpf = row["cpf"].ToString();
                pessoaVO.Rg = row["rg"].ToString();
                pessoaVO.Uf = row["uf"].ToString();
                pessoaVO.Cidade = row["cidade"].ToString();
                pessoaVO.Bairro = row["bairro"].ToString();
                pessoaVO.Endereco = row["endereco"].ToString();
                pessoaVO.Numero = row["numero"].ToString();
                pessoaVO.Complemento = row["complemento"].ToString();
                pessoaVO.Imagem = row["imagem"].ToString();
                pessoaVO.Ativo = Convert.ToBoolean(row["ativo"]);
                return pessoaVO;
            }
            else
                return null;
        }

        static List<PessoaVO> MontaListVO(DataTable table)
        {
            if (table != null)
            {
                List<PessoaVO> listPessoaVO = new List<PessoaVO>();
                for (int i = 0; i < table.Rows.Count; i++)
                    listPessoaVO.Add(MontaVO(table.Rows[i]));
                return listPessoaVO;
            }
            else
                return null;
        }

        public static List<PessoaVO> GetTodosRegistrosAtivos()
        {
            string sql = "Select * from view_pessoa where ativo=true order by tipo_pessoa, id";
            return MontaListVO(ExecutaSelect(sql));
        }

        public static List<PessoaVO> GetTodosRegistrosNaoAtivos()
        {
            string sql = "Select * from view_pessoa where ativo=false order by tipo_pessoa, id";
            return MontaListVO(ExecutaSelect(sql));
        }

        public static List<PessoaVO> GetTodosRegistros()
        {
            string sql = "Select * from view_pessoa order by tipo_pessoa, id";
            return MontaListVO(ExecutaSelect(sql));
        }

        public static PessoaVO GetRegistroPorId(char tipo_pessoa, int id)
        {
            string sql = $"Select * from view_pessoa where tipo_pessoa='{tipo_pessoa}' and id={id}";
            return MontaVO(ExecutaSelect(sql).Rows[0]);
        }

        public static List<PessoaVO> GetRegistros(string condicao)
        {
            return MontaListVO(DAO.GetRegistros("view_pessoa", condicao));
        }
    }
}
