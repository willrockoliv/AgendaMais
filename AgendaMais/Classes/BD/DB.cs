using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace AgendaMais.Classes.DAOs
{
    class DB
    {
        public static int ProximoID(string tabela)
        {
            DataTable dataTable = new DataTable();
            string sql = $"select (id + 1) as proximo_id from {tabela} order by id desc limit 1";
            try
            {
                using (var connect = ConnectionDataBase.ConnectionDataBases())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql);
                    cmd.Connection = connect;
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd))
                    {
                        Adpt.Fill(dataTable);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (dataTable.Rows.Count != 0)
                return Convert.ToInt32(dataTable.Rows[0]["proximo_id"]);
            else
                return 1;
        }

        public static DataTable ExecutaSelect(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connect = ConnectionDataBase.ConnectionDataBases())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql);
                    cmd.Connection = connect;
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd))
                    {
                        Adpt.Fill(dataTable);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (dataTable.Rows.Count != 0)
                return dataTable;
            else
                return null;
        }

        public static void ExecutaSQL(string sql)
        {
            try
            {
                using (var connect = ConnectionDataBase.ConnectionDataBases())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("begin");
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();

                    try
                    {
                        cmd = new NpgsqlCommand(sql);
                        cmd.Connection = connect;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        cmd = new NpgsqlCommand("rollback");
                        cmd.Connection = connect;
                        cmd.ExecuteNonQuery();
                        throw ex;
                    }

                    cmd = new NpgsqlCommand("commit");
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExecutaSQL(List<string> list_sql)
        {
            try
            {
                using (var connect = ConnectionDataBase.ConnectionDataBases())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("begin");
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();

                    foreach (string sql in list_sql)
                    {
                        try
                        {
                            cmd = new NpgsqlCommand(sql);
                            cmd.Connection = connect;
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            cmd = new NpgsqlCommand("rollback");
                            cmd.Connection = connect;
                            cmd.ExecuteNonQuery();
                            throw ex;
                        }
                    }

                    cmd = new NpgsqlCommand("commit");
                    cmd.Connection = connect;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
