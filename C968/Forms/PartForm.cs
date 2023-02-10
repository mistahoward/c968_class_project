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
        private int _selectedPartId;
        private Part _selectedPart;
        private Operation _partOperation;
        private PartTypes _selectedPartType;
        
        public Operation PartOperation { get => _partOperation; set => _partOperation = value; }
        public PartTypes SelectedPartType { get => _selectedPartType; set => _selectedPartType = value; }
        public int SelectedPartId { get => _selectedPartId; set => _selectedPartId = value; }
        public Part SelectedPart { get => _selectedPart; set => _selectedPart = value; }

        public PartForm(Operation operation, int selectedPartId = 0)
        {
            SelectedPartId = selectedPartId;
            PartOperation = operation;
            InitializeComponent();
            if (operation == Operation.updating)
            {
                var selectedPartResult = Inventory.Parts.Where(p => p.PartId == selectedPartId);
                SelectedPart = selectedPartResult.Single();
                SelectedPartType = (PartTypes)Enum.Parse(typeof(PartTypes), SelectedPart.GetType().Name);
                PartIdInput.Text = SelectedPart.PartId.ToString();
                PartNameInput.Text = SelectedPart.Name;
                PartInventoryInput.Text = SelectedPart.InStock.ToString();
                PartPriceInput.Text = SelectedPart.Price.ToString();
                PartMinInput.Text = SelectedPart.Min.ToString();
                PartMaxInput.Text = SelectedPart.Max.ToString();
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
