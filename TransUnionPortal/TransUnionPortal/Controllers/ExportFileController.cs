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
        public FileContentResult Generate(ConfigurationFile configurationFile)
        {
            // PROBAR SI FUNCIONA CON UN HREF EN VEZ DE UN SUBMIT

            //before your loop
            var csv = new StreamWriter(new MemoryStream());
            byte[] bytes;
            //Suggestion made by KyleMit
            var newLine = string.Format("{0},{1},{2}", "id", "archivo", "tipo");
            //csv.AppendLine(newLine);
            //foreach (var dato in configurationFile.Encabezado)
            //{
            //    csv.Append(dato.Id);
            //    csv.Append(dato.IdInstitucion);
            //    csv.Append(dato.FechaEnvio);
            //    csv.Append(dato.HoraEnvio);
            //    csv.Append(dato.TipoArchivo);
            List<Contenido> contenido = new List<Contenido>();
            contenido.Add(configurationFile.Contenido);
            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = "test.csv",
                Inline = false,
            };
            Response.Clear();
            Response.AppendHeader("content-disposition", cd.ToString());
            Response.ContentType = "application/octet-stream";

            if(configurationFile.Contenido.CargaFinanciera != null) {

                foreach (var propiedad in contenido)
                {
                    //csv.Append(propiedad.CargaFinanciera.NIV);
                    //csv.Append(propiedad.CargaFinanciera.Entidad);
                    //csv.Append(propiedad.CargaFinanciera.EstadoVehiculo);
                    //csv.Append(propiedad.CargaFinanciera.VigenciaContrato);
                    //csv.Append(propiedad.CargaFinanciera.FechaInicio);
                    //csv.Append(propiedad.CargaFinanciera.NumeroContrato);
                    //csv.Append(propiedad.CargaFinanciera.Observaciones);
                    //csv.Append(propiedad.CargaFinanciera.TipoCredito);
                    //csv.Append(propiedad.CargaFinanciera.TipoCliente);
                    //csv.Append(propiedad.CargaFinanciera.EstadoCartera);
                    //csv.Append(propiedad.CargaFinanciera.UsoVehiculo);
                    //csv.Append(propiedad.CargaFinanciera.Submarca);
                    //csv.Append(propiedad.CargaFinanciera.Aseguradora);
                    //csv.Append(propiedad.CargaFinanciera.NumeroPoliza);
                    //csv.Append(propiedad.CargaFinanciera.Inciso);
                    //csv.Append(propiedad.CargaFinanciera.Fabricante);
                    //csv.Append(propiedad.CargaFinanciera.TipoVehiculo);
                    //csv.Append(propiedad.CargaFinanciera.Modelo);
                    //csv.Append(propiedad.CargaFinanciera.Color);
                    //csv.Append(propiedad.CargaFinanciera.Placas);
                    //csv.Append(propiedad.CargaFinanciera.NCI);
                    csv.WriteLine(String.Format(propiedad.CargaFinanciera.NIV, propiedad.CargaFinanciera.Modelo));
                }
                bytes = Encoding.ASCII.GetBytes(csv.ToString());
                //after your loop
                
                
                return File(Encoding.ASCII.GetBytes(csv.ToString()), "text/csv");
            }
            
            return File(Encoding.ASCII.GetBytes(csv.ToString()), "text/csv", "asdf.csv");
            
        }
    }
}