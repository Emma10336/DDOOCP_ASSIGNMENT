using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DDOOCP_ASSIGNMENT
{
    public partial class ApplianceAdmin : Form
    {
        public ApplianceAdmin()
        {
            InitializeComponent();
        }

        //Adding appliances to database
        private void AddBTN_Click(object sender, EventArgs e)
           {
            //Storing Text Box input in Variables
            string ApplianceType = Type_Txt.Text;
            string ApplianceBrand = Brand_Txt.Text;
            string Model = Model_Txt.Text;
            string Dimensions = Dimensions_Txt.Text;
            string Colour = Colour_Txt.Text;
            string Energy = Energy_Txt.Text;
            string Fee = Fee_Txt.Text;

            //Opening connection string
            string connectionString = RegisterForm.Database.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Query to insert into applinces table in database
                string query = "INSERT INTO appliances ([TYPE_OF_APPLIANCE], [BRAND], [MODEL], [DIMENSIONS], [COLOUR], [ENERGY_CONSUMPTION], [MONTHLY_FEE]) " +
                               "VALUES (@ApplianceType, @ApplianceBrand, @Model, @Dimensions, @Colour, @Energy, @Fee)";

                //Assigning the parameters the value of the variables above
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplianceType", ApplianceType);
                    command.Parameters.AddWithValue("@ApplianceBrand", ApplianceBrand);
                    command.Parameters.AddWithValue("@Model", Model);
                    command.Parameters.AddWithValue("@Dimensions", Dimensions);
                    command.Parameters.AddWithValue("@Colour", Colour);
                    command.Parameters.AddWithValue("@Energy", Energy);
                    command.Parameters.AddWithValue("@Fee", Fee);

                    connection.Open();
                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
            //Loading updated list
            AppliancesLoad();


        }

        //Deleting appliances to database
        public void DeleteBTN_Click(object sender, EventArgs e)
        {
            //Connection String
            string connectionString = RegisterForm.Database.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Deleting appliance from database where the model is equal to the one selected
                string modelID = Model_Txt.Text;
                string query = "DELETE FROM APPLIANCES WHERE MODEL = @modelID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    //Adding the value of the variable into the query
                    command.Parameters.AddWithValue("@modelID", modelID);
                    command.ExecuteNonQuery();

            }
                connection.Close();
            }

            AppliancesLoad();
            
        }
        
        //Editing appliances already within the database
        private void EditBTN_Click(object sender, EventArgs e)
        {
            string ApplianceType = Type_Txt.Text;
            string ApplianceBrand = Brand_Txt.Text;
            string Model = Model_Txt.Text;
            string Dimensions = Dimensions_Txt.Text;
            string Colour = Colour_Txt.Text;
            string Energy = Energy_Txt.Text;
            string Fee = Fee_Txt.Text;

            //Connection string
            string connectionString = RegisterForm.Database.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Update query
                string query = "UPDATE appliances SET [TYPE_OF_APPLIANCE] = @ApplianceType, [BRAND] = @ApplianceBrand, [MODEL] = @Model, [DIMENSIONS] = @Dimensions, [COLOUR] = @Colour, [ENERGY_CONSUMPTION] = @Energy, [MONTHLY_FEE] = @Fee WHERE [MODEL] = @Model";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ApplianceType", ApplianceType);
                    command.Parameters.AddWithValue("@ApplianceBrand", ApplianceBrand);
                    command.Parameters.AddWithValue("@Model", Model);
                    command.Parameters.AddWithValue("@Dimensions", Dimensions);
                    command.Parameters.AddWithValue("@Colour", Colour);
                    command.Parameters.AddWithValue("@Energy", Energy);
                    command.Parameters.AddWithValue("@Fee", Fee);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                //Loading updated appliance list
                AppliancesLoad();
            }

        }

        //Loading appliances in list when form loads
        private void ApplianceAdmin_Load(object sender, EventArgs e)
        {
            AppliancesLoad();

        }

        //When appliance is selected, input details into respective text boxes
            private void ApplianceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ApplianceList.SelectedItem != null)
            {
                Appliance selectedAppliance = ApplianceList.SelectedItem as Appliance;

                Type_Txt.Text = selectedAppliance.ApplianceType.ToString();
                Brand_Txt.Text = selectedAppliance.ApplianceBrand.ToString();
                Model_Txt.Text = selectedAppliance.Model.ToString();
                Dimensions_Txt.Text = selectedAppliance.Dimensions.ToString();
                Colour_Txt.Text = selectedAppliance.Colour.ToString();
                Energy_Txt.Text = selectedAppliance.EnergyConsumption.ToString();
                Fee_Txt.Text = selectedAppliance.MonthlyFee.ToString();
            }

        }

        //Appliance Load method that loads the appliances into the list box
        //Is referred to upon form loasd

        private void AppliancesLoad()
        {
            string connectionString = RegisterForm.Database.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM APPLIANCES";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    ApplianceList.Items.Clear();

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

                        ApplianceList.Items.Add(appliance);

                    }

                }

                connection.Close();
            }
        }
    }

   
}

   
