using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppShop.Models
{
    public class Factory
    {

        public Exporter createxportType(int i){
            if (i == 0) return new JsonExporter();
            else if (i == 1) return new CsvExporter();
            else return null;
        }

    }
}