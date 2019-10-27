using BelezaVip.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BelezaVip.Controllers
{
    public class Parser
    {

        public static List<AtendimentoViewModel> LoadViewAtendimento (DataTable dt_) {

            List<AtendimentoViewModel> lista = new List<AtendimentoViewModel>();

            for (int i = 0; i < dt_.Rows.Count; i++)
            {
                lista.Add(new AtendimentoViewModel
                {
                    NomeProfissional = dt_.Rows[i]["nomeProfissional"].ToString(),
                    NomeProcedimento = dt_.Rows[i]["nomeProcedimento"].ToString(),
                    NomeCliente = dt_.Rows[i]["nomeCliente"].ToString(),
                    DataAtendimento = DateTime.Parse(dt_.Rows[i]["dataAtendimento"].ToString()),
                    ValorProcedimento = dt_.Rows[i]["valorDesconto"].ToString(),
                });
            }

            return lista;

        }


    }
}
