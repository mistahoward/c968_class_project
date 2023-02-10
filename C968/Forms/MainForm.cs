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
            PartForm partsForm = new PartForm(PartForm.Operation.adding);
            partsForm.label1.Text = "Add Part";
            partsForm.PartSave.Text = "Add";
            partsForm.ShowDialog();
        }
        private void ModifyPart_Click(object sender, EventArgs e)
        {
            PartForm partsForm = new PartForm(
                PartForm.Operation.updating,
                partSelected);
            partsForm.label1.Text = "Modify Part";
            partsForm.PartSave.Text = "Save";
            partsForm.ShowDialog();

        }
        private void DeletePart_Click(object sender, EventArgs e)
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

        private void PartsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            partSelected = Inventory.Parts[e.RowIndex + 1];
        }
    }
}
