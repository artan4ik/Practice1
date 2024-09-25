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
using System.Windows.Forms.VisualStyles;
using System.Net.NetworkInformation;

namespace meow11
{
  
    public partial class OperationsForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        private string roleName;
        public OperationsForm(string roleName)
        {
            InitializeComponent();
            this.roleName = roleName;
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
            comboBoxStatus.Items.Add("Новая");
            comboBoxStatus.Items.Add("В процессе");
            comboBoxStatus.Items.Add("Погашена");
            comboBoxStatus.SelectedIndex = 0;

            // Заполнить comboBox для поиска по клиенту
            SqlDataAdapter adapterSearchClients = new SqlDataAdapter("SELECT ClientID, FirstName, LastName FROM Clients", connection);
            DataTable tableSearchClients = new DataTable();
            adapterSearchClients.Fill(tableSearchClients);
            comboBoxSearchClient.DataSource = tableSearchClients;
            comboBoxSearchClient.DisplayMember = "FirstName";
            comboBoxSearchClient.ValueMember = "ClientID";

            // Заполнить comboBox для поиска по сотруднику
            SqlDataAdapter adapterSearchEmployees = new SqlDataAdapter("SELECT EmployeeID, FirstName, LastName FROM Employees", connection);
            DataTable tableSearchEmployees = new DataTable();
            adapterSearchEmployees.Fill(tableSearchEmployees);
            comboBoxSearchEmployee.DataSource = tableSearchEmployees;
            comboBoxSearchEmployee.DisplayMember = "FirstName";
            comboBoxSearchEmployee.ValueMember = "EmployeeID";

            // Заполнить comboBox для поиска по предмету
            SqlDataAdapter adapterSearchItems = new SqlDataAdapter("SELECT ItemID, ItemType, ItemDescription FROM Items", connection);
            DataTable tableSearchItems = new DataTable();
            adapterSearchItems.Fill(tableSearchItems);
            comboBoxSearchItem.DataSource = tableSearchItems;
            comboBoxSearchItem.DisplayMember = "ItemType";
            comboBoxSearchItem.ValueMember = "ItemID";

            // Заполнить comboBox для поиска по статусу операции
            comboBoxSearchStatus.Items.Add("Новая");
            comboBoxSearchStatus.Items.Add("В процессе");
            comboBoxSearchStatus.Items.Add("Погашена");
            comboBoxSearchStatus.SelectedIndex = 0;
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
            command.Parameters.AddWithValue("@OperationStatus", comboBoxStatus.SelectedItem.ToString());
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
            Form1 form1 = new Form1(roleName);
            form1.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Operations WHERE (ClientID = @ClientID OR @ClientID IS NULL) AND (EmployeeID = @EmployeeID OR @EmployeeID IS NULL) AND (ItemID = @ItemID OR @ItemID IS NULL) AND (OperationStatus = @OperationStatus OR @OperationStatus IS NULL)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", comboBoxSearchClient.SelectedValue == null ? (object)DBNull.Value : comboBoxSearchClient.SelectedValue);
            command.Parameters.AddWithValue("@EmployeeID", comboBoxSearchEmployee.SelectedValue == null ? (object)DBNull.Value : comboBoxSearchEmployee.SelectedValue);
            command.Parameters.AddWithValue("@ItemID", comboBoxSearchItem.SelectedValue == null ? (object)DBNull.Value : comboBoxSearchItem.SelectedValue);
            command.Parameters.AddWithValue("@OperationStatus", comboBoxSearchStatus.SelectedItem == null ? (object)DBNull.Value : comboBoxSearchStatus.SelectedItem.ToString());
            SqlDataReader reader = command.ExecuteReader();

            DataTable tableSearch = new DataTable();
            tableSearch.Load(reader);

            dataGridViewOperations.DataSource = tableSearch;
        }
    }
}
