using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransUnionPortal.Models
{
    public class ConfigurationFile
    {
        public ConfigurationFile()
        {
            SelectecType = 1;
        }

        [Display(Name="Tipo")]
        public int? SelectecType { get; set; }

        public SelectList Type { get; set; }

        public IList<Encabezado> Encabezado { get; set; }

        public IList<Pie> Pie { get; set; }

        public Contenido Contenido { get; set; }

    }
}