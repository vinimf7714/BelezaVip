using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BelezaVip.Models;
using BelezaVip.Persistance;
using BelezaVip.Persistance.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelezaVip.Controllers
{

    //[Authorize]
    public class AtendimentoController : Controller
    {

        // GET: Atendimento
        public ActionResult Index()
        {
            var model_= FindAtendimento();
            return View(model_);
        }

        public AtendimentoController()
        {
            AtendimentoDao dao = new AtendimentoDao();
        }

        public List<AtendimentoViewModel> FindAtendimento()
        {
            AtendimentoDao dao = new AtendimentoDao();
            DataTable dt = dao.FindAtendimento();
            List<AtendimentoViewModel> lista = new List<AtendimentoViewModel>(Parser.LoadViewAtendimento(dt));

            return lista;
        }

        

        // GET: Atendimento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Atendimento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Atendimento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Atendimento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Atendimento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Atendimento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Atendimento/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}