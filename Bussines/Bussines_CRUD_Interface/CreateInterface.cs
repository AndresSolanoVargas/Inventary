using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Bussines_CRUD_Interface
{
    interface CreateInterface<T>
    {
        void CreateItem(T item);
    }
}
