using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TransUnionPortal.Models;
using TransUnionPortal.Repositories;
using TransUnionPortal.Utils;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

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
        public ActionResult Index(ConfigurationFile model)
        {
            if (Request["boton"].Equals("Consultar"))
            {
                var tipo = model.SelectecType;
                ExportFileRepository servicio = new ExportFileRepository();
                model = servicio.GetIndexModel();
                model.Contenido = servicio.SetContentData(tipo);
                return View(model);
            }
            else if (Request["boton"].Equals("Exportar"))
            {
                
                var tipo = model.SelectecType;
                ExportFileRepository servicio = new ExportFileRepository();
                model = servicio.GetIndexModel();
                model.Contenido = servicio.SetContentData(tipo);
                Generate(model);
            }

            return View(model);
        }

        [HttpPost]
        public void Generate(ConfigurationFile configurationFile)
        {     
            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = "test.csv",
                Inline = true,
            };

            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.Charset = "ASCII";

            CargaFinanciera carga = configurationFile.Contenido.CargaFinanciera;
            BanderaAmarilla bandera = configurationFile.Contenido.BanderaAmarilla;

            if(carga != null && bandera == null) {

                List<CargaFinanciera> cfList = new List<CargaFinanciera>();
                cfList.Add(carga);

                foreach (var cf in cfList)
                {
                    var propiedades = cf.GetType().GetProperties().ToList();

                    foreach (var prop in propiedades)
                    {

                        response.Write(prop.GetCustomAttribute<DisplayAttribute>().GetName() + ",");

                    }
                    response.Write(Environment.NewLine);
                    propiedades.ForEach((propiedad) => response.Write(propiedad.GetValue(cf).ToString() + ","));
        
                }
                             
                response.ContentType = "text/csv";
                response.AddHeader("Content-Disposition", cd.ToString());
                response.Flush();
                response.End();

            }

            else if (bandera != null && carga == null)
            {
                List<BanderaAmarilla> cfList = new List<BanderaAmarilla>();
                cfList.Add(bandera);

                foreach (var cf in cfList)
                {
                    var propiedades = cf.GetType().GetProperties().ToList();

                    foreach (var prop in propiedades)
                    {

                        response.Write(prop.GetCustomAttribute<DisplayAttribute>().GetName() + ",");

                    }
                    response.Write(Environment.NewLine);
                    propiedades.ForEach((propiedad) => response.Write(propiedad.GetValue(cf).ToString() + ","));

                }

                response.ContentType = "text/csv";
                response.AddHeader("Content-Disposition", cd.ToString());
                response.Flush();
                response.End();
            }

        }

    }

}