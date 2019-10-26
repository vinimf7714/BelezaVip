using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BelezaVip.Persistance
{
    public class SQLConnection
    {

        private const String stringConnection = "Server=DESKTOP-I2SB66K;Database=BelezaVip;Integrated Security=true";

        public DbConnection GetConnection()
        {
            DbConnection connection = new SqlConnection(stringConnection);
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public DbCommand GetCommand(DbConnection connection, string commandText, CommandType commandType)
        {
            SqlCommand command = new SqlCommand(commandText, connection as SqlConnection);
            command.CommandType = commandType;
            return command;
        }

        public DbDataReader ExecuteDataReader(List<DbParameter> listaParametros_, String procedure_)
        {
            DbDataReader dataReader;
            CommandType commandType = CommandType.StoredProcedure;

            try
            {
                DbConnection conn = GetConnection();
                DbCommand command = GetCommand(conn, procedure_, commandType);


                if (listaParametros_ != null && listaParametros_.Count > 0)
                {
                    command.Parameters.AddRange(listaParametros_.ToArray());
                }

                dataReader = command.ExecuteReader();

            }
            catch (Exception e)
            {

                throw;
            }


            return dataReader;

        }
    }
}
