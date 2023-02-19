using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();
        
        public static void AddProduct(Product productToAdd)
        {
            Products.Add(productToAdd);
        }
        public bool RemoveProduct(int productIdToRemove)
        {
            var productToRemove = LookupProduct(productIdToRemove);
            bool removeResult = Products.Remove(productToRemove);
            return removeResult;
        }
        public static Product LookupProduct(int productIdToLookup)
        {
            return (Product)Products.Where(p => p.ProductId == productIdToLookup);
        }
        public static void UpdateProduct(int productIdToUpdate, Product productInfo)
        {
            var productToUpdate = LookupProduct(productIdToUpdate);
            productToUpdate.ProductId = productInfo.ProductId;
            productToUpdate.Name = productInfo.Name;
            productToUpdate.Price = productInfo.Price;
            productToUpdate.InStock = productInfo.InStock;
            productToUpdate.Min = productInfo.Min;
            productToUpdate.Max = productInfo.Max;

        }
        public static void AddPart(Part partToAdd)
        {
            Parts.Add(partToAdd);
        }
        public static bool DeletePart(Part partToDelete)
        {
            var removeResult = Parts.Remove(partToDelete);
            return removeResult;
        }
        public static Part LookupPart(int partIdToLookup)
        {
            return (Part)Parts.Where(p => p.PartId == partIdToLookup).Single();
        }
        public static void UpdatePart(int partdIdToUpdate, Part partInfo)
        {
            var partToUpdate = LookupPart(partdIdToUpdate);
            partToUpdate.PartId = partInfo.PartId;
            partToUpdate.Name = partInfo.Name;
            partToUpdate.Price = partInfo.Price;
            partToUpdate.Min = partInfo.Min;
            partToUpdate.Max = partInfo.Max;
        }

    }
}
