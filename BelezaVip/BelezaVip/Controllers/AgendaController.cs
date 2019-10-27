using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BelezaVip.Models;
using BelezaVip.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace BelezaVip.Controllers
{
    public class AgendaController : Controller
    {

        private int item_ = -1;

        public IActionResult Index()
        {
            var model_ = FindAtendimento();
            return View(model_);
        }

        public List<AtendimentoViewModel> InitListDefault(DateTime data_)
        {
            int day = data_.Day;
            int month = data_.Month;
            int year = data_.Year;
            int hour = 9;
            int min = 0;
            

            List<Profissional> profissionais = new List<Profissional>();
            profissionais.Add(
                new Profissional()
                {
                    idProfissional = 1,
                    nomeProfissional = "Thais",
                    
                });

            profissionais.Add(
                new Profissional()
                {
                    idProfissional = 2,
                    nomeProfissional = "Aline"
                });

            profissionais.Add(
               new Profissional()
               {
                   idProfissional = 3,
                   nomeProfissional = "Simone"
               });


            DateTime dt;
            List<AtendimentoViewModel> lista = new List<AtendimentoViewModel>();

            for (int x = 0; x < profissionais.Count; x++)
            {
                dt = new DateTime(year, month, day, hour, min, 0);

                for (int i = 0; i < 21; i++)
                {
                    lista.Add(new AtendimentoViewModel()
                    {
                        NomeProfissional = profissionais[x].nomeProfissional,
                        IdProfissional = profissionais[x].idProfissional.ToString(),
                        NomeCliente = "VAGO",
                        DataAtendimento = dt
                    });
                    dt = dt.AddMinutes(30.0);
                }

            }
            return lista;
        }

        public Boolean CompareHour(DateTime dt1, DateTime dt2)
        {
            Boolean ret = false;

            string hour1 = dt1.ToString("%h m");
            string hour2 = dt2.ToString("%h m");

            if (string.Equals(hour1, hour2))
            {
                ret = true;
            }

            return ret;
        }

        public List<AtendimentoViewModel> FindAtendimento()
        {
            AtendimentoDao dao = new AtendimentoDao();
            DataTable dt = dao.FindAtendimento();
            //List<AtendimentoViewModel> lista = new List<AtendimentoViewModel>(Parser.LoadViewAtendimento(dt));
            DateTime date = DateTime.Now;
            List<AtendimentoViewModel> retorno = InitListDefault(date);

            var ListAtendimento = dt.AsEnumerable()
                .Select(y =>
                new
                {
                    DataAtendimento = y.Field<DateTime>("dataAtendimento"),
                    NomeCliente = y.Field<String>("nomeCliente"),
                    NomeProfissional = y.Field<String>("nomeProfissional"),
                    IdProfissional = y.Field<Int32>("idProfissional").ToString()

                }).GroupBy(x => x.NomeProfissional).Select(z => z.ToList())
                .ToList();

            for (int i = 0; i < ListAtendimento.Count(); i++)
            {
                for (int x = 0; x < ListAtendimento[i].Count; x++)
                {
                    AtendimentoViewModel item = new AtendimentoViewModel
                    {
                        NomeProfissional = ListAtendimento[i][x].NomeProfissional,
                        NomeCliente = ListAtendimento[i][x].NomeCliente,
                        IdProfissional = ListAtendimento[i][x].IdProfissional,
                        DataAtendimento = ListAtendimento[i][x].DataAtendimento

                        //NomeProcedimento = ListAtendimento[0][i].n,
                        //NomeProcedimento = dt_.Rows[i]["nomeProcedimento"].ToString(),
                        //NomeCliente = dt_.Rows[i]["nomeCliente"].ToString(),
                        //DataAtendimento = DateTime.Parse(dt_.Rows[i]["dataAtendimento"].ToString()),
                        //ValorProcedimento = Double.Parse(dt_.Rows[i]["valorDesconto"].ToString())
                    };

                    item_ = retorno.FindIndex(f => string.Equals(f.NomeProfissional, item.NomeProfissional)
                            && CompareHour(f.DataAtendimento, item.DataAtendimento)
                        );

                    if (item_ != -1)
                    {
                        retorno.RemoveAt(item_);
                        retorno.Add(item);
                    }
                }
            }
            return retorno.OrderBy(x => x.DataAtendimento).ToList();
        }
    }
}