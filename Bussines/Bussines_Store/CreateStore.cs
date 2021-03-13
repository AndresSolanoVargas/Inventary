using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;

namespace Bussines.Bussines_Store
{
    public class CreateStore : CreateInterface<StorageEntity>
    {
        public void CreateItem(StorageEntity item)
        {
            using (var db = new InventaryContext()) {
                db.Storages.Add(item);
                db.SaveChanges();
            }
        }
    }
}
