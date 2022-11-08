﻿using Agence_Practical_Test.Infrastructure;
using Agence_Practical_Test.Models;
using Agence_Practical_Test.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Practical_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMySqlService _service;

        public HomeController(ILogger<HomeController> logger, IMySqlService service)
        {
            _logger = logger;
            _service = service;

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Con_desempenho()
        {

            var consultores = _service.GetConsultores().Result;
            ViewBag.Message = "Desempenho";
            return View(consultores);
        }
        public ActionResult Con_desempenho_aba_cliente()
        {

            var clientes = _service.GetClientes().Result;
            ViewBag.Message = "Desempenho";
            return View(clientes);
        }

        public ActionResult _Con_desempenho_aba_client()
        {

            return PartialView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coUsuario"></param>
        /// <param name="initDate"></param>
        /// <param name="finalDate"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult _Con_desempenho(List<string> coUsuario, string initDate, string finalDate)
        {
            DateTime initialD = DateTime.MinValue;
            DateTime finalD = DateTime.MaxValue;
            var parsed = DateTime.TryParse($"1/{initDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out initialD);
            parsed = DateTime.TryParse($"1/{finalDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out finalD);
            finalD = finalD.AddDays(DateTime.DaysInMonth(finalD.Year, finalD.Month) - 1);

            List<ConDesemConsultorRel> result = new List<ConDesemConsultorRel>();
            if (coUsuario == default)
                return PartialView(result);

            foreach (var item in coUsuario)
            {
                result.Add(_service.GetConDesemConsultorRel(item, initialD, finalD).Result);
            }
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult _Con_desem_consultor_graf(List<string> coUsuario, string initDate, string finalDate)
        {
            DateTime initialD = DateTime.MinValue;
            DateTime finalD = DateTime.MaxValue;
            var parsed = DateTime.TryParse($"1/{initDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out initialD);
            parsed = DateTime.TryParse($"1/{finalDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out finalD);
            finalD = finalD.AddDays(DateTime.DaysInMonth(finalD.Year, finalD.Month) - 1);

            List<ConDesemConsultorRel> result = new List<ConDesemConsultorRel>();
            if (coUsuario == default)
                return PartialView(result);

            foreach (var item in coUsuario)
            {
                result.Add(_service.GetConDesemConsultorRel(item, initialD, finalD).Result);
            }
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult _Con_desem_consultor_pizza(List<string> coUsuario, string initDate, string finalDate)
        {
           
            List<ConDesemConsultorRel> result = new List<ConDesemConsultorRel>();
            if (coUsuario == null)
                return PartialView(result);
            var coUsuarioList =coUsuario;

            DateTime initialD = DateTime.MinValue;
            DateTime finalD = DateTime.MaxValue;
            var parsed = DateTime.TryParse($"1/{initDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out initialD);
            parsed = DateTime.TryParse($"1/{finalDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out finalD);
            finalD = finalD.AddDays(DateTime.DaysInMonth(finalD.Year, finalD.Month) - 1);

            if (coUsuarioList == default)
                return PartialView(result);

            foreach (var item in coUsuarioList)
            {
                result.Add(_service.GetConDesemConsultorRel(item, initialD, finalD).Result);
            }
            List<string> xvalue= new List<string>();
            foreach (var item in result)
            {
                item.Values.Where(x=>xvalue.Count(v=>v==x.Periodo)==0).ToList().ForEach(X => xvalue.Add(X.Periodo));
            }
            ViewBag.DataSet = new object[]{ new { label=result[0].Name,data = result[0].Values.Select<ConDesemConsultorValue, float>(x => x.ReceitaLiquida).ToList() , } };
            ViewBag.XValue = xvalue;
            ViewBag.InitDate = initDate;
            ViewBag.FinalDate = finalDate;

            return PartialView(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}