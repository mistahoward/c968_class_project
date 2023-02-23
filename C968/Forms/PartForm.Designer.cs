
namespace C968
{
    partial class PartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InHouse = new System.Windows.Forms.RadioButton();
            this.Outsourced = new System.Windows.Forms.RadioButton();
            this.PartFormTitle = new System.Windows.Forms.Label();
            this.PartIdInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PartNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PartInventoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PartPriceInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PartMinInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PartMaxInput = new System.Windows.Forms.TextBox();
            this.PartExtraLabel = new System.Windows.Forms.Label();
            this.PartExtraInput = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PartExit = new System.Windows.Forms.Button();
            this.pfep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pfep)).BeginInit();
            this.SuspendLayout();
            // 
            // InHouse
            // 
            this.InHouse.AutoSize = true;
            this.InHouse.Location = new System.Drawing.Point(126, 11);
            this.InHouse.Name = "InHouse";
            this.InHouse.Size = new System.Drawing.Size(86, 21);
            this.InHouse.TabIndex = 0;
            this.InHouse.TabStop = true;
            this.InHouse.Text = "In-House";
            this.InHouse.UseVisualStyleBackColor = true;
            this.InHouse.CheckedChanged += new System.EventHandler(this.InHouse_CheckedChanged);
            // 
            // Outsourced
            // 
            this.Outsourced.AutoSize = true;
            this.Outsourced.Location = new System.Drawing.Point(229, 11);
            this.Outsourced.Name = "Outsourced";
            this.Outsourced.Size = new System.Drawing.Size(103, 21);
            this.Outsourced.TabIndex = 1;
            this.Outsourced.TabStop = true;
            this.Outsourced.Text = "Outsourced";
            this.Outsourced.UseVisualStyleBackColor = true;
            this.Outsourced.CheckedChanged += new System.EventHandler(this.Outsource_CheckedChanged);
            // 
            // PartFormTitle
            // 
            this.PartFormTitle.AutoSize = true;
            this.PartFormTitle.Location = new System.Drawing.Point(13, 13);
            this.PartFormTitle.Name = "PartFormTitle";
            this.PartFormTitle.Size = new System.Drawing.Size(108, 17);
            this.PartFormTitle.TabIndex = 2;
            this.PartFormTitle.Text = "Add/Modify Part";
            // 
            // PartIdInput
            // 
            this.PartIdInput.Enabled = false;
            this.PartIdInput.Location = new System.Drawing.Point(20, 71);
            this.PartIdInput.Name = "PartIdInput";
            this.PartIdInput.Size = new System.Drawing.Size(100, 22);
            this.PartIdInput.TabIndex = 3;
            this.PartIdInput.Validating += new System.ComponentModel.CancelEventHandler(this.PartIdInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // PartNameInput
            // 
            this.PartNameInput.Location = new System.Drawing.Point(174, 71);
            this.PartNameInput.Name = "PartNameInput";
            this.PartNameInput.Size = new System.Drawing.Size(100, 22);
            this.PartNameInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inventory";
            // 
            // PartInventoryInput
            // 
            this.PartInventoryInput.Location = new System.Drawing.Point(21, 127);
            this.PartInventoryInput.Name = "PartInventoryInput";
            this.PartInventoryInput.Size = new System.Drawing.Size(100, 22);
            this.PartInventoryInput.TabIndex = 7;
            this.PartInventoryInput.Validating += new System.ComponentModel.CancelEventHandler(this.PartInventoryInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price / Cost";
            // 
            // PartPriceInput
            // 
            this.PartPriceInput.Location = new System.Drawing.Point(174, 127);
            this.PartPriceInput.Name = "PartPriceInput";
            this.PartPriceInput.Size = new System.Drawing.Size(100, 22);
            this.PartPriceInput.TabIndex = 9;
            this.PartPriceInput.Validating += new System.ComponentModel.CancelEventHandler(this.PartPriceInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Min";
            // 
            // PartMinInput
            // 
            this.PartMinInput.Location = new System.Drawing.Point(21, 185);
            this.PartMinInput.Name = "PartMinInput";
            this.PartMinInput.Size = new System.Drawing.Size(100, 22);
            this.PartMinInput.TabIndex = 11;
            this.PartMinInput.Validating += new System.ComponentModel.CancelEventHandler(this.PartMinInput_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max";
            // 
            // PartMaxInput
            // 
            this.PartMaxInput.Location = new System.Drawing.Point(174, 185);
            this.PartMaxInput.Name = "PartMaxInput";
            this.PartMaxInput.Size = new System.Drawing.Size(100, 22);
            this.PartMaxInput.TabIndex = 13;
            this.PartMaxInput.Validating += new System.ComponentModel.CancelEventHandler(this.PartMaxInput_Validating);
            // 
            // PartExtraLabel
            // 
            this.PartExtraLabel.AutoSize = true;
            this.PartExtraLabel.Location = new System.Drawing.Point(18, 221);
            this.PartExtraLabel.Name = "PartExtraLabel";
            this.PartExtraLabel.Size = new System.Drawing.Size(190, 17);
            this.PartExtraLabel.TabIndex = 16;
            this.PartExtraLabel.Text = "Machine ID / Company Name";
            // 
            // PartExtraInput
            // 
            this.PartExtraInput.Location = new System.Drawing.Point(21, 240);
            this.PartExtraInput.Name = "PartExtraInput";
            this.PartExtraInput.Size = new System.Drawing.Size(253, 22);
            this.PartExtraInput.TabIndex = 15;
            this.PartExtraInput.Validating += new System.ComponentModel.CancelEventHandler(this.PartExtraInput_Validating);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(288, 297);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.PartSave_Click);
            // 
            // PartExit
            // 
            this.PartExit.Location = new System.Drawing.Point(199, 297);
            this.PartExit.Name = "PartExit";
            this.PartExit.Size = new System.Drawing.Size(75, 23);
            this.PartExit.TabIndex = 18;
            this.PartExit.Text = "Exit";
            this.PartExit.UseVisualStyleBackColor = true;
            this.PartExit.Click += new System.EventHandler(this.PartExit_Click);
            // 
            // pfep
            // 
            this.pfep.ContainerControl = this;
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 333);
            this.Controls.Add(this.PartExit);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PartExtraLabel);
            this.Controls.Add(this.PartExtraInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PartMaxInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PartMinInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PartPriceInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PartInventoryInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PartNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PartIdInput);
            this.Controls.Add(this.PartFormTitle);
            this.Controls.Add(this.Outsourced);
            this.Controls.Add(this.InHouse);
            this.Name = "PartForm";
            this.Text = "PartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pfep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton InHouse;
        private System.Windows.Forms.RadioButton Outsourced;
        private System.Windows.Forms.TextBox PartIdInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PartNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PartInventoryInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PartPriceInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PartMinInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PartMaxInput;
        private System.Windows.Forms.Label PartExtraLabel;
        private System.Windows.Forms.TextBox PartExtraInput;
        private System.Windows.Forms.Button PartExit;
        public System.Windows.Forms.Label PartFormTitle;
        public System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ErrorProvider pfep;
    }
}