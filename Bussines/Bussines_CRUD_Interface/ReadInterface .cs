using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Bussines_CRUD_Interface
{
    interface ReadInterface <T>
    {
        List<T> ItemList();
    }
}
