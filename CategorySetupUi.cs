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

namespace StockManagementSystem
{
    public partial class CategorySetupUi : Form
    {
        public CategorySetupUi()
        {
            InitializeComponent();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        { //1
            string name;



            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                name = nameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please Give a Category Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Exists(name))
            {
                MessageBox.Show("Category Already Exists.");
                return;
            }

            try
            {
                //2
                string connectionString = @"Server=DESKTOP-FPTOG0K\SQLEXPRESS;Database=StockManagementSystemDb;integrated Security=true";
                //3 
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //4
                string query = "INSERT INTO Categories (Name) VALUES('" + name + "')";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
                //8

                sqlConnection.Close();
                // UpdateValue();
                ShowData();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }




        }
        //private void UpdateValue()
        // {
        //     //1
        //     string name = nameTextBox.Text;
        //    // int id = Convert.ToInt32(id);


        //     try
        //     {

        //         //2
        //         string connectionString = @"Server=DESKTOP-FPTOG0K\SQLEXPRESS; Database=StockManagementSystemDb; Integrated Security = true";
        //         //3
        //         SqlConnection sqlConnection = new SqlConnection(connectionString);

        //         //4

        //         string query = @"UPDATE Categories SET Name='" + name + "' WHERE ID = @Id";

        //         //5
        //         SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //         //6
        //         sqlConnection.Open();
        //         //7
        //         int isExecuted = sqlCommand.ExecuteNonQuery();
        //         if (isExecuted > 0)
        //         {
        //             MessageBox.Show("Updated");
        //         }
        //         else
        //         {
        //             MessageBox.Show("Not Updated");
        //         }

        //         //8
        //         sqlConnection.Close();


        //     }
        //     catch (Exception exception)
        //     {

        //         MessageBox.Show(exception.Message);
        //     }

        // }

        private void ShowData()
        {
            try
            {
                string connectionString = @"Server=DESKTOP-FPTOG0K\SQLEXPRESS;Database=StockManagementSystemDb;Integrated Security=true";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string queryShowData = @"SELECT *FROM Categories";

                SqlCommand sqlCommandShowData = new SqlCommand(queryShowData, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandShowData);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                displayDataGridView.DataSource = dataTable;
                displayDataGridView.Columns[0].Width = 50;
                displayDataGridView.Columns[1].Width = 300;

                sqlConnection.Close();
                // UpdateValue();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private bool Exists(string name)
        {
            bool isExists = false;

            try
            {
                string connectionString = @"Server=DESKTOP-FPTOG0K\SQLEXPRESS; Database=StockManagementSystemDb; Integrated Security = true";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string query = @"SELECT * FROM Categories WHERE Name = '" + name + "'";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                string data = "";
                if (sqlDataReader.Read())
                {
                    data = sqlDataReader["Name"].ToString();
                }

                if (!String.IsNullOrEmpty(data))
                {
                    isExists = true;
                }
                else
                {
                    isExists = false;
                }

                sqlConnection.Close();


            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

            return isExists;
        }

        private void CategorySetupUi_Load(object sender, EventArgs e)
        {

            ShowData();
        }









        private void displayDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //DoubleClick doubleClick = new DoubleClick();
                //doubleClick.idTextBox.Text = displayDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                //doubleClick.nameDoubleClickTextBox.Text = displayDataGridView.CurrentRow.Cells["Name"].Value.ToString();

                //doubleClick.ShowDialog();

                nameTextBox.Text = displayDataGridView.CurrentRow.Cells["Name"].Value.ToString();



                // ShowData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}

       
             

       
    
