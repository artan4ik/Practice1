using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meow11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            OperationsForm operationsForm = new OperationsForm();
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
