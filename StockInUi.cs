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

namespace StockManagementSystem
{
    public partial class StockInUi : Form
    {
        
        public StockInUi()
        {
            InitializeComponent();
        }

        private void StockInUi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementSystemDbDataSet4.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.stockManagementSystemDbDataSet4.Items);
            // TODO: This line of code loads data into the 'stockManagementSystemDbDataSet3.CompanyS' table. You can move, or remove it, as needed.
            this.companySTableAdapter.Fill(this.stockManagementSystemDbDataSet3.CompanyS);

        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //2
                string connectionString = @"Server=DESKTOP-FPTOG0K\SQLEXPRESS;Database=StockManagementSystemDb;integrated Security=true";
                //3 
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //4
                string query = "SELECT * From ItemsStockInView where Name='"+itemComboBox.Text+"'";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader;
                
                sqlConnection.Open();
                sqlDataReader=sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    
                    string reorderLevel = sqlDataReader["ReorderLevel"].ToString();
                    string availableQuantity = sqlDataReader["Available Quantity"].ToString();
                    reorderLevelTextBox.Text = reorderLevel;
                    availableQuantityTextBox.Text = availableQuantity;
                }
                
                
                
                

                sqlConnection.Close();
                


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //2
            string connectionString = @"Server=DESKTOP-FPTOG0K\SQLEXPRESS;Database=StockManagementSystemDb;integrated Security=true";
            //3 
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //4
            string query = "SELECT * FROM CompanyItemView  where Company='" +companyComboBox.Text+ "'";
            //5
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader;
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    
                    string itemName = sqlDataReader["Name"].ToString();
                    itemComboBox.Text=itemName;
                    
                }
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            double availableQuantity = Convert.ToDouble(availableQuantityTextBox.Text);
            double stockInQuantity = Convert.ToDouble(stockInQuantityTextBox.Text);
            double quantity = 0;
            try
            {
                // Save Data
                string connectionStrint = @"Server=DESKTOP-FPTOG0K\SQLEXPRESS;Database=StockManagementSystemDb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionStrint);
                string query = @"INSERT INTO StockIn([Available Quantity],[Stock In Quantity],[Company ID],[Item ID]) VALUES('" + availableQuantity + "','" + stockInQuantity + "','" + companyComboBox.SelectedValue + "','" + itemComboBox.SelectedValue + "')";
                SqlCommand sqlCommane = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                quantity = Add(availableQuantity, stockInQuantity);
                Display(quantity);
                
                int isExecuted = sqlCommane.ExecuteNonQuery();
                MessageBox.Show(isExecuted > 0 ? "Company Saved." : "Not Saved.");
               
                sqlConnection.Close();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
            
            
        }
        private double Add(double availableQuantity, double stockInQuantity)
        {
            double quantity = availableQuantity + stockInQuantity;
            return quantity;
        }

        private void Display(double quantity)
        {
            availableQuantityTextBox.Text = quantity.ToString();
            
        }

        
        

       
    }
}
