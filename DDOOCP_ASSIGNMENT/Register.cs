using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOOCP_ASSIGNMENT
{


    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }




        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //Adding items in the City Combo box upon form load
            DataTable MaltaTowns = new DataTable();
            MaltaTowns.Columns.Add("Town", typeof(string));
            MaltaTowns.Rows.Add("Attard");
            MaltaTowns.Rows.Add("Balzan");
            MaltaTowns.Rows.Add("Birgu");
            MaltaTowns.Rows.Add("Birkirkara");
            MaltaTowns.Rows.Add("Birżebbuġa");
            MaltaTowns.Rows.Add("Cospicua");
            MaltaTowns.Rows.Add("Dingli");
            MaltaTowns.Rows.Add("Fgura");
            MaltaTowns.Rows.Add("Floriana");
            MaltaTowns.Rows.Add("Fontana");
            MaltaTowns.Rows.Add("Għajnsielem");
            MaltaTowns.Rows.Add("Għarb");
            MaltaTowns.Rows.Add("Għargħur");
            MaltaTowns.Rows.Add("Għasri");
            MaltaTowns.Rows.Add("Għaxaq");
            MaltaTowns.Rows.Add("Gudja");
            MaltaTowns.Rows.Add("Gżira");
            MaltaTowns.Rows.Add("Iklin");
            MaltaTowns.Rows.Add("Isla");
            MaltaTowns.Rows.Add("Kalkara");
            MaltaTowns.Rows.Add("Kerċem");
            MaltaTowns.Rows.Add("Kirkop");
            MaltaTowns.Rows.Add("Lija");
            MaltaTowns.Rows.Add("Luqa");
            MaltaTowns.Rows.Add("Marsa");
            MaltaTowns.Rows.Add("Marsaskala");
            MaltaTowns.Rows.Add("Marsaxlokk");
            MaltaTowns.Rows.Add("Mdina");
            MaltaTowns.Rows.Add("Mellieħa");
            MaltaTowns.Rows.Add("Mġarr");
            MaltaTowns.Rows.Add("Mosta");
            MaltaTowns.Rows.Add("Mqabba");
            MaltaTowns.Rows.Add("Msida");
            MaltaTowns.Rows.Add("Mtarfa");
            MaltaTowns.Rows.Add("Munxar");
            MaltaTowns.Rows.Add("Nadur");
            MaltaTowns.Rows.Add("Naxxar");
            MaltaTowns.Rows.Add("Paola");
            MaltaTowns.Rows.Add("Pembroke");
            MaltaTowns.Rows.Add("Pietà");
            MaltaTowns.Rows.Add("Qala");
            MaltaTowns.Rows.Add("Qormi");
            MaltaTowns.Rows.Add("Qrendi");
            MaltaTowns.Rows.Add("Rabat");
            MaltaTowns.Rows.Add("Safi");
            MaltaTowns.Rows.Add("San Ġiljan");
            MaltaTowns.Rows.Add("San Ġwann");
            MaltaTowns.Rows.Add("San Lawrenz");
            MaltaTowns.Rows.Add("San Pawl il-Baħar");
            MaltaTowns.Rows.Add("Sannat");
            MaltaTowns.Rows.Add("Santa Luċija");
            MaltaTowns.Rows.Add("Santa Venera");
            MaltaTowns.Rows.Add("Senglea");
            MaltaTowns.Rows.Add("Siġġiewi");
            MaltaTowns.Rows.Add("Sliema");
            MaltaTowns.Rows.Add("Swieqi");
            MaltaTowns.Rows.Add("Ta' Xbiex");
            MaltaTowns.Rows.Add("Tarxien");
            MaltaTowns.Rows.Add("Valletta");
            MaltaTowns.Rows.Add("Xagħra");
            MaltaTowns.Rows.Add("Xewkija");
            MaltaTowns.Rows.Add("Xgħajra");
            MaltaTowns.Rows.Add("Żabbar");
            MaltaTowns.Rows.Add("Żebbuġ");
            MaltaTowns.Rows.Add("Żejtun");
            MaltaTowns.Rows.Add("Żurrieq");
            CityRegisterCombo.DataSource = MaltaTowns;
            CityRegisterCombo.DisplayMember = "Town";

            DataTable MaltaCountry = new DataTable();
            MaltaCountry.Columns.Add("Country", typeof(string));
            MaltaCountry.Rows.Add("Malta");
            MaltaCountry.Rows.Add("Gozo");
            CountryRegisterCombo.DataSource = MaltaCountry;
            CountryRegisterCombo.DisplayMember = "Country";
        }

        //Creating list of Normal user accounts as only users are registering through this form
        private List<Normal> accounts = new List<Normal>();

        private void CancelRegisterBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Add_User(string name, string surname, string email, string phone, string username, string password, string address, string city, string country, string postCode, string userRole)
        {   
            //Creating object within the Normal class
            Normal user = new Normal();
            user.Name = name;
            user.Surname = surname;
            user.Email = email;
            user.Phone = phone;
            user.UserID = username;
            user.Password = password;
            user.Address = address;
            user.City = city;
            user.Country = country;
            user.PostCode = postCode;
            user.UserRole = userRole;

            //If statement checking that the username does not contain any characters apart from letters and numbers
            if (!IsLettersAndNumbersOnly(username))
            {
                throw new Exception("Username can only contain letters and numbers.");
            }

            //if statement checking that the password length is between 8 and 16, has one upper character and one lower character.
            if (password.Length < 8 || password.Length > 16 || !password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                throw new Exception("Password must be between 8 and 16 characters and contain at least one uppercase and one lowercase letter.");
            }

            //Calling connection string
            string connectionString = Database.connectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {   
                    //Creating query that inserts users into database
                    string query = "INSERT INTO USERS (NAME, SURNAME, PHONE, EMAIL, USER_ID, PASSWORD, ADDRESS, CITY, COUNTRY, POST_CODE, USER_ROLE) " +
                                   "VALUES (@name, @surname, @phone, @email, @username, @password, @address, @city, @country, @postCode, @userRole)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Parameters.AddWithValue("@postCode", postCode);
                    cmd.Parameters.AddWithValue("@userRole", userRole);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    //Checks if any rows in database have been affected
                    //if yes, successful registration prompt is shown
                    if (rowsAffected > 0)
                    {
                        
                    }
                    //if no, registration failure prompt is shown
                    else
                    {
                        throw new Exception("Registration failed.");
                    }
                }

                //If an error occurs, the program outputs the following exception.
                catch (Exception ex)
                {
                    throw new Exception("Error executing SQL query: " + ex.Message);
                }
            }
            //Add User to list
            accounts.Add(user);
        }
        //Connection String stored in a class
        public static class Database
        {
            public static string connectionString = @"Data Source=EMMAPC\SQLEXPRESS;Initial Catalog=DDOOCP;Integrated Security=True";
        }

        private void RegisterBTN_Click_1(object sender, EventArgs e)
        {
            try
            {   
                //Storing values entered by users into variables
                string name = RegisterNameTXT.Text;
                string surname = SurnameRegisterTXT.Text;
                string phone = PhoneRegisterTXT.Text;
                string email = EmailRegisterTXT.Text;
                string username = UsernameRegisterTXT.Text;
                string password = PasswordRegisterTXT.Text;
                string address = AddressRegisterTXT.Text;
                string city = CityRegisterCombo.SelectedItem.ToString();
                string country = CountryRegisterCombo.SelectedItem.ToString();
                string postCode = PostCodeRegisterTXT.Text;
                string userRole = "user";

                //Calling of method which will take the variables above and use them to add the user into the database
                Add_User(name, surname, email, phone, username, password, address, city, country, postCode, userRole);

                //Successful Registration Prompt
                MessageBox.Show("Your account has been registered!");

                //Login form is opened
                Login l1 = new Login();
                l1.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        //Method which returns a boolean when checking if the username only contains letters and numbers
        private bool IsLettersAndNumbersOnly(string input)
        {
            //checks each character
            foreach (char c in input)
            {   
                //if statement determining boolean return
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

}


