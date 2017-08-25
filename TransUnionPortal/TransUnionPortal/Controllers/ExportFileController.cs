using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TransUnionPortal.Models;
using TransUnionPortal.Repositories;
using TransUnionPortal.Utils;

namespace TransUnionPortal.Controllers
{
    public class ExportFileController : Controller
    {
        // GET: ExportFile
        public ActionResult Index()
        {
            ConfigurationFile model = new ExportFileRepository().GetIndexModel();
            var encabezado = new Encabezado();
            var pie = new Pie();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ConfigurationFile configurationFile)
        {

            return View();
        }

        [HttpPost]
        public FileContentResult Generate(ConfigurationFile configurationFile)
        {
            //before your loop
            var csv = new StringBuilder();
            //Suggestion made by KyleMit
            var newLine = string.Format("{0},{1},{2}", "id", "archivo", "tipo");
            csv.AppendLine(newLine);
            
            //after your loop
            return File( Encoding.ASCII.GetBytes(csv.ToString()), "text/csv", "prueba.csv");
        }
    }
}