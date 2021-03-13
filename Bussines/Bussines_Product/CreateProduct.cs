using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;

namespace Bussines.Bussines_Product
{
    public class CreateProduct : CreateInterface<ProductEntity>
    {
        public void CreateItem(ProductEntity item)
        {
            using (var db =  new InventaryContext()) {
                db.Products.Add(item);
                db.SaveChanges();
            }
        }
    }
}
