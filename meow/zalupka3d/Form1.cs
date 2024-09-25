using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zalupka3d;

namespace meow11
{
    public partial class Form1 : Form
    {
        public string roleName;

        public Form1(string roleName)
        {
      
                InitializeComponent();
                this.roleName = roleName;

            this.Controls.Add(buttonStatistics);
            this.Controls.Add(buttonEmployees);
            this.Controls.Add(buttonClients);
            this.Controls.Add(buttonOperations);
            this.Controls.Add(buttonItems);

            // Разграничение прав доступа
            if (!string.IsNullOrEmpty(roleName))
            {
                switch (roleName)
                {
                    case "Admin                                            ":
                        // Администратор
                        buttonStatistics.Visible = true;
                        buttonEmployees.Visible = true;
                        buttonClients.Visible = true;
                        buttonOperations.Visible = true;
                        buttonItems.Visible = true;
                        break;
                    case "Worker                                            ":
                        // Сотрудник
                        buttonStatistics.Visible = false;
                        buttonEmployees.Visible = false;
                        buttonClients.Visible = false;
                        buttonOperations.Visible = true;
                        buttonItems.Visible = true;
                        break;
                    case "Client                                            ":
                        // Клиент
                        buttonStatistics.Visible = false;
                        buttonEmployees.Visible = false;
                        buttonClients.Visible = false;
                        buttonOperations.Visible = true;
                        buttonItems.Visible = false;
                        break;
                }
            }
            buttonStatistics.BringToFront();
            buttonEmployees.BringToFront();
            buttonClients.BringToFront();
            buttonOperations.BringToFront();
            buttonItems.BringToFront();
            this.Refresh();
            this.Update();

        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
            this.Hide();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
          
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.Show();
            this.Hide();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
            this.Hide();
        }

        private void buttonOperations_Click(object sender, EventArgs e)
        {
            OperationsForm operationsForm = new OperationsForm(roleName);
            operationsForm.Show();
            this.Hide();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = Application.OpenForms["LoginForm"] as LoginForm;
            if (loginform != null)
            {
                loginform.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
