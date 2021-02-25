using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace VLADFOM.ITMO.ADONET.Lab2DataSet
{
    public partial class Lab2DataSet_Form : Form
    {
        static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindDBConnectionString"].ToString());
        static string queryString = "SELECT * FROM Products";
        static SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter(queryString, connection);
        DataSet productsDataSet = new DataSet();
        SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);

        public Lab2DataSet_Form()
        {
            InitializeComponent();
            SqlDataAdapter1.Fill(productsDataSet);
            dataGridView1.DataSource = productsDataSet.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productsDataSet.EndInit();
            SqlDataAdapter1.Update(productsDataSet.Tables[0]);
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRow newProductRow = productsDataSet.Tables[0].NewRow();
            Object[] CustRecord = 
            {
                numericUpDownProductId.Value,
                textBoxProductName.Text,
                null,null,null,
                decimal.Parse(textBoxUnitPrice.Text)
            }; 
            newProductRow.ItemArray = CustRecord;
            productsDataSet.Tables[0].Rows.Add(newProductRow);
            SqlDataAdapter1.Update(productsDataSet.Tables[0]);
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            productsDataSet.EndInit();
            //получаем индекс текущей строки
            var index = dataGridView1.CurrentRow.Index;
            //удаляем строку
            productsDataSet.Tables[0].Rows[index].Delete();
            //обновляем датасет

            SqlDataAdapter1.Update(productsDataSet.Tables[0]);  
        }
    }
}
