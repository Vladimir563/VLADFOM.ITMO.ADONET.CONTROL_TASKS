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
    public partial class StartWindow : Form
    {
        WorkingWithClientsDataEmployeeForm employeeForm;
        WorkingWithClientsDataClientsForm clientsForm;
        public StartWindow()
        {
            InitializeComponent(); 
        }

        private void btnAcceptEnter_Click(object sender, EventArgs e)
        {
            bool itsOkUserName = false;
            bool itsOkUserPwd = false;

            string userName = textBoxUserName.Text.ToLower();
            string userPwd = textBoxUserPwd.Text;

            if (userName.Equals("employee") || userName.Equals("client")) 
            {
                itsOkUserName = true;
            }

            if (userPwd == "123") 
            {
                itsOkUserPwd = true;
            }

            if (itsOkUserName && itsOkUserPwd)
            {
                if (userName.Equals("employee"))
                {
                    employeeForm = new WorkingWithClientsDataEmployeeForm();
                    employeeForm.Show();
                }
                else 
                {
                    clientsForm = new WorkingWithClientsDataClientsForm();
                    clientsForm.Show();
                }
                
                this.Hide();
            }
            else if (!itsOkUserName)
            {
                MessageBox.Show("Введено не верное имя пользователя","Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Неверный пароль", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
