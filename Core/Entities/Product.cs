using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int IdProdBrandFk { get; set; }
        public ProductBrand ProductBrand { get; set; }
    }
}