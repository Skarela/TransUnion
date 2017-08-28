using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TransUnionPortal.Models
{
    public class BanderaAmarilla
    {
        /* Entidad: Garantía */
        [Display(Name = "VIN")]
        public string VIN { get; set; }

        /* Entidad: Bandera Amarilla */
        [Display(Name = "Estatus")]
        public int EstadoVigencia { get; set; } // 1 Vigente, 2 Cancelado
        [Display(Name = "Identificación")]
        public int EstadoSeguro { get; set; } // 1 Asegurado, 2 Tercero, 3 Acreditado
        [Display(Name = "Bandera")]
        public int Bandera { get; set; } // 1 Confirmado, 2 Sospecha
        [Display(Name = "Motivo")]
        public int Motivo { get; set; } // 1-24
        [Display(Name = "Dictamina")]
        public string FechaDictamina
        {
            get;
            set;
        }
        [Display(Name = "Número de siniestro")]
        public string NumeroSiniestro { get; set; }

        /* Entidad: Póliza */
        [Display(Name = "Número de póliza")]
        public string NumeroPoliza { get; set; }
        [Display(Name = "Inciso de póliza")]
        public string Inciso { get; set; }

        /* Entidad: Crédito */
        [Display(Name = "Número de contrato")]
        public string NumeroContrato { get; set; }


    }
}