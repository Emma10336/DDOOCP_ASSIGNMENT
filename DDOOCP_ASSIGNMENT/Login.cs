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
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace DDOOCP_ASSIGNMENT


{
    public partial class Login : Form
    {
        private string loggedInUserID;
        private List<Administrator> administrators = new List<Administrator>();
        private string lastAttemptedUsername = null;
        private int failedLoginAttempts = 0;
        private DateTime lastFailedLoginTime = DateTime.MinValue;
        private TimeSpan loginTimeoutDuration = TimeSpan.FromSeconds(30);
        private System.Timers.Timer loginTimeoutTimer = new System.Timers.Timer();

        public Login()
        {
            InitializeComponent();

            loginTimeoutTimer.Interval = loginTimeoutDuration.TotalMilliseconds;
            loginTimeoutTimer.AutoReset = false;
            loginTimeoutTimer.Elapsed += LoginTimeoutTimer_Elapsed;
        }


        List<Normal> account = new List<Normal>();
        List<Administrator> administrator = new List<Administrator>();

        private void Login_Load(object sender, EventArgs e)
        {
            //opening connection to database where user info is stored
            //RegisterForm.Database is calling the connection string stored in the Register Form
            string connectionString = RegisterForm.Database.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                //Creating a query to be performed in the database
                string query = "SELECT USER_ID, PASSWORD, USER_ROLE FROM USERS";
                using (SqlCommand command = new SqlCommand(query, connection))
                {   
                    //Opening Database connection
                    connection.Open();
                    //Retrieves Data from Database
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {   
                        //Setting the username and password retrieved to a variable
                        string Username = reader.GetString(reader.GetOrdinal("USER_ID"));
                        string password = reader.GetString(reader.GetOrdinal("PASSWORD"));
                        string User_Role = reader.GetString(reader.GetOrdinal("USER_ROLE"));
                       

                        switch (User_Role) {
                            //Creating objects of the Normal class which represent normal users
                            //This class inherits from the User class
                            case "user":
                                Normal user = new Normal();
                                {

                                    user.UserID = Username;
                                    user.Password = password;
                                    user.UserRole = User_Role;


                                };
                                accounts.Add(user);
                                break;
                            case "admin":
                                //Creating objects of the Admin class which represent administrator users
                                //This class inherits from the User class
                                Administrator admin = new Administrator();
                                {
                                    admin.UserID = Username;
                                    admin.Password = password;
                                    admin.UserRole = User_Role;
                                };
                                administrators.Add(admin);
                                break;
                        }

                    }

                }

                connection.Close();
            }
        }

        private List<Normal> accounts = new List<Normal>();

        public void LoginFormBTN_Click(object sender, EventArgs e)
        
        {

            LoginFormBTN.Enabled = false;

            // Storing values entered into variables
            string username = UserLoginTXT.Text.Trim();
            string password = PasswordLoginTXT.Text;

            if (username != lastAttemptedUsername)
            {
                failedLoginAttempts = 0;
                lastAttemptedUsername = username;
            }

            // Retrieve the user object from the 'accounts' list whose UserID matches the specified 'username'.
            Normal normalUser = accounts.FirstOrDefault(u => u.UserID == username);

            // If no normal user is found, try to find an administrator.
            Administrator adminUser = administrators.FirstOrDefault(a => a.UserID == username);

            // Check if the provided username matches either a normal user or an administrator.
            if (normalUser != null || adminUser != null)
            {
                User user = normalUser as User ?? adminUser as User;

                // Check if the password entered matches the password in the database for the user found.
                if (user.Password == password)
                {
                    if (user is Normal)
                    {
                        // Open the user form
                        loggedInUserID = user.UserID;
                        ApplianceUser userOrder = new ApplianceUser(loggedInUserID);
                        userOrder.ShowDialog();
                        this.Hide();
                    }
                    else if (user is Administrator)
                    {
                        // Open the admin form
                        ApplianceAdmin adminForm = new ApplianceAdmin();
                        adminForm.FormClosed += ApplianceAdminClosed;
                        adminForm.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    failedLoginAttempts++;

                    if (failedLoginAttempts >= 3) 
                    {
                        // Start the login timeout timer if it's not already running.
                        if (!loginTimeoutTimer.Enabled)
                        {
                            loginTimeoutTimer.Start();
                            lastFailedLoginTime = DateTime.Now;
                        }
                        else
                        {
                            // Check if the timeout duration has passed since the last failed login attempt.
                            if (DateTime.Now - lastFailedLoginTime < loginTimeoutDuration)
                            {
                                // Display a message indicating the login is timed out.
                                MessageBox.Show("Login is temporarily locked. Please try again later.", "Login Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                // Reset the failed login attempt count and update the last failed login time.
                                failedLoginAttempts = 0;
                                lastFailedLoginTime = DateTime.Now;
                                loginTimeoutTimer.Stop(); // Stop the timer as the user can try again now.
                            }
                        }
                    }

                    // Display the login failure message.
                    MessageBox.Show("Invalid username or password.", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (failedLoginAttempts >= 3)
            {
                // Display the login failure message.
                MessageBox.Show("Login is temporarily locked. Please try again later.", "Login Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Re-enable the login button after the timeout duration
                loginTimeoutTimer.Start();
                lastFailedLoginTime = DateTime.Now;
            }

            // Re-enable the login button if the login timeout is over.
            if (DateTime.Now - lastFailedLoginTime >= loginTimeoutDuration)
            {
                LoginFormBTN.Enabled = true;
            }
        }

    

    private void LoginTimeoutTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // The timer has elapsed. Reset the failed login counters and re-enable the login button.
            failedLoginAttempts = 0;
            lastAttemptedUsername = null;

            if (InvokeRequired)
            {
                //Invoke this on the UI thread because the timer runs on a separate thread.
                BeginInvoke(new Action(() => LoginFormBTN.Enabled = true));
            }
            else
            {
                LoginFormBTN.Enabled = true;
            }
        }




        private void CancelLoginBTN_Click(object sender, EventArgs e)
        {   
            //Re-Opens previous form (Register-or-Login)
            Register_or_Login_Form ROL = new Register_or_Login_Form();
            ROL.ShowDialog();
            this.Close();
        }

        private void ApplianceAdminClosed(object sender, FormClosedEventArgs e)
        {

        }


        
    }
}