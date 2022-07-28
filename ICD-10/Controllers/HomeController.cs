using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ICD_10.Models;
using Application;

namespace ICD_10.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context = new DataContext();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchResult()
        {
            string searchTerm = HttpContext.Request.Form["textbox"].ToString();
            List<BillingCode> listBc = new List<BillingCode>();
            foreach (BillingCode bc in _context.icd10codes)
            {
                if (bc.description.ToLower().Contains(searchTerm.ToLower()))
                {
                    listBc.Add(bc);
                }
            }
            return View(listBc);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
