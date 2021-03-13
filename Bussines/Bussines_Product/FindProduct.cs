using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Interface_Utilities;
using System.Linq;

namespace Bussines.Bussines_Product
{
    public class FindProduct : FindElementInterface<ProductEntity>
    {
        public ProductEntity FindElement(string id)
        {
            using (var db = new InventaryContext()) {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }
    }
}
