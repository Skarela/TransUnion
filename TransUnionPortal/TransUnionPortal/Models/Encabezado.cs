using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransUnionPortal.Models
{
    public class Encabezado
    {
        public string Id 
        { 
            get
            {
                return "HR"; 
            }
        }
        public string IdInstitucion
        {
            get
            {
                return "Por definir";
            }
        }
        public string TipoArchivo
        {
            get
            {
                return "03";
            }
        }
        public string FechaEnvio
        {
            get
            {
                return DateTime.Today.ToString("yyyyMMdd");
            }
        }
        public string HoraEnvio
        {
            get
            {
                return DateTime.Now.ToString("HH:mm");
            }
        }
    }
}