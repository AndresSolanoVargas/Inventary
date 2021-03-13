using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;
using System.Linq;

namespace Bussines.Bussines_Product
{
    public class ReadProduct : ReadInterface<ProductEntity>
    {
        public List<ProductEntity> ItemList()
        {
            using (var db = new InventaryContext()) {
                return db.Products.ToList();
            }
        }
    }
}
