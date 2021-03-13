using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines.Bussines_Store
{
     public class StoragesProduct
    {
        public List<StorageEntity> storagesProductByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.
                    Include(s => s.Product).
                    Include(s => s.Warehouse).
                    Where(s => s.WarehouseId == idWarehouse)
                    .ToList();
            }
        }
    }
}
