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
    public partial class PartForm : Form
    {
        public enum Operation
        {
            adding,
            updating
        }
        public enum PartTypes
        {
            InHousePart,
            OutsourcedPart
        }
        private Operation _partOperation;
        private PartTypes _selectedPartType;
        
        public Operation PartOperation { get => _partOperation; set => _partOperation = value; }
        public PartTypes SelectedPartType { get => _selectedPartType; set => _selectedPartType = value; }

        public PartForm(Operation operation, int selectedPartId = 0)
        {
            PartOperation = operation;
            InitializeComponent();
            if (operation == Operation.updating)
            {
                var selectedPart = Inventory.Parts.Where(p => p.PartId == selectedPartId).First();
                SelectedPartType = (PartTypes)Enum.Parse(typeof(PartTypes), selectedPart.GetType().Name);
                PartIdInput.Text = selectedPart.PartId.ToString();
                PartNameInput.Text = selectedPart.Name;
                PartInventoryInput.Text = selectedPart.InStock.ToString();
                PartPriceInput.Text = selectedPart.Price.ToString();
                PartMinInput.Text = selectedPart.Min.ToString();
                PartMaxInput.Text = selectedPart.Max.ToString();
                if (SelectedPartType == PartTypes.InHousePart)
                {
                    //PartExtraInput.Text = SelectedPart.MachineId.ToString();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PartExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Outsource_CheckedChanged(object sender, EventArgs e)
        {
            PartExtraLabel.Text = "Company Name";
            SelectedPartType = PartTypes.OutsourcedPart;
        }

        private void InHouse_CheckedChanged(object sender, EventArgs e)
        {
            PartExtraLabel.Text = "Machine ID";
            SelectedPartType = PartTypes.InHousePart;
        }

        private void PartExtraLabel_Click(object sender, EventArgs e)
        {
        }

        private void PartSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PartIdInput.Text)
                && !string.IsNullOrEmpty(PartNameInput.Text)
                && !string.IsNullOrEmpty(PartPriceInput.Text)
                && !string.IsNullOrEmpty(PartMaxInput.Text)
                && !string.IsNullOrEmpty(PartMinInput.Text)
                && !string.IsNullOrEmpty(PartInventoryInput.Text)
                && !string.IsNullOrEmpty(PartInventoryInput.Text)
                && !string.IsNullOrEmpty(PartExtraInput.Text))
            {
                if (PartOperation == Operation.adding)
                {
                    if (SelectedPartType == PartTypes.OutsourcedPart)
                    {
                        var partToAdd = new OutsourcedPart(
                            Convert.ToInt32(PartIdInput.Text), 
                            PartNameInput.Text, 
                            Convert.ToInt32(PartInventoryInput.Text),
                            Convert.ToDecimal(PartPriceInput.Text), 
                            Convert.ToInt32(PartMaxInput.Text),
                            Convert.ToInt32(PartMinInput.Text),
                            PartExtraInput.Text
                        );
                        Inventory.AddPart(partToAdd);
                        this.Close();
                    } else if (SelectedPartType == PartTypes.InHousePart)
                    {
                        var partToAdd = new InHousePart (
                            Convert.ToInt32(PartIdInput.Text),
                            PartNameInput.Text,
                            Convert.ToInt32(PartInventoryInput.Text),
                            Convert.ToDecimal(PartPriceInput.Text),
                            Convert.ToInt32(PartMaxInput.Text),
                            Convert.ToInt32(PartMinInput.Text),
                            Convert.ToInt32(PartExtraInput.Text)
                        );
                        Inventory.AddPart(partToAdd);
                        this.Close();
                    }
                }
            } else
            {
                MessageBox.Show($"While trying to {PartOperation} the part, we found some missing values. Please check your inputs and try again.", "Missing Values",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
