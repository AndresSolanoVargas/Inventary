using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Bussines.Bussines_CRUD_Interface;

namespace Bussines.Bussines_InputOutput
{
    class UpdateInputOuput : UpdateInterface<InputOutputEntity>
    {
        public void Update(InputOutputEntity item)
        {
            using (var db = new InventaryContext()) 
            {
                db.InOuts.Update(item);
                db.SaveChanges();
            }
        }
    }
}
