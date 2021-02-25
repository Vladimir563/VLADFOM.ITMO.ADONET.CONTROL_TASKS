
namespace VLADFOM.ITMO.ADONET.Lab3LINQXML
{
    partial class SchoolProductsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSchoolProductsBase = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProductCompany = new System.Windows.Forms.Button();
            this.checkBoxIsThisNewProduct = new System.Windows.Forms.CheckBox();
            this.comboBoxProductsCompanyName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSchoolGoods = new System.Windows.Forms.RadioButton();
            this.radioButtonShoes = new System.Windows.Forms.RadioButton();
            this.radioButtonClothes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProductsSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductWeight = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductCompanyName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteDataToXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchoolProductsBase)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSchoolProductsBase
            // 
            this.dataGridViewSchoolProductsBase.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewSchoolProductsBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchoolProductsBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSchoolProductsBase.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSchoolProductsBase.Name = "dataGridViewSchoolProductsBase";
            this.dataGridViewSchoolProductsBase.Size = new System.Drawing.Size(474, 148);
            this.dataGridViewSchoolProductsBase.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Yellow;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAddProduct.FlatAppearance.BorderSize = 2;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(341, 101);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(121, 32);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 2;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Location = new System.Drawing.Point(342, 338);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(120, 32);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Удалить товар";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProductCompany
            // 
            this.btnAddProductCompany.BackColor = System.Drawing.Color.Yellow;
            this.btnAddProductCompany.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAddProductCompany.FlatAppearance.BorderSize = 2;
            this.btnAddProductCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductCompany.Location = new System.Drawing.Point(12, 338);
            this.btnAddProductCompany.Name = "btnAddProductCompany";
            this.btnAddProductCompany.Size = new System.Drawing.Size(155, 32);
            this.btnAddProductCompany.TabIndex = 12;
            this.btnAddProductCompany.Text = "Добавить поставщика";
            this.btnAddProductCompany.UseVisualStyleBackColor = false;
            this.btnAddProductCompany.Click += new System.EventHandler(this.btnAddProductCompany_Click);
            // 
            // checkBoxIsThisNewProduct
            // 
            this.checkBoxIsThisNewProduct.AutoSize = true;
            this.checkBoxIsThisNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIsThisNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIsThisNewProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBoxIsThisNewProduct.Location = new System.Drawing.Point(12, 110);
            this.checkBoxIsThisNewProduct.Name = "checkBoxIsThisNewProduct";
            this.checkBoxIsThisNewProduct.Size = new System.Drawing.Size(117, 21);
            this.checkBoxIsThisNewProduct.TabIndex = 9;
            this.checkBoxIsThisNewProduct.Text = "Это новинка";
            this.checkBoxIsThisNewProduct.UseVisualStyleBackColor = true;
            // 
            // comboBoxProductsCompanyName
            // 
            this.comboBoxProductsCompanyName.FormattingEnabled = true;
            this.comboBoxProductsCompanyName.Location = new System.Drawing.Point(180, 34);
            this.comboBoxProductsCompanyName.Name = "comboBoxProductsCompanyName";
            this.comboBoxProductsCompanyName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductsCompanyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поставщик:";
            // 
            // radioButtonSchoolGoods
            // 
            this.radioButtonSchoolGoods.AutoSize = true;
            this.radioButtonSchoolGoods.Location = new System.Drawing.Point(12, 38);
            this.radioButtonSchoolGoods.Name = "radioButtonSchoolGoods";
            this.radioButtonSchoolGoods.Size = new System.Drawing.Size(166, 17);
            this.radioButtonSchoolGoods.TabIndex = 6;
            this.radioButtonSchoolGoods.TabStop = true;
            this.radioButtonSchoolGoods.Text = "Школьные принадлежности";
            this.radioButtonSchoolGoods.UseVisualStyleBackColor = true;
            this.radioButtonSchoolGoods.CheckedChanged += new System.EventHandler(this.radioButtonSchoolGoods_CheckedChanged);
            // 
            // radioButtonShoes
            // 
            this.radioButtonShoes.AutoSize = true;
            this.radioButtonShoes.Location = new System.Drawing.Point(12, 61);
            this.radioButtonShoes.Name = "radioButtonShoes";
            this.radioButtonShoes.Size = new System.Drawing.Size(56, 17);
            this.radioButtonShoes.TabIndex = 7;
            this.radioButtonShoes.TabStop = true;
            this.radioButtonShoes.Text = "Обувь";
            this.radioButtonShoes.UseVisualStyleBackColor = true;
            this.radioButtonShoes.CheckedChanged += new System.EventHandler(this.radioButtonShoes_CheckedChanged);
            // 
            // radioButtonClothes
            // 
            this.radioButtonClothes.AutoSize = true;
            this.radioButtonClothes.Location = new System.Drawing.Point(12, 84);
            this.radioButtonClothes.Name = "radioButtonClothes";
            this.radioButtonClothes.Size = new System.Drawing.Size(65, 17);
            this.radioButtonClothes.TabIndex = 8;
            this.radioButtonClothes.TabStop = true;
            this.radioButtonClothes.Text = "Одежда";
            this.radioButtonClothes.UseVisualStyleBackColor = true;
            this.radioButtonClothes.CheckedChanged += new System.EventHandler(this.radioButtonClothes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Категория товара:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxProductsSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxProductPrice);
            this.panel1.Controls.Add(this.textBoxProductWeight);
            this.panel1.Controls.Add(this.textBoxProductName);
            this.panel1.Controls.Add(this.radioButtonSchoolGoods);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxProductsCompanyName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButtonShoes);
            this.panel1.Controls.Add(this.checkBoxIsThisNewProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.radioButtonClothes);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 139);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Размер:";
            // 
            // comboBoxProductsSize
            // 
            this.comboBoxProductsSize.FormattingEnabled = true;
            this.comboBoxProductsSize.Location = new System.Drawing.Point(341, 34);
            this.comboBoxProductsSize.Name = "comboBoxProductsSize";
            this.comboBoxProductsSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductsSize.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Вес (кг):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена (руб.):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Наименование:";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(180, 113);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxProductPrice.TabIndex = 3;
            this.textBoxProductPrice.Text = "0";
            // 
            // textBoxProductWeight
            // 
            this.textBoxProductWeight.Location = new System.Drawing.Point(341, 74);
            this.textBoxProductWeight.Name = "textBoxProductWeight";
            this.textBoxProductWeight.Size = new System.Drawing.Size(121, 20);
            this.textBoxProductWeight.TabIndex = 5;
            this.textBoxProductWeight.Text = "0";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(180, 74);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(121, 20);
            this.textBoxProductName.TabIndex = 2;
            // 
            // textBoxProductCompanyName
            // 
            this.textBoxProductCompanyName.Location = new System.Drawing.Point(12, 312);
            this.textBoxProductCompanyName.Name = "textBoxProductCompanyName";
            this.textBoxProductCompanyName.Size = new System.Drawing.Size(155, 20);
            this.textBoxProductCompanyName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Поставщик:";
            // 
            // btnWriteDataToXML
            // 
            this.btnWriteDataToXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWriteDataToXML.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWriteDataToXML.FlatAppearance.BorderSize = 2;
            this.btnWriteDataToXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteDataToXML.Location = new System.Drawing.Point(173, 338);
            this.btnWriteDataToXML.Name = "btnWriteDataToXML";
            this.btnWriteDataToXML.Size = new System.Drawing.Size(163, 32);
            this.btnWriteDataToXML.TabIndex = 14;
            this.btnWriteDataToXML.Text = "Выгрузить в XML";
            this.btnWriteDataToXML.UseVisualStyleBackColor = false;
            this.btnWriteDataToXML.Click += new System.EventHandler(this.btnWriteDataToXML_Click);
            // 
            // SchoolProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(474, 380);
            this.Controls.Add(this.btnWriteDataToXML);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxProductCompanyName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddProductCompany);
            this.Controls.Add(this.dataGridViewSchoolProductsBase);
            this.Controls.Add(this.btnDeleteProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SchoolProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База товаров для школы";
            this.Load += new System.EventHandler(this.SchoolProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchoolProductsBase)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchoolProductsBase;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProductCompany;
        private System.Windows.Forms.CheckBox checkBoxIsThisNewProduct;
        private System.Windows.Forms.ComboBox comboBoxProductsCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSchoolGoods;
        private System.Windows.Forms.RadioButton radioButtonShoes;
        private System.Windows.Forms.RadioButton radioButtonClothes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductWeight;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProductsSize;
        private System.Windows.Forms.TextBox textBoxProductCompanyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteDataToXML;
    }
}

