using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransUnionPortal.Models
{
    public class CargaFinanciera
    {
        /* Entidad: Garantía */
        public string NIV { get; set; }
        public string Entidad { get; set; } // Estado
        public int EstadoVehiculo { get; set; } // 0 No disponible, 1 Nuevo, 2 Usado
        public int UsoVehiculo { get; set; } // 0 No disponible, 1 carga, 2 particular, 3 servicio publico
        public string Submarca { get; set; }
        public string Aseguradora { get; set; }
        public string Fabricante { get; set; }
        public int TipoVehiculo { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Placas { get; set; }
        public string NCI { get; set; }

        /* Entidad: Crédito */
        public string VigenciaContrato { get; set; } // Duracion en meses. int? string?
        public string FechaInicio
        {
            get
            {
                return DateTime.Today.ToString("ddMMyyyy");
            }
            set
            {
                FechaInicio = value;
            }
        } // Inicio del crédito
        public string NumeroContrato { get; set; }
        public string Observaciones { get; set; }
        public int TipoCredito { get; set; } // 1 Simple, 2 Arrendemiento Puro, 3 Arr. Financiero
        // 4 Plan piso, 5 Autofinanciamiento, 6 Prendario con resguardo, 7 Prendario sin resguardo

        /* Entidad: Personas físicas, Personas morales */
        public int TipoCliente { get; set; } // 0 No disponible, 1 Persona física, 2 Persona moral

        /* Entidad: Seguimiento de cobranza */
        public int EstadoCartera { get; set; } // 0 al 9
        
        /* Entidad: Poliza */
        public string NumeroPoliza { get; set; }
        public string Inciso { get; set; }

    }
}