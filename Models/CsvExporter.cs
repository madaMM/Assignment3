using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace MvcAppShop.Models
{
    public class CsvExporter : Exporter
    {
       





        void Exporter.exportProducts(List<Product> prodL)
        {
            string[][] output = null;
            string filePath = "D:\\" + "Fisier.csv";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            string delimiter = ",";
            foreach (Product prod in prodL)
            {
                output = new string[][] { new string[] { prod.ID.ToString(), prod.Name, prod.Price.ToString() } };
            }
            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
                sb.AppendLine(string.Join(delimiter, output[index]));
            File.AppendAllText(filePath, sb.ToString());
        }
    }
}