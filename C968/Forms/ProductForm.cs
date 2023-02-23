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

        private Product _selectedProduct;

        private BindingList<Part> _productParts;

        public BindingList<Part> ProductParts { get => _productParts; set => _productParts = value; }
        public Operation ProductOperation { get => _productOperation; set => _productOperation = value; }
        internal Product SelectedProduct { get => _selectedProduct; set => _selectedProduct = value; }

        public ProductForm(Operation operation, int selectedProductId = 0)
        {
            // product form constructor, using product parts as a list of "added parts"
            ProductOperation = operation;
            ProductParts = new BindingList<Part>();
            InitializeComponent();
            if (operation == Operation.updating)
            {
                // setting fields based off existing part
                SelectedProduct = Inventory.LookupProduct(selectedProductId);
                ProductIdInput.Text = SelectedProduct.ProductId.ToString();
                ProductNameInput.Text = SelectedProduct.Name;
                ProductInventoryInput.Text = SelectedProduct.InStock.ToString();
                ProductPriceInput.Text = SelectedProduct.Price.ToString();
                ProductMinInput.Text = SelectedProduct.Min.ToString();
                ProductMaxInput.Text = SelectedProduct.Max.ToString();
                // add each part to product parts
                foreach(Part part in SelectedProduct.AssociatedParts)
                {
                    ProductParts.Add(part);
                }
            } else
            {
                // grab the highest ID, auto increment it one, convert it to a string and set it as input value
                var highestId = Inventory.Products.Max(p => p.ProductId);
                ProductIdInput.Text = (highestId + 1).ToString();
            }
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            // binding, clear selections to make row selection explicit
            PartsAvailableGrid.DataSource = Inventory.Parts;
            PartsAddedGrid.DataSource = ProductParts;
            PartsAvailableGrid.ClearSelection();
            PartsAddedGrid.ClearSelection();
        }

        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartsAvailableInput_TextChanged(object sender, EventArgs e)
        {
            // same search methodology as main screen
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
                var partsAvailableWithMatchingName = Inventory.Parts
                    .Where(p => p.Name.ToLower().Contains(partsAvailableSearch.ToLower())).ToList();
                PartsAvailableGrid.DataSource = partsAvailableWithMatchingName;
            }
        }
        private void PartsAvailableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // same methodology as parts
            DataGridViewRow rowSelected = PartsAvailableGrid.CurrentRow;
            var partId = (int)rowSelected.Cells[0].Value;
            PartsAvailableSelected = Inventory.LookupPart(partId);
        }
        private void AddPart_Click(object sender, EventArgs e)
        {
            // adding part to product, check if one has been selected first and foremost
            if (!String.IsNullOrEmpty(PartsAvailableSelected?.Name))
            {
                // add to product parts
                ProductParts.Add(PartsAvailableSelected);
                if(ProductOperation == Operation.updating)
                {
                    // if updating, add it to th eactual product
                    SelectedProduct.AddAssociatedPart(PartsAvailableSelected);
                }
                // clear selection
                PartsAvailableSelected = null;
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
                var partsAddedWithmatchingName = ProductParts
                    .Where(p => p.Name.ToLower().Contains(partsAddedSearch.ToLower())).ToList();
                PartsAddedGrid.DataSource = partsAddedWithmatchingName;
            }
        }

        private void DeletePart_Click(object sender, EventArgs e)
        {
            // same method as above, just removing
            if (!String.IsNullOrEmpty(PartsAddedSelected?.Name))
            {
                ProductParts.Remove(PartsAddedSelected);
                if (ProductOperation == Operation.updating)
                {
                    SelectedProduct.RemoveAssociatedPart(PartsAddedSelected.PartId);
                }
                PartsAddedSelected = null;
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
            // field null and empty validation
            if (!string.IsNullOrEmpty(ProductIdInput.Text)
                && !string.IsNullOrEmpty(ProductNameInput.Text)
                && !string.IsNullOrEmpty(ProductInventoryInput.Text)
                && !string.IsNullOrEmpty(ProductMaxInput.Text)
                && !string.IsNullOrEmpty(ProductPriceInput.Text)
                && !string.IsNullOrEmpty(ProductMinInput.Text))
            {
                int min = Convert.ToInt32(ProductMinInput.Text);
                int max = Convert.ToInt32(ProductMaxInput.Text);
                int inventory = Convert.ToInt32(ProductInventoryInput.Text);
                // inventory validation
                if (min > max)
                {
                    MessageBox.Show("Minimum stock cannot be larger than maximum stock.", "Incorrect Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (min <= inventory && inventory >= max)
                {
                    MessageBox.Show("Inventory has to be between min and max stock values", "Incorrect Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ProductOperation == Operation.adding)
                {
                    // product constructor
                    var ProductToAdd = new Product(
                        Convert.ToInt32(ProductIdInput.Text),
                            ProductNameInput.Text,
                            inventory,
                            Convert.ToDecimal(ProductPriceInput.Text),
                            max,
                            min
                        );
                    // for each part in product parts... add associated part
                    foreach(Part part in ProductParts)
                    {
                        ProductToAdd.AddAssociatedPart(part);
                    }
                    // add product, dismiss dialogue
                    Inventory.AddProduct(ProductToAdd);
                    this.Close();
                } else
                {
                    // update product otherwise
                    SelectedProduct.ProductId = Convert.ToInt32(ProductIdInput.Text);
                    SelectedProduct.Name = ProductNameInput.Text;
                    SelectedProduct.InStock = inventory;
                    SelectedProduct.Price = Convert.ToDecimal(ProductPriceInput.Text);
                    SelectedProduct.Min = min;
                    SelectedProduct.Max = max;
                    Inventory.UpdateProduct(SelectedProduct.ProductId, SelectedProduct);
                    this.Close();
                }
            }
        }
        // form validation
        private void ProductIdInput_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = Int32.TryParse(ProductIdInput.Text, out int requestedNumber);
            if (!isValid || requestedNumber == 0)
            {
                e.Cancel = true;
                ProductIdInput.Focus();
                {
                    pfep.SetError(ProductIdInput, "ID must be a number that is not zero");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(ProductIdInput, "");
            }
        }

        private void ProductInventoryInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(ProductInventoryInput.Text, out _))
            {
                e.Cancel = true;
                ProductInventoryInput.Focus();
                {
                    pfep.SetError(ProductInventoryInput, "Inventory must be a number");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(ProductInventoryInput, "");
            }
        }

        private void ProductPriceInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Decimal.TryParse(ProductPriceInput.Text, out _))
            {
                e.Cancel = true;
                ProductPriceInput.Focus();
                {
                    pfep.SetError(ProductPriceInput, "Price must be a decimal");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(ProductPriceInput, "");
            }
        }

        private void ProductMinInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(ProductMinInput.Text, out _))
            {
                e.Cancel = true;
                ProductMinInput.Focus();
                {
                    pfep.SetError(ProductMinInput, "Min stock must be a number");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(ProductMinInput, "");
            }
        }

        private void ProductMaxInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(ProductMaxInput.Text, out _))
            {
                e.Cancel = true;
                ProductMaxInput.Focus();
                {
                    pfep.SetError(ProductMaxInput, "Max stock must be a number");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(ProductMaxInput, "");
            }
        }
    }
}
