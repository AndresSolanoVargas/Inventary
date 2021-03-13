using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bussines.Interface_Utilities;
using DataAccess;
using Entities;

namespace Bussines.Bussines_Category
{
    public class FindCategory : FindElementInterface<CategoryEntity>
    {
        public CategoryEntity FindElement(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList().LastOrDefault(p => p.CategoryId == id);
            }
        }
    }
}
