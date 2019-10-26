using BelezaVip.Models;
using BelezaVip.Persistance.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BelezaVip.Persistance
{
    public class AtendimentoDao : SQLConnection
    {

        public DataTable FindAtendimento()
        {
            DataTable dt = new DataTable();
            var result = base.ExecuteDataReader(null, StoredProcedure.SpFindAtendimentos);
            dt.Load(result);
            return dt;
        }


        public DataTable FindProcedimento(String nmProcedimento)
        {

            DataTable dt = new DataTable();

            List<DbParameter> listaParametros_ = new List<DbParameter>();

            DbParameter item = new SqlParameter();
            item.ParameterName = "@nmProcedimento";
            item.DbType = DbType.String;
            item.Value = nmProcedimento;

            listaParametros_.Add(item);


            var result = base.ExecuteDataReader(listaParametros_, StoredProcedure.spFindProcedimentos);

            dt.Load(result);

            return dt;

        }


    }
}
