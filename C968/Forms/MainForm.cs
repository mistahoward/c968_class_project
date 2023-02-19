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
        private static int partSelectedId;
        private static int productSelectedId;
        private static string partSearchText;
        private static string productSearchText;

        public MainForm()
        {
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
            PartsGrid.DataSource = Inventory.Parts;
            ProductsGrid.DataSource = Inventory.Products;
            PartsGrid.ClearSelection();
            ProductsGrid.ClearSelection();
        }

        private void PartsSearch_Click(object sender, EventArgs e)
        {
            if (partSearchText.Length > 0)
            {
                var partsWithMatchingName = Inventory.Parts.Where(p => p.Name.ToLower().Contains(partSearchText.ToLower())).ToList();
                PartsGrid.DataSource = partsWithMatchingName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            PartForm partsForm = new PartForm(Operation.adding);
            partsForm.label1.Text = "Add Part";
            partsForm.PartSave.Text = "Add";
            partsForm.ShowDialog();
        }
        private void ModifyPart_Click(object sender, EventArgs e)
        {
            if (partSelectedId > 0)
            {
                PartForm partsForm = new PartForm(
             Operation.updating,
             partSelectedId);
                partsForm.label1.Text = "Modify Part";
                partsForm.PartSave.Text = "Save";
                partsForm.ShowDialog();
            } else
            {
                // select part first dialogue
            }

        }
        private void DeletePart_Click(object sender, EventArgs e)
        {
            if (partSelectedId > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo);
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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductForm productsForm = new ProductForm(Operation.adding);
            productsForm.ProductFormTitle.Text = "Add Product";
            productsForm.SaveButton.Text = "Add";
            productsForm.ShowDialog();
        }
        private void ModifyProduct_Click(object sender, EventArgs e)
        {
            if (productSelectedId > 0)
            {
                ProductForm productsForm = new ProductForm(Operation.updating, productSelectedId);
                productsForm.ProductFormTitle.Text = "Modify Product";
                productsForm.SaveButton.Text = "Save";
                productsForm.ShowDialog();
            } else
            {
                // select product first dialogue
            }
            
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {

        }


        private void PartsSearchBox_TextChanged(object sender, EventArgs e)
        {
            partSearchText = PartsSearchBox.Text;
            if (partSearchText.Length <= 0)
            {
                PartsGrid.DataSource = Inventory.Parts;
            }
        }

        private void ProductSearchBox_TextChanged(object sender, EventArgs e)
        {
            productSearchText = ProductSearchBox.Text;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PartsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowSelected = PartsGrid.CurrentRow;
            partSelectedId = (int)rowSelected.Cells[0].Value;
        }

        private void PartsSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && partSearchText.Length > 0)
            {
                PartsSearchButton.PerformClick();
            }
        }

        private void ProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowSelected = ProductsGrid.CurrentRow;
            productSelectedId = (int)rowSelected.Cells[0].Value;
        }

        private void ProductsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductsGrid.ClearSelection();
        }
    }
}
