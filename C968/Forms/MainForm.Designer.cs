
namespace C968
{
    partial class MainForm
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
            this.PartsSearchBox = new System.Windows.Forms.TextBox();
            this.PartsSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PartsGrid = new System.Windows.Forms.DataGridView();
            this.AddPart = new System.Windows.Forms.Button();
            this.ModifyPart = new System.Windows.Forms.Button();
            this.DeletePart = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.ModifyProduct = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsSearchButton = new System.Windows.Forms.Button();
            this.ProductSearchBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Location = new System.Drawing.Point(162, 32);
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.Size = new System.Drawing.Size(206, 22);
            this.PartsSearchBox.TabIndex = 0;
            this.PartsSearchBox.TextChanged += new System.EventHandler(this.PartsSearchBox_TextChanged);
            this.PartsSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartsSearchBox_KeyDown);
            // 
            // PartsSearchButton
            // 
            this.PartsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PartsSearchButton.Location = new System.Drawing.Point(374, 31);
            this.PartsSearchButton.Name = "PartsSearchButton";
            this.PartsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.PartsSearchButton.TabIndex = 1;
            this.PartsSearchButton.Text = "Search";
            this.PartsSearchButton.UseVisualStyleBackColor = true;
            this.PartsSearchButton.Click += new System.EventHandler(this.PartsSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PartsGrid
            // 
            this.PartsGrid.AllowUserToAddRows = false;
            this.PartsGrid.AllowUserToDeleteRows = false;
            this.PartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsGrid.Location = new System.Drawing.Point(40, 65);
            this.PartsGrid.MultiSelect = false;
            this.PartsGrid.Name = "PartsGrid";
            this.PartsGrid.ReadOnly = true;
            this.PartsGrid.RowHeadersWidth = 51;
            this.PartsGrid.RowTemplate.Height = 24;
            this.PartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsGrid.ShowCellErrors = false;
            this.PartsGrid.ShowCellToolTips = false;
            this.PartsGrid.ShowEditingIcon = false;
            this.PartsGrid.Size = new System.Drawing.Size(409, 262);
            this.PartsGrid.TabIndex = 7;
            this.PartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsGrid_CellClick);
            // 
            // AddPart
            // 
            this.AddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddPart.Location = new System.Drawing.Point(243, 333);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(65, 23);
            this.AddPart.TabIndex = 8;
            this.AddPart.Text = "Add";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // ModifyPart
            // 
            this.ModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ModifyPart.Location = new System.Drawing.Point(314, 333);
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(65, 23);
            this.ModifyPart.TabIndex = 9;
            this.ModifyPart.Text = "Modify";
            this.ModifyPart.UseVisualStyleBackColor = true;
            this.ModifyPart.Click += new System.EventHandler(this.ModifyPart_Click);
            // 
            // DeletePart
            // 
            this.DeletePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DeletePart.Location = new System.Drawing.Point(384, 333);
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(65, 23);
            this.DeletePart.TabIndex = 10;
            this.DeletePart.Text = "Delete";
            this.DeletePart.UseVisualStyleBackColor = true;
            this.DeletePart.Click += new System.EventHandler(this.DeletePart_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DeleteProduct.Location = new System.Drawing.Point(865, 333);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(65, 23);
            this.DeleteProduct.TabIndex = 17;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ModifyProduct.Location = new System.Drawing.Point(795, 333);
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Size = new System.Drawing.Size(65, 23);
            this.ModifyProduct.TabIndex = 16;
            this.ModifyProduct.Text = "Modify";
            this.ModifyProduct.UseVisualStyleBackColor = true;
            this.ModifyProduct.Click += new System.EventHandler(this.ModifyProduct_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AddProduct.Location = new System.Drawing.Point(724, 333);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(65, 23);
            this.AddProduct.TabIndex = 15;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AllowUserToAddRows = false;
            this.ProductsGrid.AllowUserToDeleteRows = false;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Location = new System.Drawing.Point(521, 65);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.ReadOnly = true;
            this.ProductsGrid.RowHeadersWidth = 51;
            this.ProductsGrid.RowTemplate.Height = 24;
            this.ProductsGrid.Size = new System.Drawing.Size(409, 262);
            this.ProductsGrid.TabIndex = 14;
            this.ProductsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGrid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(517, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ProductsSearchButton
            // 
            this.ProductsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ProductsSearchButton.Location = new System.Drawing.Point(855, 31);
            this.ProductsSearchButton.Name = "ProductsSearchButton";
            this.ProductsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsSearchButton.TabIndex = 12;
            this.ProductsSearchButton.Text = "Search";
            this.ProductsSearchButton.UseVisualStyleBackColor = true;
            // 
            // ProductSearchBox
            // 
            this.ProductSearchBox.Location = new System.Drawing.Point(643, 33);
            this.ProductSearchBox.Name = "ProductSearchBox";
            this.ProductSearchBox.Size = new System.Drawing.Size(206, 22);
            this.ProductSearchBox.TabIndex = 11;
            this.ProductSearchBox.TextChanged += new System.EventHandler(this.ProductSearchBox_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ExitButton.Location = new System.Drawing.Point(865, 396);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(65, 23);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 443);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.ModifyProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductsSearchButton);
            this.Controls.Add(this.ProductSearchBox);
            this.Controls.Add(this.DeletePart);
            this.Controls.Add(this.ModifyPart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.PartsGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsSearchButton);
            this.Controls.Add(this.PartsSearchBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PartsSearchBox;
        private System.Windows.Forms.Button PartsSearchButton;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button ModifyPart;
        private System.Windows.Forms.Button DeletePart;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.DataGridView ProductsGrid;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProductsSearchButton;
        private System.Windows.Forms.TextBox ProductSearchBox;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.DataGridView PartsGrid;
    }
}

