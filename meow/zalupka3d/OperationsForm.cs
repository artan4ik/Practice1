using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace meow11
{
    public partial class OperationsForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        public OperationsForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=localhost;Initial Catalog=Pizdets;Integrated Security=True;Encrypt=False");
            connection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Operations", connection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridViewOperations.DataSource = table;

            SqlDataAdapter adapterEmployees = new SqlDataAdapter("SELECT EmployeeID, FirstName, LastName FROM Employees", connection);
            DataTable tableEmployees = new DataTable();
            adapterEmployees.Fill(tableEmployees);
            comboBoxEmployee.DataSource = tableEmployees;
            comboBoxEmployee.DisplayMember = "FirstName";
            comboBoxEmployee.ValueMember = "EmployeeID";

            // Заполнить comboBox для выбора предмета
            SqlDataAdapter adapterItems = new SqlDataAdapter("SELECT ItemID, ItemType, ItemDescription FROM Items", connection);
            DataTable tableItems = new DataTable();
            adapterItems.Fill(tableItems);
            comboBoxItem.DataSource = tableItems;
            comboBoxItem.DisplayMember = "ItemType";
            comboBoxItem.ValueMember = "ItemID";

            // Заполнить comboBox для выбора клиента
            SqlDataAdapter adapterClients = new SqlDataAdapter("SELECT ClientID, FirstName, LastName FROM Clients", connection);
            DataTable tableClients = new DataTable();
            adapterClients.Fill(tableClients);
            comboBoxClient.DataSource = tableClients;
            comboBoxClient.DisplayMember = "FirstName";
            comboBoxClient.ValueMember = "ClientID";
        }

        private void OperationsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonEditOperation_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Operations SET ClientID = @ClientID, EmployeeID = @EmployeeID, ItemID = @ItemID, OperationDate = @OperationDate, OperationStatus = @OperationStatus WHERE OperationID = @OperationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", comboBoxClient.SelectedValue);
            command.Parameters.AddWithValue("@EmployeeID", comboBoxEmployee.SelectedValue);
            command.Parameters.AddWithValue("@ItemID", comboBoxItem.SelectedValue);
            command.Parameters.AddWithValue("@OperationDate", DateTime.Now);
            command.Parameters.AddWithValue("@OperationStatus", textBoxStatus.Text);
            command.Parameters.AddWithValue("@OperationID", dataGridViewOperations.SelectedRows[0].Cells["OperationID"].Value);
            command.ExecuteNonQuery();

            // Обновить таблицу
            table.Clear();
            adapter.Fill(table);
            dataGridViewOperations.DataSource = table;
        }

        private void buttonDeleteOperation_Click(object sender, EventArgs e)
        {
            // Код для удаления операции из базы данных
            string query = "DELETE FROM Operations WHERE OperationID = @OperationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OperationID", dataGridViewOperations.SelectedRows[0].Cells["OperationID"].Value);
            command.ExecuteNonQuery();

            // Обновить таблицу
            table.Clear();
            adapter.Fill(table);
            dataGridViewOperations.DataSource = table;
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Operations (ClientID, EmployeeID, ItemID, OperationDate, OperationStatus) VALUES (@ClientID, @EmployeeID, @ItemID, @OperationDate, @OperationStatus)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", comboBoxClient.SelectedValue);
            command.Parameters.AddWithValue("@EmployeeID", comboBoxEmployee.SelectedValue);
            command.Parameters.AddWithValue("@ItemID", comboBoxItem.SelectedValue);
            command.Parameters.AddWithValue("@OperationDate", DateTime.Now);
            command.Parameters.AddWithValue("@OperationStatus", "Новая");
            command.ExecuteNonQuery();
            table.Clear();
            adapter.Fill(table);
            dataGridViewOperations.DataSource = table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
