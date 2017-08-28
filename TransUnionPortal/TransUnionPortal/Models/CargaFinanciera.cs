using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TransUnionPortal.Models
{
    public class CargaFinanciera
    {
        /* Entidad: Garantía */
        [Display(Name = "NIV")]
        public string NIV { get; set; }
        [Display(Name = "Entidad Federativa")]
        public string Entidad { get; set; } // Estado
        [Display(Name = "Clasificación del vehículo")]
        public int EstadoVehiculo { get; set; } // 0 No disponible, 1 Nuevo, 2 Usado
        [Display(Name = "Uso del vehículo")]
        public int UsoVehiculo { get; set; } // 0 No disponible, 1 carga, 2 particular, 3 servicio publico
        [Display(Name = "Submarca")]
        public string Submarca { get; set; }
        [Display(Name = "Aseguradora")]
        public string Aseguradora { get; set; }
        [Display(Name = "Fabricante")]
        public string Fabricante { get; set; }
        [Display(Name = "Tipo de vehículo")]
        public int TipoVehiculo { get; set; }
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Display(Name = "Placas")]
        public string Placas { get; set; }
        [Display(Name = "NCI")]
        public string NCI { get; set; }

        /* Entidad: Crédito */
        [Display(Name = "Vigencia del contrato")]
        public string VigenciaContrato { get; set; } // Duracion en meses. int? string?
        [Display(Name = "Fecha de operación")]
        public string FechaInicio
        {
            get;
            set;
        } // Inicio del crédito
        [Display(Name = "Número de contrato")]
        public string NumeroContrato { get; set; }
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; }
        [Display(Name = "Tipo de crédito")]
        public int TipoCredito { get; set; } // 1 Simple, 2 Arrendemiento Puro, 3 Arr. Financiero
        // 4 Plan piso, 5 Autofinanciamiento, 6 Prendario con resguardo, 7 Prendario sin resguardo

        /* Entidad: Personas físicas, Personas morales */
        [Display(Name = "Tipo de cliente")]
        public int TipoCliente { get; set; } // 0 No disponible, 1 Persona física, 2 Persona moral

        /* Entidad: Seguimiento de cobranza */
        [Display(Name = "Estatus de cartera")]
        public int EstadoCartera { get; set; } // 0 al 9
        
        /* Entidad: Poliza */
        [Display(Name = "Número de póliza")]
        public string NumeroPoliza { get; set; }
        [Display(Name = "Inciso de póliza")]
        public string Inciso { get; set; }

    }
}