using Bussines.Bussines_CRUD_Interface;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Bussines_Category
{
    public class CreateCategory : CreateInterface<CategoryEntity>
    {
        public void CreateItem(CategoryEntity item)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Add(item);
                db.SaveChanges();
            }
        }
    }
}
