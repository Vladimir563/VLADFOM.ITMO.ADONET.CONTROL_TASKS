using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLADFOM.ITMO.ADONET.Lab3LINQXML
{
    public partial class SchoolProductsForm : Form
    {
        private SchoolProductsEntities schoolProductsContext;
        public SchoolProductsForm()
        {
            InitializeComponent();
        }

        private void SchoolProductsForm_Load(object sender, EventArgs e)
        {
            comboBoxProductsSize.Enabled = false;

            schoolProductsContext = new SchoolProductsEntities();

            GridViewUpdate();

            CompaniesComboBoxUpdate();
        }

        public void SizeComboBoxInitialize() 
        {
            List<string> clothesSizeList = new List<string> {"S","M","L","XS","XL","XXL","XXXL"};
            List<string> choesSizeList = new List<string> {"30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45"};
            List<string> schoolGoodsList = new List<string>{""};

            if (radioButtonClothes.Checked)
            {
                comboBoxProductsSize.Enabled = true;
                comboBoxProductsSize.DataSource = clothesSizeList;
            }
            else if (radioButtonShoes.Checked)
            {
                comboBoxProductsSize.Enabled = true;
                comboBoxProductsSize.DataSource = choesSizeList;
            }
            else if (radioButtonSchoolGoods.Checked) 
            {
                comboBoxProductsSize.DataSource = schoolGoodsList;
                comboBoxProductsSize.Enabled = false;
            }
        }

        private void radioButtonSchoolGoods_CheckedChanged(object sender, EventArgs e)
        {
            SizeComboBoxInitialize();
        }

        private void radioButtonShoes_CheckedChanged(object sender, EventArgs e)
        {
            SizeComboBoxInitialize();
        }

        private void radioButtonClothes_CheckedChanged(object sender, EventArgs e)
        {
            SizeComboBoxInitialize();
        }

        public void CompaniesComboBoxUpdate() 
        {
            //получаем наименования поставщиков
            var companies = from c in schoolProductsContext.Companies
                            select c;
            //добавляем поставщиков для выбора
            comboBoxProductsCompanyName.DisplayMember = "CompanyName";
            comboBoxProductsCompanyName.DataSource = companies.ToList();
        }

        private void btnAddProductCompany_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.CompanyName = textBoxProductCompanyName.Text;
            schoolProductsContext.Companies.Add(company);

            try
            {
                if (textBoxProductCompanyName.Text == "")
                {
                    MessageBox.Show("Наименование поставщика не может быть пустым", "Повторите ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                schoolProductsContext.SaveChanges();
                MessageBox.Show("Поставщик \"" + company.CompanyName + "\"" + " успешно добавлен", "Запись добавлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxProductCompanyName.Clear();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    Debug.Print("Object: " + validationError.Entry.Entity.ToString());
                    Debug.Print("");
                    foreach (DbValidationError err in validationError.ValidationErrors)
                    {
                        Debug.Print(err.ErrorMessage + "");
                    }
                }
            }

            CompaniesComboBoxUpdate();
        }

        public void GridViewUpdate() 
        {
            var products = from p in schoolProductsContext.Products
                           select p;

            dataGridViewSchoolProductsBase.DataSource = products
                             .Select(item_list => new
                             {
                                 ID = item_list.Id,
                                 Name = item_list.ProductName,
                                 Weight = item_list.Weight,
                                 Price = item_list.Price,
                                 Company = item_list.ProductCompanyName,
                                 Size = item_list.Size,
                                 Category = item_list.Category,
                                 IsNew = item_list.IsThisNewProduct,
                                 AdditionDate = item_list.AdditionDate

                             }).ToList();

            dataGridViewSchoolProductsBase.Columns["ID"].Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string categoryName = radioButtonClothes.Checked ? "CLOTHES" : radioButtonShoes.Checked ? "SHOES" : "SCHOOL_GOODS";
            bool isNew = checkBoxIsThisNewProduct.Checked ? true : false;

            Product product = new Product();
            product.ProductName = textBoxProductName.Text;
            product.ProductCompanyName = comboBoxProductsCompanyName.Text;
            product.Price = Decimal.Parse(textBoxProductPrice.Text);
            product.Weight = Double.Parse(textBoxProductWeight.Text);
            product.Category = categoryName;
            product.AdditionDate = DateTime.Now;
            product.IsThisNewProduct = isNew;
            product.Size = comboBoxProductsSize.Text;
            schoolProductsContext.Products.Add(product);

            try
            {
                if (textBoxProductName.Text == "" || comboBoxProductsCompanyName.Text == "" || textBoxProductPrice.Text == "" ||
                    textBoxProductWeight.Text == "" || categoryName == "")
                {
                    MessageBox.Show("Не все данные заполнены", "Повторите ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                schoolProductsContext.SaveChanges();
                MessageBox.Show("Товар \"" + product.ProductName + "\"" + " успешно добавлен", "Запись добавлена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //очищаем все заполненные данные после добавления товара
                textBoxProductName.Clear();
                textBoxProductPrice.Clear();
                textBoxProductWeight.Clear();
                checkBoxIsThisNewProduct.Checked = false;
                radioButtonClothes.Checked = false;
                radioButtonSchoolGoods.Checked = false;
                radioButtonShoes.Checked = false;
                comboBoxProductsCompanyName.Text = "";
                comboBoxProductsSize.Text = "";

                GridViewUpdate();

            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    Debug.Print("Object: " + validationError.Entry.Entity.ToString());
                    Debug.Print("");
                    foreach (DbValidationError err in validationError.ValidationErrors)
                    {
                        Debug.Print(err.ErrorMessage + "");
                    }
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int removingProductID = (int)dataGridViewSchoolProductsBase.CurrentRow.Cells[0].Value;
            Product removingProduct = schoolProductsContext.Products
                                    .Where(p => p.Id == removingProductID)
                                    .FirstOrDefault();

            Debug.Print(dataGridViewSchoolProductsBase.CurrentRow.Cells[0].Value.ToString());

            if (!removingProduct.Equals(null))
            {
                schoolProductsContext.Products.Remove(removingProduct);
                schoolProductsContext.SaveChanges();
                Debug.Print("Deleted!");

                MessageBox.Show("Товар \"" + removingProduct.ProductName + "\"" + " удалён из базы данных", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GridViewUpdate();
            }
        }

        private void btnWriteDataToXML_Click(object sender, EventArgs e)
        {
            Debug.Print("Выгрузка в XML");

            DataTable dataTable = new DataTable();

            DataColumn column;

            column = new DataColumn(); 
            column.ColumnName = "Id"; 
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Name";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Weight";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "CompanyName";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Price";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Size";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Category";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "IsNewProduct";
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "AdditionDate";
            dataTable.Columns.Add(column);

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            //заполняю таблицу в DataSet на основе контекста
            foreach (Product product in schoolProductsContext.Products)
            {
                DataRow row = dataSet.Tables[0].NewRow();
                row["Id"] = product.Id;
                row["Name"] = product.ProductName;
                row["CompanyName"] = product.ProductCompanyName;
                row["Price"] = product.Price;
                row["Weight"] = product.Weight;
                row["Size"] = product.Size;
                row["Category"] = product.Category;
                row["IsNewProduct"] = product.IsThisNewProduct;
                row["AdditionDate"] = product.AdditionDate;

                dataSet.Tables[0].Rows.Add(row);
            }

            string path = @"C:\Users\vladi\OneDrive\Рабочий стол\ADO.NET\Products.xml";
            dataSet.WriteXml(path);

            MessageBox.Show("Файл базы данных выгружен в XML (" + path.Replace("@","") + ")", "Выгрузка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
