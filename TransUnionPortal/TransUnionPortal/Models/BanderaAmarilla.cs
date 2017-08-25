using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransUnionPortal.Models
{
    public class BanderaAmarilla
    {
        /* Entidad: Garantía */
        public string VIN { get; set; }

        /* Entidad: Bandera Amarilla */
        public int EstadoVigencia { get; set; } // 1 Vigente, 2 Cancelado
        public int EstadoSeguro { get; set; } // 1 Asegurado, 2 Tercero, 3 Acreditado
        public int Bandera { get; set; } // 1 Confirmado, 2 Sospecha
        public int Motivo { get; set; } // 1-24
        public string FechaDictamina
        {
            get
            {
                return DateTime.Today.ToString("ddMMyyyy");
            }
            set { FechaDictamina = value; }
        }
        public string NumeroSiniestro { get; set; }

        /* Entidad: Póliza */
        public string NumeroPoliza { get; set; }
        public string Inciso { get; set; }

        /* Entidad: Crédito */
        public string NumeroContrato { get; set; }


    }
}