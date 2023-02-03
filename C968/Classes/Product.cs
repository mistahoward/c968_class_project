using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    class Product
    {
        private int _productId;
        private string _name;
        private decimal _price;
        private int _inStock;
        private int _min;
        private int _max;

        public int ProductId { get => _productId; set => _productId = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
        public int InStock { get => _inStock; set => _inStock = value; }
        public int Min { get => _min; set => _min = value; }
        public int Max { get => _max; set => _max = value; }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        
        public void AddAssociatedPart(Part partToAdd)
        {
            AssociatedParts.Add(partToAdd);
        }
        public bool RemoveAssociatedPart(int partIdToRemove)
        {
            Part partToRemove = LookupAssociatedPart(partIdToRemove);
            bool removalResult = AssociatedParts.Remove(partToRemove);
            return removalResult;
        }
        public Part LookupAssociatedPart(int partIdToLookUp)
        {
            return (Part)AssociatedParts.Where(p => p.PartId == partIdToLookUp);
        }
    }
}
