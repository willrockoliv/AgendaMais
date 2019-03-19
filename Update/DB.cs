using Npgsql;
using System;
using System.Collections.Generic;

namespace Update
{
    class DB
    {
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
