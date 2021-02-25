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

namespace VLADFOM.ITMO.ADONET.Lab3EntityFramework
{
    public partial class WorkingWithClientsDataEmployeeForm : Form
    {
        //создаем экземпляр контекста, для возможности обращения к данным из БД
        private ClientsEntities clientsContext;
        public WorkingWithClientsDataEmployeeForm()
        {
            InitializeComponent();
        }

        private void WorkingWithClientsDataForm_Load(object sender, EventArgs e)
        {
            clientsContext = new ClientsEntities(); //инициализируем контекст в конструкторе формы
            var clientsNames = from d in clientsContext.People
                               select d;

            dataGridViewForEmployees.DataSource = clientsNames
                             .Select(item_list => new
                             {
                                 ID = item_list.PersonID,
                                 First_Name = item_list.FirstName,
                                 Last_Name = item_list.LastName,
                                 Hire_Date = item_list.HireDate,
                                 Enrollment_Date = item_list.EnrollmentDate

                             }).ToList();
            dataGridViewForEmployees.Columns["ID"].Visible = false;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.LastName = "Fominykh";
            p.FirstName = "Vladimir";
            clientsContext.People.Add(p);

            try
            {
                clientsContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                UpdateClientsList();
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

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            
            int removingClientID = (int)dataGridViewForEmployees.CurrentRow.Cells[0].Value;
            Person removingClient = clientsContext.People
                                    .Where(p => p.PersonID == removingClientID)
                                    .FirstOrDefault();

            Debug.Print(dataGridViewForEmployees.CurrentRow.Cells[0].Value.ToString());

            clientsContext.People.Remove(removingClient);
            clientsContext.SaveChanges();

            Debug.Print("Deleted!");

            MessageBox.Show("\""+removingClient.FirstName + " " + removingClient.LastName + "\"" + " DELETED from database");

            UpdateClientsList();
        }

        private void UpdateClientsList() 
        {
            var clientsNames = from d in clientsContext.People
                               select d;

            dataGridViewForEmployees.DataSource = clientsNames
                             .Select(item_list => new
                             {
                                 ID = item_list.PersonID,
                                 First_Name = item_list.FirstName,
                                 Last_Name = item_list.LastName,
                                 Hire_Date = item_list.HireDate,
                                 Enrollment_Date = item_list.EnrollmentDate

                             }).ToList();
        }

        private void WorkingWithClientsDataEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
        }
    }
}
