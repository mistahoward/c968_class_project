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
    public partial class MainForm : Form
    {
        // private accessors
        private static int partSelectedId;
        private static int productSelectedId;
        private static string partSearchText;
        private static string productSearchText;
        public MainForm()
        {
            // main form constrcutor - need to make some dummy parts and products for functionality testing
            var dummyPart1 = new OutsourcedPart(1,
                "Trencher",
                3,
                (decimal)0.24,
                100,
                0,
                "Google");
            var dummyPart2 = new OutsourcedPart(
                 2,
                "Liquidator",
                4,
                (decimal)0.44,
                30,
                4,
                "Bing"
            );
            var dummyPart3 = new InHousePart(
                 3,
                "Energizer",
                45,
                (decimal)0.54,
                50,
                20,
                00114544
            );
            var dummyPart4 = new InHousePart(
                 4,
                "Eater",
                3,
                (decimal)0.24,
                100,
                0,
                55765120
            );
            Inventory.AddPart(dummyPart1);
            Inventory.AddPart(dummyPart2);
            Inventory.AddPart(dummyPart3);
            Inventory.AddPart(dummyPart4);

            var dummyProduct1 = new Product(1, "Dummy Product 1", 0, (decimal)3.02, 100, 0);
            dummyProduct1.AddAssociatedPart(dummyPart1);

            var dummyProduct2 = new Product(2, "Dummy Product 2", 100, (decimal)78.2, 100, 0);
            dummyProduct2.AddAssociatedPart(dummyPart1);
            dummyProduct2.AddAssociatedPart(dummyPart4);

            Inventory.AddProduct(dummyProduct1);
            Inventory.AddProduct(dummyProduct2);

            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // on load, set data sources to the binding list in the inventory object
            PartsGrid.DataSource = Inventory.Parts;
            ProductsGrid.DataSource = Inventory.Products;
            // clear selection to remove implicit modify / delete in case a user doesn't realize a row is selected
            PartsGrid.ClearSelection();
            ProductsGrid.ClearSelection();
        }

        // start parts components
        private void PartsSearchBox_TextChanged(object sender, EventArgs e)
        {
            // on text change we assign the partssearchbox to partsSearchText.
            partSearchText = PartsSearchBox.Text;
            if (partSearchText?.Length <= 0)
            {
                // if there is nothing in the search box, reset the "filter" and show all parts
                PartsGrid.DataSource = Inventory.Parts;
            }
        }
        private void PartsSearch_Click(object sender, EventArgs e)
        {
            if (partSearchText?.Length > 0)
            {
                // if partsearch has been defined (nullish check with a ?) and the text is greater than 0, filter:
                // LINQ method for grabbing parts where the part name (lower cased) contains the search text (also lowercased)
                // then we store it in memory so we can bind it to the data grid
                var partsWithMatchingName = Inventory.Parts
                    .Where(p => p.Name.ToLower().Contains(partSearchText.ToLower())).ToList();
                PartsGrid.DataSource = partsWithMatchingName;
            }
        }
        private void PartsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // this method is used to grab the part ID to pass it to child forms
            DataGridViewRow rowSelected = PartsGrid.CurrentRow;
            partSelectedId = (int)rowSelected.Cells[0].Value;
        }
        private void PartsSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            // not a necessary function, but a helpful one (qol) - if the user is in the parts search box and the search isn't empty
            // and they hit enter, treat it as if they clicked the search button
            if (e.KeyCode == Keys.Enter && partSearchText?.Length > 0)
            {
                PartsSearchButton.PerformClick();
            }
        }
        private void AddPart_Click(object sender, EventArgs e)
        {
            // PartForm Constructor for adding a part, using an enum to take advantage of IDE and prevent typos
            PartForm partsForm = new PartForm(Operation.adding);
            partsForm.PartFormTitle.Text = "Add Part";
            partsForm.SaveButton.Text = "Add";
            partsForm.ShowDialog();
        }
        private void ModifyPart_Click(object sender, EventArgs e)
        {
            // PartForm construtor for modifying a part. Check if user has selected a part first. If not, throw an error - otherwise...
            // construct the part form for modifying the part
            if (partSelectedId > 0)
            {
                PartForm partsForm = new PartForm(
             Operation.updating,
             partSelectedId);
                partsForm.PartFormTitle.Text = "Modify Part";
                partsForm.SaveButton.Text = "Save";
                partsForm.ShowDialog();
            } else
            {
                MessageBox.Show("Please select a part before attempting modification.", "No Part Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DeletePart_Click(object sender, EventArgs e)
        {
            // Delete part method - check if the user has selected a part first - if not, throw an error, otherwise...
            // delete part from inventory object
            if (partSelectedId > 0)
            {
                // confirm check to make sure user actually meant to delete the part
                var confirmResult = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var partToDelete = Inventory.LookupPart(partSelectedId);
                    Inventory.DeletePart(partToDelete);
                }
            } else
            {
                MessageBox.Show("Please select a part before attempting delete.", "No Part Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        // end parts, start product components
        private void AddProduct_Click(object sender, EventArgs e)
        {
            // product form constructor, same methodology as add parts
            ProductForm productsForm = new ProductForm(Operation.adding);
            productsForm.ProductFormTitle.Text = "Add Product";
            productsForm.SaveButton.Text = "Add";
            productsForm.ShowDialog();
        }
        private void ModifyProduct_Click(object sender, EventArgs e)
        {
            // modify product method, same methodology as parts
            if (productSelectedId > 0)
            {
                ProductForm productsForm = new ProductForm(Operation.updating, productSelectedId);
                productsForm.ProductFormTitle.Text = "Modify Product";
                productsForm.SaveButton.Text = "Save";
                productsForm.ShowDialog();
            } else
            {
                MessageBox.Show("Please select a product before attempting modification.", "No Product Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            // Delete product - same methodology as delete parts BUT also we check to make sure there are no associated parts before removing product
            if (productSelectedId > 0)
            {
                var selectedProduct = Inventory.LookupProduct(productSelectedId);
                var associatedParts = selectedProduct.AssociatedParts;
                if (associatedParts.Count <= 0)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Inventory.RemoveProduct(productSelectedId);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please remove all parts from selected product before deleting.", "Product Has Parts Associated",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product before attempting delete.", "No Product Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProductSearchBox_TextChanged(object sender, EventArgs e)
        {
            // same method as parts search box
            productSearchText = ProductSearchBox.Text;
            if (productSearchText?.Length <= 0)
            {
                ProductsGrid.DataSource = Inventory.Products;
            }
        }

        private void ProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // same method as parts grid
            DataGridViewRow rowSelected = ProductsGrid.CurrentRow;
            productSelectedId = (int)rowSelected.Cells[0].Value;
        }

        private void ProductsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // I had some trouble with the product grid view auto selecting once a product is added - we clear selection on a data binding complete
            // to remove implicit actions (user not accidentally modifying a product when they didn't realize they had it selected)
            ProductsGrid.ClearSelection();
        }

        private void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            // same method as parts search
            if (productSearchText?.Length > 0)
            {
                var productsWithMatchingNames = Inventory.Products
                       .Where(p => p.Name.ToLower().Contains(productSearchText.ToLower())).ToList();
                PartsGrid.DataSource = productsWithMatchingNames;
            }
        }
        private void ProductSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            // same qol function for products search that we have for parts
            if (e.KeyCode == Keys.Enter && productSearchText?.Length > 0)
            {
                ProductsSearchButton.PerformClick();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // exit button - simple enough - close existing object
            this.Close();
        }
    }
}
