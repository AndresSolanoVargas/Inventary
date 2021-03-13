using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;
using Entities;
using Bussines.Bussines_CRUD_Interface;

namespace Bussines.Bussines_Warehouse
{
    public class CreateWarehouse : CreateInterface<WarehouseEntity>
    {
        public void CreateItem(WarehouseEntity item)
        {
            using (var db = new InventaryContext()) {
                db.Warehouses.Add(item);
                db.SaveChanges();
            }
        }
    }
}
