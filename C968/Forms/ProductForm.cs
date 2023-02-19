using C968.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C968.PartForm;

namespace C968
{
    public partial class ProductForm : Form
    {
        private static string partsAvailableSearch;
        private static string partsAddedSearch;
        private Part PartsAvailableSelected;
        private Part PartsAddedSelected;
        private Operation _productOperation;

        private BindingList<Part> _productParts;

        public BindingList<Part> ProductParts { get => _productParts; set => _productParts = value; }
        public Operation ProductOperation { get => _productOperation; set => _productOperation = value; }

        public ProductForm(Operation operation, int selectedProductId = 0)
        {
            ProductOperation = operation;
            ProductParts = new BindingList<Part>();
            InitializeComponent();
            if (operation == Operation.updating)
            {

            }
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            PartsAvailableGrid.DataSource = Inventory.Parts;
            PartsAddedGrid.DataSource = ProductParts;
            PartsAvailableGrid.ClearSelection();
        }

        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartsAvailableInput_TextChanged(object sender, EventArgs e)
        {
            partsAvailableSearch = PartsAvailableInput.Text;
            if (partsAvailableSearch.Length <= 0)
            {
                PartsAvailableGrid.DataSource = Inventory.Parts;
            }
        }

        private void PartsAvailableButton_Click(object sender, EventArgs e)
        {
            PartsAvailableGrid.ClearSelection();
            if (partsAvailableSearch?.Length > 0)
            {
                var partsAvailableWithMatchingName = Inventory.Parts.Where(p => p.Name.ToLower().Contains(partsAvailableSearch.ToLower())).ToList();
                PartsAvailableGrid.DataSource = partsAvailableWithMatchingName;
            }
        }
        private void PartsAvailableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowSelected = PartsAvailableGrid.CurrentRow;
            var partId = (int)rowSelected.Cells[0].Value;
            PartsAvailableSelected = Inventory.LookupPart(partId);
        }
        private void AddPart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(PartsAvailableSelected.Name))
            {
                ProductParts.Add(PartsAvailableSelected);
                PartsAvailableGrid.ClearSelection();
                PartsAddedGrid.ClearSelection();
            }
        }

        private void AddedPartsInput_TextChanged(object sender, EventArgs e)
        {
            partsAddedSearch = PartsAddedInput.Text;
            if (partsAddedSearch.Length <= 0)
            {
                PartsAddedGrid.DataSource = ProductParts;
            }
        }

        private void PartsAddedButton_Click(object sender, EventArgs e)
        {
            PartsAddedGrid.ClearSelection();
            if (partsAddedSearch?.Length > 0)
            {
                var partsAddedWithmatchingName = ProductParts.Where(p => p.Name.ToLower().Contains(partsAddedSearch.ToLower())).ToList();
                PartsAddedGrid.DataSource = partsAddedWithmatchingName;
            }
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(PartsAddedSelected.Name))
            {
                ProductParts.Remove(PartsAddedSelected);
                PartsAvailableGrid.ClearSelection();
                PartsAddedGrid.ClearSelection();
            }
        }

        private void PartsAddedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowSelected = PartsAddedGrid.CurrentRow;
            var partId = (int)rowSelected.Cells[0].Value;
            PartsAddedSelected = Inventory.LookupPart(partId);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductIdInput.Text)
                && !string.IsNullOrEmpty(ProductNameInput.Text)
                && !string.IsNullOrEmpty(ProductInventoryInput.Text)
                && !string.IsNullOrEmpty(ProductMaxInput.Text)
                && !string.IsNullOrEmpty(ProductPriceInput.Text)
                && !string.IsNullOrEmpty(ProductMinInput.Text))
            {
                if (ProductOperation == Operation.adding)
                {
                    var ProductToAdd = new Product(
                        Convert.ToInt32(ProductIdInput.Text),
                            ProductNameInput.Text,
                            Convert.ToInt32(ProductInventoryInput.Text),
                            Convert.ToDecimal(ProductPriceInput.Text),
                            Convert.ToInt32(ProductMaxInput.Text),
                            Convert.ToInt32(ProductMinInput.Text)
                        );
                    foreach(Part part in ProductParts)
                    {
                        ProductToAdd.AddAssociatedPart(part);
                    }
                    Inventory.AddProduct(ProductToAdd);
                    this.Close();
                }
            }
        }
    }
}
