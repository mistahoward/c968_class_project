﻿using C968.Classes;
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
                var selectedPart = Inventory.LookupPart(selectedPartId);
                SelectedPartType = (PartTypes)Enum.Parse(typeof(PartTypes), selectedPart.GetType().Name);
                PartIdInput.Text = selectedPart.PartId.ToString();
                PartNameInput.Text = selectedPart.Name;
                PartInventoryInput.Text = selectedPart.InStock.ToString();
                PartPriceInput.Text = selectedPart.Price.ToString();
                PartMinInput.Text = selectedPart.Min.ToString();
                PartMaxInput.Text = selectedPart.Max.ToString();
                if (SelectedPartType == PartTypes.InHousePart)
                {
                    var inHousePart = (InHousePart)selectedPart;
                    PartExtraInput.Text = inHousePart.MachineId.ToString();
                } else
                {
                    var outsourcedPart = (OutsourcedPart)selectedPart;
                    PartExtraInput.Text = outsourcedPart.CompanyName;
                }
            }
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
                && !string.IsNullOrEmpty(PartExtraInput.Text))
            {
                int min = Convert.ToInt32(PartMinInput.Text);
                int max = Convert.ToInt32(PartMaxInput.Text);
                int inventory = Convert.ToInt32(PartInventoryInput.Text);
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
                if (PartOperation == Operation.adding)
                {
                    if (SelectedPartType == PartTypes.OutsourcedPart)
                    {
                        var partToAdd = new OutsourcedPart(
                            Convert.ToInt32(PartIdInput.Text), 
                            PartNameInput.Text, 
                            inventory,
                            Convert.ToDecimal(PartPriceInput.Text), 
                            max,
                            min,
                            PartExtraInput.Text
                        );
                        Inventory.AddPart(partToAdd);
                        this.Close();
                    } else if (SelectedPartType == PartTypes.InHousePart)
                    {
                        var partToAdd = new InHousePart (
                            Convert.ToInt32(PartIdInput.Text),
                            PartNameInput.Text,
                            inventory,
                            Convert.ToDecimal(PartPriceInput.Text),
                            max,
                            min,
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
        private void PartExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartIdInput_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = Int32.TryParse(PartIdInput.Text, out int requestedNumber);
            if (!isValid || requestedNumber == 0)
            {
                e.Cancel = true;
                PartIdInput.Focus();
                {
                    pfep.SetError(PartIdInput, "ID must be a number that is not zero");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(PartIdInput, "");
            }
        }

        private void PartInventoryInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(PartInventoryInput.Text, out _))
            {
                e.Cancel = true;
                PartInventoryInput.Focus();
                {
                    pfep.SetError(PartInventoryInput, "Inventory must be a number");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(PartInventoryInput, "");
            }
        }

        private void PartPriceInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Decimal.TryParse(PartPriceInput.Text, out _))
            {
                e.Cancel = true;
                PartPriceInput.Focus();
                {
                    pfep.SetError(PartPriceInput, "Price must be a decimal");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(PartPriceInput, "");
            }
        }

        private void PartMinInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(PartMinInput.Text, out _))
            {
                e.Cancel = true;
                PartMinInput.Focus();
                {
                    pfep.SetError(PartMinInput, "Min stock must be a number");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(PartMinInput, "");
            }
        }

        private void PartMaxInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(PartMaxInput.Text, out _))
            {
                e.Cancel = true;
                PartMaxInput.Focus();
                {
                    pfep.SetError(PartMaxInput, "Max stock must be a number");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(PartMaxInput, "");
            }
        }

        private void PartExtraInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Int32.TryParse(PartExtraInput.Text, out _) && SelectedPartType == PartTypes.InHousePart)
            {
                e.Cancel = true;
                PartExtraInput.Focus();
                {
                    pfep.SetError(PartExtraInput, "Machine ID must be a number");
                }
            }
            else
            {
                e.Cancel = false;
                pfep.SetError(PartExtraInput, "");
            }
        }
    }
}
