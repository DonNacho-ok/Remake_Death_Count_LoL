using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remake_LoL_Death_Counter.Controllers
{
    public class CounterController : Controller
    {
        const string RiotApiKey = "";

        public ActionResult Contador()
        {
            return View();
        }

        [HttpGet]
        public string GetTotalDeaths(string NombreInvocador, string Servidor)
        {
            var resultado = " ";

            if (NombreInvocador != "" && Servidor != "" )
            {
                resultado = "Todo OK";
            }
            else
            {
                resultado = "algo pasó... a debuggear";
            }

            return resultado;
            
        }
    }
}
