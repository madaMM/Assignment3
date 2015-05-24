using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAppShop.Models
{
    public interface Exporter
    {
        void exportProducts(List<Product> prodL);
    }
}
