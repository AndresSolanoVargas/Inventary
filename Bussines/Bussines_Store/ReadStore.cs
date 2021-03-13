using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;
using System.Linq;

namespace Bussines.Bussines_Store
{
    public class ReadStore : ReadInterface<StorageEntity>
    {
        public List<StorageEntity> ItemList()
        {
            using (var db = new InventaryContext()) {
                return db.Storages.ToList();
            }
        }
    }
}
