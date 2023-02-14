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
    public partial class ProductForm : Form
    {
        private static string partsAvailableSearch;
        private static string partsAddedSearch;
        private Part PartsAvailableSelected;
        private Part PartsAddedSelected;

        private BindingList<Part> _productParts;

        public BindingList<Part> ProductParts { get => _productParts; set => _productParts = value; }

        public ProductForm()
        {
            ProductParts = new BindingList<Part>();
            InitializeComponent();
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
            if (partsAvailableSearch.Length > 0)
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
            partsAddedSearch = AddedPartsInput.Text;
            if (partsAddedSearch.Length <= 0)
            {
                PartsAddedGrid.DataSource = ProductParts;
            }
        }

        private void PartsAddedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
