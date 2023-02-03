
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PartsSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddPart = new System.Windows.Forms.Button();
            this.ModifyPart = new System.Windows.Forms.Button();
            this.DeletePart = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.ModifyProduct = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 0;
            // 
            // PartsSearch
            // 
            this.PartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PartsSearch.Location = new System.Drawing.Point(374, 31);
            this.PartsSearch.Name = "PartsSearch";
            this.PartsSearch.Size = new System.Drawing.Size(75, 23);
            this.PartsSearch.TabIndex = 1;
            this.PartsSearch.Text = "Search";
            this.PartsSearch.UseVisualStyleBackColor = true;
            this.PartsSearch.Click += new System.EventHandler(this.button1_Click);
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(409, 262);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.AddPart.Click += new System.EventHandler(this.button3_Click);
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
            this.AddProduct.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 262);
            this.dataGridView1.TabIndex = 14;
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
            // ProductsSearch
            // 
            this.ProductsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ProductsSearch.Location = new System.Drawing.Point(855, 31);
            this.ProductsSearch.Name = "ProductsSearch";
            this.ProductsSearch.Size = new System.Drawing.Size(75, 23);
            this.ProductsSearch.TabIndex = 12;
            this.ProductsSearch.Text = "Search";
            this.ProductsSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(643, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 22);
            this.textBox2.TabIndex = 11;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductsSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DeletePart);
            this.Controls.Add(this.ModifyPart);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PartsSearch;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button ModifyPart;
        private System.Windows.Forms.Button DeletePart;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProductsSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ExitButton;
    }
}

