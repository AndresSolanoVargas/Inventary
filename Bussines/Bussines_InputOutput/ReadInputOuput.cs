using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;
using System.Linq;

namespace Bussines.Bussines_InputOutput
{
    class ReadInputOuput : ReadInterface<InputOutputEntity>
    {
        public List<InputOutputEntity> ItemList()
        {
            using (var db = new InventaryContext()) 
            {
                return db.InOuts.ToList();
            }
        }
    }
}
