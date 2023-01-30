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
        
        public void AddProduct(Product productToAdd)
        {

        }
        public bool RemoveProduct(int productIdToRemove)
        {
        }
        public Product LookupProduct(int productIdToLookup)
        {

        }
        public void UpdateProduct(int productIdToUpdate, Product productInfo)
        {

        }
        public void AddPart(Part partToAdd)
        {

        }
        public bool DeletePart(Part partToDelete)
        {

        }
        public Part LookupPart(int partIdToLookup)
        {

        }
        public void UpdatePart(int partdIdToUpdate, Part partInfo)
        {

        }

    }
}
