using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bussines.Bussines_Store;
using Bussines.Bussines_Product;

namespace Bussines.Bussines_InputOutput
{
    public class Verificaction
    {
        private UpdateStore updateStore = new UpdateStore();
        private UpdateProducto updateProduct = new UpdateProducto();
        private bool IsBiggerThanZero(int quantity, int storaQuantity)
        {
            if (storaQuantity > quantity)
            {
                return true;
            }
            return false;
        }

        public string SaveInOut(ProductEntity OProduct, List<StorageEntity> Ostorages,StorageEntity OStorage, InputOutputEntity oInOut)
        {
            OStorage = Ostorages.LastOrDefault(s => s.StorageId == oInOut.StorageId);
            OProduct = OStorage.Product;

            if (oInOut.IsInput)
            {
                OStorage.PartialQuantity = OStorage.PartialQuantity + oInOut.Quantity;
                updateStore.Update(OStorage);

                OProduct.TotalQuantity = OProduct.TotalQuantity + oInOut.Quantity;
                updateProduct.Update(OProduct);

                return $"El producto {OProduct.ProductName} ha sido actualizado";
            }
            else
            {
                if (IsBiggerThanZero(oInOut.Quantity, OStorage.PartialQuantity))
                {
                    OStorage.PartialQuantity = OStorage.PartialQuantity - oInOut.Quantity;
                    updateStore.Update(OStorage);

                    OProduct.TotalQuantity = OProduct.TotalQuantity - oInOut.Quantity;
                    updateProduct.Update(OProduct);

                    return $"El producto {OProduct.ProductName} ha sido actualizado";
                }
                else
                {
                    return $"No existe la cantidad en bodega del produco {OProduct.ProductName} ";
                }
            }
        }


    }
}
