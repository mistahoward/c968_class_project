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
        bool inHouse = false;
        bool outSourced = false;
        public bool updating = false;
        public bool adding = false;

        public PartForm()
        {
            InitializeComponent();
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
            outSourced = true;
            inHouse = false;
        }

        private void InHouse_CheckedChanged(object sender, EventArgs e)
        {
            PartExtraLabel.Text = "Machine ID";
            outSourced = false;
            inHouse = true;
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
                && !string.IsNullOrEmpty(PartInStockInput.Text)
                && !string.IsNullOrEmpty(PartInventoryInput.Text)
                && !string.IsNullOrEmpty(PartExtraInput.Text))
            {
                if (adding)
                {
                    if (outSourced)
                    {
                        var partToAdd = new OutsourcedPart(
                            Convert.ToInt32(PartIdInput.Text), 
                            PartNameInput.Text, 
                            Convert.ToInt32(PartInStockInput.Text),
                            Convert.ToDecimal(PartPriceInput.Text), 
                            Convert.ToInt32(PartMaxInput.Text),
                            Convert.ToInt32(PartMinInput.Text),
                            PartExtraInput.Text
                        );
                        Inventory.AddPart(partToAdd);
                        this.Close();
                    } else if (inHouse)
                    {
                        var partToAdd = new InHousePart (
                            Convert.ToInt32(PartIdInput.Text),
                            PartNameInput.Text,
                            Convert.ToInt32(PartInStockInput.Text),
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
                MessageBox.Show($"While trying to {(adding ? "add" : "modify")} the part, we found some missing values. Please check your inputs and try again.", "Missing Values",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
