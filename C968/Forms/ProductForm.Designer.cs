
namespace C968
{
    partial class ProductForm
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
            this.ProductFormTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductIdInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductInventoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPriceInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductMinInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductMaxInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PartsAddedButton = new System.Windows.Forms.Button();
            this.AddedPartsInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PartsAvailableButton = new System.Windows.Forms.Button();
            this.PartsAvailableInput = new System.Windows.Forms.TextBox();
            this.AddPart = new System.Windows.Forms.Button();
            this.DeletePart = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProductCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductFormTitle
            // 
            this.ProductFormTitle.AutoSize = true;
            this.ProductFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductFormTitle.Location = new System.Drawing.Point(13, 13);
            this.ProductFormTitle.Name = "ProductFormTitle";
            this.ProductFormTitle.Size = new System.Drawing.Size(165, 20);
            this.ProductFormTitle.TabIndex = 0;
            this.ProductFormTitle.Text = "Modify / Add Product";
            this.ProductFormTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // ProductIdInput
            // 
            this.ProductIdInput.Location = new System.Drawing.Point(16, 74);
            this.ProductIdInput.Name = "ProductIdInput";
            this.ProductIdInput.Size = new System.Drawing.Size(100, 22);
            this.ProductIdInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.Location = new System.Drawing.Point(16, 130);
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(100, 22);
            this.ProductNameInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inventory";
            // 
            // ProductInventoryInput
            // 
            this.ProductInventoryInput.Location = new System.Drawing.Point(16, 186);
            this.ProductInventoryInput.Name = "ProductInventoryInput";
            this.ProductInventoryInput.Size = new System.Drawing.Size(100, 22);
            this.ProductInventoryInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // ProductPriceInput
            // 
            this.ProductPriceInput.Location = new System.Drawing.Point(16, 242);
            this.ProductPriceInput.Name = "ProductPriceInput";
            this.ProductPriceInput.Size = new System.Drawing.Size(100, 22);
            this.ProductPriceInput.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Min";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProductMinInput
            // 
            this.ProductMinInput.Location = new System.Drawing.Point(16, 298);
            this.ProductMinInput.Name = "ProductMinInput";
            this.ProductMinInput.Size = new System.Drawing.Size(100, 22);
            this.ProductMinInput.TabIndex = 13;
            this.ProductMinInput.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Max";
            // 
            // ProductMaxInput
            // 
            this.ProductMaxInput.Location = new System.Drawing.Point(16, 358);
            this.ProductMaxInput.Name = "ProductMaxInput";
            this.ProductMaxInput.Size = new System.Drawing.Size(100, 22);
            this.ProductMaxInput.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(251, 245);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(537, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(251, 245);
            this.dataGridView2.TabIndex = 18;
            // 
            // PartsAddedButton
            // 
            this.PartsAddedButton.Location = new System.Drawing.Point(713, 73);
            this.PartsAddedButton.Name = "PartsAddedButton";
            this.PartsAddedButton.Size = new System.Drawing.Size(75, 23);
            this.PartsAddedButton.TabIndex = 22;
            this.PartsAddedButton.Text = "Search";
            this.PartsAddedButton.UseVisualStyleBackColor = true;
            // 
            // AddedPartsInput
            // 
            this.AddedPartsInput.Location = new System.Drawing.Point(537, 74);
            this.AddedPartsInput.Name = "AddedPartsInput";
            this.AddedPartsInput.Size = new System.Drawing.Size(170, 22);
            this.AddedPartsInput.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Parts Available To Add";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Added Parts";
            // 
            // PartsAvailableButton
            // 
            this.PartsAvailableButton.Location = new System.Drawing.Point(431, 73);
            this.PartsAvailableButton.Name = "PartsAvailableButton";
            this.PartsAvailableButton.Size = new System.Drawing.Size(75, 23);
            this.PartsAvailableButton.TabIndex = 26;
            this.PartsAvailableButton.Text = "Search";
            this.PartsAvailableButton.UseVisualStyleBackColor = true;
            // 
            // PartsAvailableInput
            // 
            this.PartsAvailableInput.Location = new System.Drawing.Point(255, 74);
            this.PartsAvailableInput.Name = "PartsAvailableInput";
            this.PartsAvailableInput.Size = new System.Drawing.Size(170, 22);
            this.PartsAvailableInput.TabIndex = 25;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(428, 361);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(75, 23);
            this.AddPart.TabIndex = 27;
            this.AddPart.Text = "Add";
            this.AddPart.UseVisualStyleBackColor = true;
            // 
            // DeletePart
            // 
            this.DeletePart.Location = new System.Drawing.Point(713, 361);
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(75, 23);
            this.DeletePart.TabIndex = 28;
            this.DeletePart.Text = "Delete";
            this.DeletePart.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(713, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ProductCancelButton
            // 
            this.ProductCancelButton.Location = new System.Drawing.Point(632, 415);
            this.ProductCancelButton.Name = "ProductCancelButton";
            this.ProductCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ProductCancelButton.TabIndex = 30;
            this.ProductCancelButton.Text = "Cancel";
            this.ProductCancelButton.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeletePart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.PartsAvailableButton);
            this.Controls.Add(this.PartsAvailableInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PartsAddedButton);
            this.Controls.Add(this.AddedPartsInput);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductMaxInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductMinInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductPriceInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductInventoryInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductIdInput);
            this.Controls.Add(this.ProductFormTitle);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button PartsAddedButton;
        private System.Windows.Forms.TextBox AddedPartsInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button PartsAvailableButton;
        private System.Windows.Forms.TextBox PartsAvailableInput;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button DeletePart;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ProductCancelButton;
        public System.Windows.Forms.Label ProductFormTitle;
        public System.Windows.Forms.TextBox ProductIdInput;
        public System.Windows.Forms.TextBox ProductNameInput;
        public System.Windows.Forms.TextBox ProductInventoryInput;
        public System.Windows.Forms.TextBox ProductPriceInput;
        public System.Windows.Forms.TextBox ProductMinInput;
        public System.Windows.Forms.TextBox ProductMaxInput;
    }
}