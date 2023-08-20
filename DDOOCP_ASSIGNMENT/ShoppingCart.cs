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

namespace DDOOCP_ASSIGNMENT
{
    public partial class ShoppingCart : Form
    {
        public string SelectedOrderID { get; set; }

        public ShoppingCart()
        {
            InitializeComponent();

        }

        //When order is selected from list box, the total amount label is changed according to the amount of the order
        private void Cart_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cart_List.SelectedItem is Orders selectedOrder)
            {
                Total_LBL.Text = selectedOrder.Total.ToString("0.00");
            }
            else
            {
                Total_LBL.Text = "$0.00"; // or any default value you want to display when no order is selected
            }
        }

        
        private void Checkout_BTN_Click(object sender, EventArgs e)
        {
            //Comfirmed order prompt
            MessageBox.Show("Order Confirmed");
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            //Clearing list box upon form load
            Cart_List.Items.Clear();

            // Retrieve the specific order from the database based on the SelectedOrderID
            string selectedOrderID = SelectedOrderID;
            if (string.IsNullOrEmpty(selectedOrderID))
            {
                // If SelectedOrderID is null or empty, an 'error' msg is shown.
                MessageBox.Show("No order ID selected.");
                return;
            }

            // Retrieve the order from the database using the selectedOrderID
            string connectionString = RegisterForm.Database.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ORDERS WHERE ORDER_ID = @OrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", selectedOrderID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Orders selectedOrderFromDB = new Orders
                        {
                            OrderID = reader.GetString(reader.GetOrdinal("ORDER_ID")),
                            ApplianceID = reader.GetInt32(reader.GetOrdinal("Appliance_ID")),
                            UserID = reader.GetString(reader.GetOrdinal("USER_ID")),
                            Length = reader.GetInt32(reader.GetOrdinal("LENGTH_OF_ORDER")),
                            Total = reader.GetDecimal(reader.GetOrdinal("TOTAL_PRICE"))
                        };

                        Cart_List.Items.Add(selectedOrderFromDB);


                    }
                    else
                    {
                        // If no matching order found in the database, an 'error' msg is shown.
                        MessageBox.Show("Order not found in the database.");
                    }

                }
            }

            if (Cart_List.SelectedItem is Orders selectedOrder)
            {
                Total_LBL.Text = selectedOrder.Total.ToString("0.00");
            }
        }

        private void CancelOrder_BTN_Click(object sender, EventArgs e)
        {
            //Prompt the user to confirm if they actually want to delete their order
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User confirmed the cancellation, so delete the order from the database
                string selectedOrderID = SelectedOrderID;

                if (!string.IsNullOrEmpty(selectedOrderID))
                {
                    // Perform the database deletion here based on the selectedOrderID
                    string connectionString = RegisterForm.Database.connectionString;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM ORDERS WHERE ORDER_ID = @OrderID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@OrderID", selectedOrderID);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Order cancelled successfully!");

                    // Close the form
                    this.Close();
                }
                else
                {
                    // Show a message if no order is selected
                    MessageBox.Show("No order ID selected.");
                }
            }
        }


    }
}