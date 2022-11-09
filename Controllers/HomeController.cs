using Agence_Practical_Test.Infrastructure;
using Agence_Practical_Test.Models;
using Agence_Practical_Test.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

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
            var client = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request = new RestRequest(Method.Post.ToString());
            var body =JsonConvert.SerializeObject(new {Method="Con_desempenho" });
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

            var consultores = _service.GetConsultores().Result;
            ViewBag.Message = "Desempenho";
            return View(consultores);
        }
        public ActionResult Con_desempenho_aba_cliente()
        {
            var client = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request = new RestRequest(Method.Post.ToString());
            var body = JsonConvert.SerializeObject(new { Method = "Con_desempenho_aba_cliente" });
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

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
            var client2 = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request2 = new RestRequest(Method.Post.ToString());
            var body2 = JsonConvert.SerializeObject(new { month = new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.AbbreviatedMonthNames.ToList().IndexOf(initDate.Split("/")[0].ToLower()+"."), list = new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.AbbreviatedMonthNames.ToList(), parsed= DateTime.TryParse($"1/{new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.AbbreviatedMonthNames.ToList().IndexOf(initDate.Split("/")[0].ToLower() + ".")}/{initDate.Split(" / ")[1]}", out _) });
            request2.AddParameter("application/json", body2, ParameterType.RequestBody);
            RestResponse response2 = client2.Execute(request2);

            DateTime initialD = DateTime.MinValue;
            DateTime finalD = DateTime.MaxValue;
            var parsed = DateTime.TryParse($"1/{new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.AbbreviatedMonthNames.ToList().IndexOf(initDate.Split("/")[0].ToLower() + ".")}/{initDate.Split(" / ")[1]}", out initialD);
            parsed = DateTime.TryParse($"1/{initDate.Split(" / ")[0]}/{new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.AbbreviatedMonthNames.ToList().IndexOf(initDate.Split("/")[1].ToLower() + ".")}", out finalD);
            finalD = finalD.AddDays(DateTime.DaysInMonth(finalD.Year, finalD.Month) - 1);

            var client = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request = new RestRequest(Method.Post.ToString());
            var body = JsonConvert.SerializeObject(new { initialD,finalD });
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);

            var client1 = new RestClient("https://webhook.site/4ac0dd1e-0b8f-42da-aaf9-d44aa828f06d");
            var request1 = new RestRequest(Method.Post.ToString());
            var body1 = JsonConvert.SerializeObject(new System.Globalization.CultureInfo("pt-BR").NumberFormat ) ;
            request1.AddParameter("application/json", body1, ParameterType.RequestBody);
            RestResponse response1 = client1.Execute(request1);
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
