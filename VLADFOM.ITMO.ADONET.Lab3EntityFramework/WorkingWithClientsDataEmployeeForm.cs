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

            SetLastDateUpdate(); //устанавливаем значение даты последнего добавленного клиента
            
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
            p.FirstName = textBoxClientFirstName.Text;
            p.LastName = textBoxClientLastName.Text;
            p.HireDate = dateTimePickerClientRegisterDate.Value;
            clientsContext.People.Add(p);

            try
            {
                if (p.FirstName == "" || p.LastName == "" || p.HireDate == null) 
                {
                    MessageBox.Show("Данных не достаточно для записи в БД","Повторите ввод",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clientsContext.SaveChanges();
                MessageBox.Show("Клиент \"" + p.FirstName + " " + p.LastName + "\"" + " успешно сохранён в базу данных","Запись добавлена",MessageBoxButtons.OK,MessageBoxIcon.Information);
                UpdateClientsList();
                SetLastDateUpdate();
                textBoxClientFirstName.Clear();
                textBoxClientLastName.Clear();
                dateTimePickerClientRegisterDate.Value = DateTime.Now;
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

            if (!removingClient.Equals(null)) 
            {
                clientsContext.People.Remove(removingClient);
                clientsContext.SaveChanges();
                Debug.Print("Deleted!");

                MessageBox.Show("Клиент \"" + removingClient.FirstName + " " + removingClient.LastName + "\"" + " удалён из базы данных", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UpdateClientsList();
                SetLastDateUpdate();
            }
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

        public void SetLastDateUpdate() 
        {
            var lastUpdateDate = clientsContext.People.Max(a => a.HireDate);

            labelLastUpdateDate.Text = "Последний добавленный (" + lastUpdateDate + ")";
        }
    }
}
