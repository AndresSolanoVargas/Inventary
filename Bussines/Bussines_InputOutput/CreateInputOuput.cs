using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;

namespace Bussines.Bussines_InputOutput
{
    class CreateInputOuput : CreateInterface<InputOutputEntity>
    {
        public void CreateItem(InputOutputEntity item)
        {
            using (var db = new InventaryContext()) 
            {
                db.InOuts.Add(item);
                db.SaveChanges();
            }
        }
    }
}
