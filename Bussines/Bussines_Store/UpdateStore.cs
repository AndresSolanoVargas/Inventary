using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;

namespace Bussines.Bussines_Store
{
    public class UpdateStore : UpdateInterface<StorageEntity>
    {
        public void Update(StorageEntity item)
        {
            using (var db = new InventaryContext()) {
                db.Storages.Update(item);
                db.SaveChanges();
            }
        }
    }
}
