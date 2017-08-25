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
    }
}