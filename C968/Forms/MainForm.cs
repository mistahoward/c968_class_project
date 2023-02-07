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

namespace C968
{
    public partial class MainForm : Form
    {
        private static Part partSelected;
        private static Product productSelected;

        public MainForm()
        {
            var dummyPart1 = new OutsourcedPart(
                             1,
                            "Trencher",
                            3,
                            0.24,
                            100,
                            0,
                            "Google"
                        );
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            PartsGrid.DataSource = Inventory.Parts;
            ProductsGrid.DataSource = Inventory.Products;
        }

        private void PartsSearch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            PartForm partsForm = new PartForm();
            partsForm.adding = true;
            partsForm.label1.Text = "Add Part";
            partsForm.PartSave.Text = "Add";
            partsForm.ShowDialog();
        }
        private void ModifyPart_Click(object sender, EventArgs e)
        {
            PartForm partsForm = new PartForm();
            partsForm.updating = true;
            partsForm.label1.Text = "Modify Part";
            partsForm.PartSave.Text = "Save";
            partsForm.ShowDialog();

        }
        private void DeletePart_Click(object sender, EventArgs e)
        {

        }

        private void PartsGrid_Click(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductForm productsForm = new ProductForm();
            productsForm.ProductFormTitle.Text = "Add Product";
            productsForm.ShowDialog();
        }

        private void ModifyProduct_Click(object sender, EventArgs e)
        {

        }
        private void ProductGrid_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {

        }


        private void PartsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
