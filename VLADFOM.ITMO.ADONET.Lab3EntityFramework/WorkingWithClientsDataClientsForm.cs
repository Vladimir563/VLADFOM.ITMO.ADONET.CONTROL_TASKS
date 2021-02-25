using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLADFOM.ITMO.ADONET.Lab3EntityFramework
{
    public partial class WorkingWithClientsDataClientsForm : Form
    {
        private ClientsEntities clientsContext;
        public WorkingWithClientsDataClientsForm()
        {
            InitializeComponent();
        }

        private void WorkingWithClientsDataClientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
        }

        private void WorkingWithClientsDataClientsForm_Load(object sender, EventArgs e)
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
    }
}
