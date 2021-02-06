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

        public ActionResult Counter()
        {
            return View();
        }

        public ActionResult GetTotalDeaths(string NombreInvocador, string Servidor)
        {
            var placeholder = 0;
            return Json(placeholder);
        }
    }
}
