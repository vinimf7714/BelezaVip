using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BelezaVip.Models;
using BelezaVip.Persistance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelezaVip.Controllers
{
    public class CadAtendimentoController : Controller
    {
        public JsonResult CriarAtendimento(AtendimentoViewModel model_)
        {

            var res = "Sucess";

            return Json(res);
        }

        public IActionResult Index()
        {

            return View();
        }

        public class Procedimentos
        {
            public int Id { get; set; }
            public String NomeProcedimento { get; set; }
        }

        public JsonResult FindValorProcedimento(String NomeProcedimento_)   {

            String x = "20";

            return Json(x);

        }

        [HttpPost]
        public JsonResult AutoComplete(String prefixText_, String idDiv_)
        {
            List<Procedimentos> result = new List<Procedimentos>();

            switch (idDiv_)
            {
                case "NomeProcedimento":
                    result = ListaProcedimento(prefixText_);
                    break;

                default:
                    break;
            }


            return Json(result);
        }


        public List<Procedimentos> ListaProcedimento(String prefixText_)
        {

            AtendimentoDao atendimentoDao = new AtendimentoDao();
            DataTable dt = new DataTable();
            var lista = new List<Procedimentos>();

            dt = atendimentoDao.FindProcedimento(prefixText_);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista = new List<Procedimentos>() {

                new Procedimentos { Id = int.Parse(dt.Rows[i]["id"].ToString()), NomeProcedimento = dt.Rows[i]["descricao"].ToString()}};
            }
                       
            return lista;
        }

    }
}