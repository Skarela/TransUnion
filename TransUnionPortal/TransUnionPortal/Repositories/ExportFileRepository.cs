using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransUnionPortal.Models;

namespace TransUnionPortal.Repositories
{
    public class ExportFileRepository
    {
        public ConfigurationFile GetIndexModel()
        {
            List<FileType> fileTypes = new List<FileType>();
            fileTypes.Add(new FileType { Value = 1, Text = "Carga Financiera" });
            fileTypes.Add(new FileType { Value = 2, Text = "Bandera Amarilla" });
            ConfigurationFile model = new ConfigurationFile
            {
                Type = new SelectList(fileTypes, "Value", "Text", string.Empty)
            };

            return model;
        }

        public Contenido SetContentData(int? tipo)
        {
            Contenido contenido = new Contenido();

            if (tipo == 1)
            {
                CargaFinanciera carga = new CargaFinanciera { 
                    NIV = "ABC123",
                    Aseguradora = "Qualitas",
                    Color = "Verde",
                    Entidad = "Yucatán",
                    EstadoCartera = 7,
                    EstadoVehiculo = 2,
                    Fabricante = "Hyundai",
                    FechaInicio = "25/08/2017",
                    Inciso = "243",
                    Modelo = "2015",
                    NCI = "424FSDF",
                    NumeroContrato = "0342",
                    NumeroPoliza = "453SFD",
                    Observaciones = "Los rines no son los originales",
                    Placas = "IAM-KWAI",
                    Submarca = "Elantra",
                    TipoCliente = 1,
                    TipoCredito = 5,
                    TipoVehiculo = 2,
                    UsoVehiculo = 2,
                    VigenciaContrato = "24"               
                };

                contenido.CargaFinanciera = carga;
               
            }
            else if (tipo == 2)
            {
                BanderaAmarilla bandera = new BanderaAmarilla {         
                    Bandera = 1,
                    EstadoSeguro = 1,
                    EstadoVigencia = 1,
                    FechaDictamina = "31/08/2017",
                    Inciso = "243",
                    Motivo = 3,
                    NumeroContrato = "0342",
                    NumeroPoliza = "453SDF",
                    NumeroSiniestro = "234248",
                    VIN = "890XYZ"
                };
                contenido.BanderaAmarilla = bandera;
            }
            return contenido;
        }
    }
}