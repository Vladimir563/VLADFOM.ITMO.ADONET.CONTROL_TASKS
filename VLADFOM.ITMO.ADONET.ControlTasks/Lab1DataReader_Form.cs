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

namespace VLADFOM.ITMO.ADONET.ControlTasks
{
    public partial class Lab1DataReader_Form : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdvWorksDBConnectionString"].ToString());
        string query =  "SELECT Name, DueDate, TotalDue FROM Production.Product AS Products " +
                        "JOIN " +
                            "(SELECT DueDate, TotalDue, OrderQty, ProductID, UnitPrice, UnitPriceDiscount FROM Sales.SalesOrderHeader AS Sales " +
                            "JOIN Sales.SalesOrderDetail AS OrderDetail ON Sales.SalesOrderID = OrderDetail.SalesOrderID) AS OrdersDetails " +
                            "ON Products.ProductID = OrdersDetails.ProductID " +
                            "WHERE DueDate BETWEEN @startDate AND @endDate";

        public Lab1DataReader_Form()
        {
            InitializeComponent();
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                Debug.Print(connection.State.ToString());
                SqlCommand command = new SqlCommand(query, connection);

                SqlParameter startDate = new SqlParameter("@startDate", dateTimePickerStartDate.Value);
                SqlParameter endDate = new SqlParameter("@endDate", dateTimePickerEndDate.Value);

                command.Parameters.Add(startDate);
                command.Parameters.Add(endDate);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem newItem = listView1.Items.Add(reader["Name"].ToString());
                    newItem.SubItems.Add(reader.GetDateTime(1).ToString("yyyy-MM-dd"));
                    newItem.SubItems.Add(reader["TotalDue"].ToString());
                }

            }
            catch (SqlException ex)
            {
                Debug.Print(ex.Message);
            }
            finally
            {
                connection.Close();
                Debug.Print(connection.State.ToString());
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
