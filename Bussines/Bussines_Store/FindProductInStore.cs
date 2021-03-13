using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;
using System.Linq;

namespace Bussines.Bussines_Store
{
    public class FindProductInStore
    {
        public static bool isProductInWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);
                return product.Any();
            }
        }
    }
}
