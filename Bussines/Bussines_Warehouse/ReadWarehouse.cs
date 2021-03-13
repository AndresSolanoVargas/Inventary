using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;
using Entities;
using Bussines.Bussines_CRUD_Interface;


namespace Bussines.Bussines_Warehouse
{
    public class ReadWarehouse : ReadInterface<WarehouseEntity>
    {
        public List<WarehouseEntity> ItemList()
        {
            using (var db = new InventaryContext()) {
                return db.Warehouses.ToList();
            }
        }
    }
}
