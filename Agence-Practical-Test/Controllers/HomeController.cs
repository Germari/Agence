using Agence_Practical_Test.DTO;
using Agence_Practical_Test.Models;
using Agence_Practical_Test.Services;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agence_Practical_Test.Controllers
{
    public class HomeController : Controller
    {
        private  IMySqlService _service;
        public HomeController()
        {
            _service = new MySqlService();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bar_Graf(string coUsuario, string initDate, string finalDate)
        {
            var coUsuarioList = JsonConvert.DeserializeObject<List<string>>(coUsuario);
            DateTime initialD = DateTime.MinValue;
            DateTime finalD = DateTime.MaxValue;
            var parsed = DateTime.TryParse($"1/{initDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out initialD);
            parsed = DateTime.TryParse($"1/{finalDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None, out finalD);
            finalD=finalD.AddDays(DateTime.DaysInMonth(finalD.Year,finalD.Month) - 1);

            List<ConDesemConsultorRel> result = new List<ConDesemConsultorRel>();
            if (coUsuarioList == default)
                return PartialView(result);
            

            foreach (var item in coUsuarioList)
            {
                result.Add(_service.GetConDesemConsultorRel(item,initialD,finalD).Result);
            }
            return PartialView(result);
        }
        public ActionResult Pizza_Graf(string coUsuario, string initDate, string finalDate)
        {
            List<ConDesemConsultorRel> result = new List<ConDesemConsultorRel>();
            if (coUsuario==null)
            return PartialView(result);
        var coUsuarioList = JsonConvert.DeserializeObject<List<string>>(coUsuario);

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
            return PartialView(result);
        }

        public ActionResult Con_desempenho()
        {

            var consultores= _service.GetConsultores().Result;
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
        public ActionResult _Con_desempenho(List<string> coUsuario,string initDate, string finalDate)
        {
                DateTime initialD = DateTime.MinValue;
                DateTime finalD = DateTime.MaxValue;
               var parsed= DateTime.TryParse($"1/{initDate}", new System.Globalization.CultureInfo("Pt"),System.Globalization.DateTimeStyles.None, out initialD);
               parsed= DateTime.TryParse($"1/{finalDate}", new System.Globalization.CultureInfo("Pt"), System.Globalization.DateTimeStyles.None,out finalD);
                finalD=finalD.AddDays(DateTime.DaysInMonth(finalD.Year,finalD.Month) - 1);

                List<ConDesemConsultorRel> result = new List<ConDesemConsultorRel>();
                if(coUsuario== default)
                    return PartialView(result);

                foreach (var item in coUsuario)
                {
                    result.Add(_service.GetConDesemConsultorRel(item,initialD,finalD).Result);
                }
                return PartialView(result);
        }
        [HttpPost]
        public ActionResult _Con_desem_consultor_graf(List<string> coUsuario,string initDate, string finalDate)
        {
            ViewBag.CoUsuario = coUsuario;
            ViewBag.InitDate = initDate;
            ViewBag.FinalDate = finalDate;

            return PartialView();
        }
        [HttpPost]
        public ActionResult _Con_desem_consultor_pizza(List<string> coUsuario, string initDate, string finalDate)
        {
            ViewBag.CoUsuario = coUsuario;
            ViewBag.InitDate = initDate;
            ViewBag.FinalDate = finalDate;

            return PartialView();
        }
    }
   


}