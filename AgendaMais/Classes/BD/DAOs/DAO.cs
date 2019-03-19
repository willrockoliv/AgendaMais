using AgendaMais.Classes.DAOs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMais.Classes.DAOs
{
    class DAO : DB
    {
        /// <summary>
        /// Estemétodo permite informar um comando específco
        /// </summary>
        /// <param name="command">comando desejado</param>
        /// <returns>DataTable</returns>
        public DataTable DBCommand(string sql )
        {
            return ExecutaSelect(sql);
        }

        /// <summary>
        /// Este método obtém todos os registros da tabela informada;
        /// </summary>
        /// <param name="tabela">Tabela desejada</param>
        /// <returns>DataTable com todos os registros da tabela informada</returns>
        public static DataTable GetTodosRegistros(string tabela)
        {
            string sql = String.Format("Select * from {0} order by id", tabela);
            return ExecutaSelect(sql);
        }

        /// <summary>
        /// Este método obtém todos os registros da tabela informada que estejam ativos;
        /// </summary>
        /// <param name="tabela">Tabela desejada</param>
        /// <returns>DataTable com todos os registros da tabela informada</returns>
        public static DataTable GetTodosRegistrosAtivos(string tabela)
        {
            string sql = String.Format("Select * from {0} where ativo=true order by id", tabela);
            return ExecutaSelect(sql);
        }

        /// <summary>
        /// Este método obtém todos os registros da tabela informada que não estejam ativos;
        /// </summary>
        /// <param name="tabela">Tabela desejada</param>
        /// <returns>DataTable com todos os registros da tabela informada</returns>
        public static DataTable GetTodosRegistrosNaoAtivos(string tabela)
        {
            string sql = String.Format("Select * from {0} where ativo=false order by id", tabela);
            return ExecutaSelect(sql);
        }

        /// <summary>
        /// Neste método obtemos um registro da tabela passada por parâmetro cujo id for igual ao argumento passado ao método.
        /// </summary>
        /// <param name="tabela">Tabela desejada</param>
        /// <param name="id">Id do registro desejado</param>
        /// <returns>DataTable com o registro com id informado da tabela informada</returns>
        public static DataTable GetRegistroPorId(string tabela, int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", tabela, id);
            return ExecutaSelect(sql);
        }

        /// <summary>
        /// Seleciona registros a partir da condição informada por parâmetro
        /// </summary>
        /// <param name="tabela">Tabela desejada</param>
        /// <param name="condicao">Condição where</param>
        /// <returns></returns>
        public static DataTable GetRegistros(string tabela, string condicao)
        {
            string sql = $"Select * from {tabela} {condicao}";
            return ExecutaSelect(sql);
        }


    }
}
