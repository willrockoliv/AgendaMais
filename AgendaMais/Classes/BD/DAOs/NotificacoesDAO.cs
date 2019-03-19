using AgendaMais.Classes.BD.VOs;
using AgendaMais.Classes.DAOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.BD.DAOs
{
    class NotificacoesDAO
    {
        static NotificacoesVO MontaVO(DataRow row)
        {
            if (row != null)
            {
                NotificacoesVO notificacoesVO = new NotificacoesVO();
                notificacoesVO.Id = Convert.ToInt32(row["id"]);
                notificacoesVO.Descricao = row["descricao"].ToString();
                notificacoesVO.Chamar_tela = row["chamar_tela"].ToString();
                notificacoesVO.Visualizado = Convert.ToBoolean(row["visualizado"]);

                return notificacoesVO;
            }
            else
                return null;
        }

        static List<NotificacoesVO> MontaListVO(DataTable table_notificacoes)
        {
            if (table_notificacoes != null)
            {
                List<NotificacoesVO> listNotificacoesVO = new List<NotificacoesVO>();

                for (int i = 0; i < table_notificacoes.Rows.Count; i++)
                    listNotificacoesVO.Add(MontaVO(table_notificacoes.Rows[i]));

                return listNotificacoesVO;
            }
            else
                return null;
        }

        public static int ProximoId()
        {
            return DB.ProximoID("notificacoes");
        }

        public static List<NotificacoesVO> GetTodosRegistros()
        {
            string sql = "SELECT * FROM notificacoes order by id";
            return MontaListVO(DAO.ExecutaSelect(sql));
        }

        public static void InserirRegistros(NotificacoesVO notificacoesVO)
        {
            string sql = "INSERT INTO notificacoes(" +
                            "id," +
                            "descricao," +
                            "chamar_tela," +
                            "visualizado) " +
                         "VALUES (" +
                           $"{notificacoesVO.Id}," +
                           $"'{notificacoesVO.Descricao}'," +
                           $"'{notificacoesVO.Chamar_tela}'," +
                           $"{notificacoesVO.Visualizado})";
            DB.ExecutaSQL(sql);
        }

        public static void AtualizarRegistro(NotificacoesVO notificacoesVO)
        {
            string sql = "UPDATE notificacoes SET " +
                            $"descricao='{notificacoesVO.Descricao}', " +
                            $"chamar_tela='{notificacoesVO.Chamar_tela}', " +
                            $"visualizado={notificacoesVO.Visualizado} " +
                         "WHERE " +
                            $"id={notificacoesVO.Id}";
            DB.ExecutaSQL(sql);
        }

        public static void DeletarRegistro(int id)
        {
            string sql = String.Format($"Delete From notificacoes Where id={id}");
            DB.ExecutaSQL(sql);
        }
    }
}
