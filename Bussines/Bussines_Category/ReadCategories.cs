using Bussines.Bussines_CRUD_Interface;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines.Bussines_Category
{
    public class ReadCategories : ReadInterface<CategoryEntity>
    {
        public List<CategoryEntity> ItemList()
        {
            using (var db = new InventaryContext()) 
            {
                return db.Categories.ToList();
            }
        }
    }
}
