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
            Contenido content = new Contenido();

            if (tipo == 1)
            {
                content.CargaFinanciera.NIV = "ABC123";
                content.CargaFinanciera.Aseguradora = "Qualitas";
                content.CargaFinanciera.Color = "Verde";
                content.CargaFinanciera.Entidad = "Yucatán";
                content.CargaFinanciera.EstadoCartera = 7;
                content.CargaFinanciera.EstadoVehiculo = 2;
                content.CargaFinanciera.Fabricante = "Hyundai";
                content.CargaFinanciera.FechaInicio = "25/08/2017";
                content.CargaFinanciera.Inciso = "243";
                content.CargaFinanciera.Modelo = "2015";
                content.CargaFinanciera.NCI = "424FSDF";
                content.CargaFinanciera.NumeroContrato = "0342";
                content.CargaFinanciera.NumeroPoliza = "453SFD";
                content.CargaFinanciera.Observaciones = "Los rines no son los originales";
                content.CargaFinanciera.Placas = "IAM-KWAI";
                content.CargaFinanciera.Submarca = "Elantra";
                content.CargaFinanciera.TipoCliente = 1;
                content.CargaFinanciera.TipoCredito = 5;
                content.CargaFinanciera.TipoVehiculo = 2;
                content.CargaFinanciera.UsoVehiculo = 2;
                content.CargaFinanciera.VigenciaContrato = "24";
            }
            else if (tipo == 2)
            {
                content.BanderaAmarilla.Bandera = 1;
                content.BanderaAmarilla.EstadoSeguro = 1;
                content.BanderaAmarilla.EstadoVigencia = 1;
                content.BanderaAmarilla.FechaDictamina = "31/08/2017";
                content.BanderaAmarilla.Inciso = "243";
                content.BanderaAmarilla.Motivo = 3;
                content.BanderaAmarilla.NumeroContrato = "0342";
                content.BanderaAmarilla.NumeroPoliza = "453SDF";
                content.BanderaAmarilla.NumeroSiniestro = "234248";
                content.BanderaAmarilla.VIN = "890XYZ";
            }
            return content;
        }
    }
}