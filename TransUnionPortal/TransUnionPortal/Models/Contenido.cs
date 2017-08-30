using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransUnionPortal.Models
{
    public class Contenido
    {
        public List<CargaFinanciera> CargaFinanciera { get; set; }
        public List<BanderaAmarilla> BanderaAmarilla { get; set; }

        //public Contenido()
        //{
        //    CargaFinanciera = new List<CargaFinanciera>();
        //    BanderaAmarilla = new List<BanderaAmarilla>();
        //}
    }
}