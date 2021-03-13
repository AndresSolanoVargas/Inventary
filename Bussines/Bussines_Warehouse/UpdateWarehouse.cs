using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;
using Entities;
using Bussines.Bussines_CRUD_Interface;

namespace Bussines.Bussines_Warehouse
{
    public class UpdateWarehouse : UpdateInterface<WarehouseEntity>
    {
        public void Update(WarehouseEntity item)
        {
            using (var db = new InventaryContext()) {
                db.Warehouses.Update(item);
            }
        }
    }
}
