using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DDOOCP_ASSIGNMENT
{
    public partial class ApplianceUser : Form
    {
        private string userID;
        private List<Appliance> selectedAppliances = new List<Appliance>();

        public ApplianceUser(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private List<string> uniqueEnergyValues = new List<string>();
        private List<string> uniqueFeeValues = new List<string>();

        // User selecting item in the list box
        private void ApplianceList_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ApplianceList_User.SelectedItem != null)
            {
                Appliance selectedAppliance = ApplianceList_User.SelectedItem as Appliance;

                // Update the UI with selected appliance details
                TypeU_Txt.Text = selectedAppliance.ApplianceType.ToString();
                BrandU_Txt.Text = selectedAppliance.ApplianceBrand.ToString();
                ModelU_Txt.Text = selectedAppliance.Model.ToString();
                DimensionsU_Txt.Text = selectedAppliance.Dimensions.ToString();
                ColourU_Txt.Text = selectedAppliance.Colour.ToString();
                EnergyU_Txt.Text = selectedAppliance.EnergyConsumption.ToString();
                FeeU_Txt.Text = selectedAppliance.MonthlyFee.ToString();

                // Populate the length combo box based on appliance type
                switch (selectedAppliance.ApplianceType)
                {
                    case "Refrigerators":
                        Length_Combo.Items.Clear();
                        for (int i = 3; i <= 12; i++)
                        {
                            Length_Combo.Items.Add(i);
                        }
                        break;
                    case "Washing Machines":
                    case "Dishwashers":
                    case "Ovens":
                    case "Air Conditioners":
                        Length_Combo.Items.Clear();
                        for (int i = 5; i <= 12; i++)
                        {
                            Length_Combo.Items.Add(i);
                        }
                        break;
                }
            }
        }

        // Load appliances from the database
        private void AppliancesLoad()
        {
            string connectionString = @"Data Source=EMMAPC\SQLEXPRESS;Initial Catalog=DDOOCP;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM APPLIANCES";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    ApplianceList_User.Items.Clear();

                    while (reader.Read())
                    {
                        Appliance appliance = new Appliance
                        {
                            ApplianceID = reader.GetInt32(reader.GetOrdinal("Appliance_ID")),
                            ApplianceType = reader.GetString(reader.GetOrdinal("TYPE_OF_APPLIANCE")),
                            ApplianceBrand = reader.GetString(reader.GetOrdinal("BRAND")),
                            Model = reader.GetString(reader.GetOrdinal("MODEL")),
                            Dimensions = reader.GetString(reader.GetOrdinal("DIMENSIONS")),
                            Colour = reader.GetString(reader.GetOrdinal("COLOUR")),
                            EnergyConsumption = reader.GetString(reader.GetOrdinal("ENERGY_CONSUMPTION")),
                            MonthlyFee = reader.GetDecimal(reader.GetOrdinal("MONTHLY_FEE"))
                        };

                        ApplianceList_User.Items.Add(appliance);
                    }
                }
            }
        }

        // Update the order list box to display client's selection


        // Delete selected appliance from the order
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (OrderListBox.SelectedItem != null)
            {
                Appliance selectedAppliance = OrderListBox.SelectedItem as Appliance;
                selectedAppliances.Remove(selectedAppliance);
                UpdateOrderListBox();
            }
        }

        // Add selected appliance to the order
        private void AddUBTN_Click_1(object sender, EventArgs e)
        {
            if (ApplianceList_User.SelectedItem != null)
            {
                Appliance selectedAppliance = ApplianceList_User.SelectedItem as Appliance;
                selectedAppliances.Add(selectedAppliance);
                UpdateOrderListBox();
            }
        }

        // Checkout button
        private void CheckOutBTN_Click_1(object sender, EventArgs e)
        {
            Appliance selectedAppliance = ApplianceList_User.SelectedItem as Appliance;

            if (selectedAppliance == null)
            {
                MessageBox.Show("Please select an Appliance before checking out.");
                return;
            }

            // Get information needed to create an order
            string userId = userID;
            int applianceId = selectedAppliance.ApplianceID;
            string selectedLength = Length_Combo.SelectedItem?.ToString();
            int orderLength = int.Parse(selectedLength?.Split(' ')[0] ?? "0");
            decimal totalPrice = selectedAppliance.MonthlyFee * orderLength;

            // Generate a unique order ID using GUID
            string orderId = Guid.NewGuid().ToString();

            string connectionString = RegisterForm.Database.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Insert a new order into the orders table in the database
                string query = "INSERT INTO Orders (ORDER_ID, user_id, appliance_id, length_of_order, total_price) VALUES (@OrderId, @UserId, @ApplianceId, @OrderLength, @TotalPrice)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@ApplianceId", applianceId);
                    command.Parameters.Add("@OrderLength", SqlDbType.Int).Value = orderLength;
                    command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Successful order message
            MessageBox.Show("Order placed successfully!");
            ShoppingCart cartForm = new ShoppingCart();
            cartForm.SelectedOrderID = orderId;
            cartForm.ShowDialog();
        }

        // Perform a filtered search based on user-selected filters
        private void Search_BTN_Click(object sender, EventArgs e)
        {
            string searchKeyword = Search_TXT.Text.Trim();

            // Ensures the search keyword is not empty
            if (string.IsNullOrWhiteSpace(searchKeyword))
            {
                // If the search keyword is empty, show all appliances in the list
                AppliancesLoad();
            }
            else
            {
                // If the search keyword is not empty, performs the filtered search
                string connectionString = @"Data Source=EMMAPC\SQLEXPRESS;Initial Catalog=DDOOCP;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM APPLIANCES WHERE TYPE_OF_APPLIANCE LIKE @SearchKeyword";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter for the search keyword
                        command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        ApplianceList_User.Items.Clear();

                        while (reader.Read())
                        {
                            Appliance appliance = new Appliance
                            {
                                ApplianceID = reader.GetInt32(reader.GetOrdinal("Appliance_ID")),
                                ApplianceType = reader.GetString(reader.GetOrdinal("TYPE_OF_APPLIANCE")),
                                ApplianceBrand = reader.GetString(reader.GetOrdinal("BRAND")),
                                Model = reader.GetString(reader.GetOrdinal("MODEL")),
                                Dimensions = reader.GetString(reader.GetOrdinal("DIMENSIONS")),
                                Colour = reader.GetString(reader.GetOrdinal("COLOUR")),
                                EnergyConsumption = reader.GetString(reader.GetOrdinal("ENERGY_CONSUMPTION")),
                                MonthlyFee = reader.GetDecimal(reader.GetOrdinal("MONTHLY_FEE"))

                            };

                            ApplianceList_User.Items.Add(appliance);

                        }
                    }
                }
            }

            // Update unique energy and fee values for filter combo boxes
            uniqueEnergyValues.Clear();
            uniqueFeeValues.Clear();

            foreach (Appliance appliance in ApplianceList_User.Items)
            {
                if (!uniqueEnergyValues.Contains(appliance.EnergyConsumption))
                {
                    uniqueEnergyValues.Add(appliance.EnergyConsumption);
                }

                if (!uniqueFeeValues.Contains(appliance.MonthlyFee.ToString()))
                {
                    uniqueFeeValues.Add(appliance.MonthlyFee.ToString());
                }
            }
        }
        private void PerformSearchWithFilters()
        {
            Search_BTN_Click(null, EventArgs.Empty);
        }

        // Form Load event handler
        private void ApplianceUser_Load(object sender, EventArgs e)
        {
            // Load appliances and display all initially
            AppliancesLoad();
        }

        private void Energy_Sort_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=EMMAPC\SQLEXPRESS;Initial Catalog=DDOOCP;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM APPLIANCES ORDER BY ENERGY_CONSUMPTION ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    ApplianceList_User.Items.Clear();

                    while (reader.Read())
                    {
                        Appliance appliance = new Appliance
                        {
                            ApplianceID = reader.GetInt32(reader.GetOrdinal("Appliance_ID")),
                            ApplianceType = reader.GetString(reader.GetOrdinal("TYPE_OF_APPLIANCE")),
                            ApplianceBrand = reader.GetString(reader.GetOrdinal("BRAND")),
                            Model = reader.GetString(reader.GetOrdinal("MODEL")),
                            Dimensions = reader.GetString(reader.GetOrdinal("DIMENSIONS")),
                            Colour = reader.GetString(reader.GetOrdinal("COLOUR")),
                            EnergyConsumption = reader.GetString(reader.GetOrdinal("ENERGY_CONSUMPTION")),
                            MonthlyFee = reader.GetDecimal(reader.GetOrdinal("MONTHLY_FEE"))
                        };

                        ApplianceList_User.Items.Add(appliance);
                    }
                }
            }
        }

        private void Fee_Sort_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=EMMAPC\SQLEXPRESS;Initial Catalog=DDOOCP;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM APPLIANCES ORDER BY MONTHLY_FEE ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    ApplianceList_User.Items.Clear();

                    while (reader.Read())
                    {
                        Appliance appliance = new Appliance
                        {
                            ApplianceID = reader.GetInt32(reader.GetOrdinal("Appliance_ID")),
                            ApplianceType = reader.GetString(reader.GetOrdinal("TYPE_OF_APPLIANCE")),
                            ApplianceBrand = reader.GetString(reader.GetOrdinal("BRAND")),
                            Model = reader.GetString(reader.GetOrdinal("MODEL")),
                            Dimensions = reader.GetString(reader.GetOrdinal("DIMENSIONS")),
                            Colour = reader.GetString(reader.GetOrdinal("COLOUR")),
                            EnergyConsumption = reader.GetString(reader.GetOrdinal("ENERGY_CONSUMPTION")),
                            MonthlyFee = reader.GetDecimal(reader.GetOrdinal("MONTHLY_FEE"))
                        };

                        ApplianceList_User.Items.Add(appliance);
                    }
                }
            }
        }
        private void UpdateOrderListBox()
        {
            OrderListBox.DataSource = selectedAppliances;
            OrderListBox.DisplayMember = "ApplianceBrand";
            OrderListBox.Refresh();
        }
    }
}

