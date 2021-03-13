using System;
using System.Collections.Generic;
using System.Text;
using Bussines.Bussines_CRUD_Interface;
using Entities;
using DataAccess;

namespace Bussines.Bussines_Category
{
    public class UpadateCategory : UpdateInterface<CategoryEntity>
    {
        public void Update(CategoryEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(item);
                db.SaveChanges();
            }
        }
    }
}
