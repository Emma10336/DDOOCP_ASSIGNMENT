using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOOCP_ASSIGNMENT
{
    public partial class Register_or_Login_Form : Form
    {
        public Register_or_Login_Form()
        {
            InitializeComponent();
        }


        private void LoginSelectionBTN_Click(object sender, EventArgs e)
        {   //Opening of login form and closing of current form
            Login l1 = new Login();
            l1.FormClosed += LoginFormClosed;
            l1.Show();
            this.Hide();
        }

        //method for closing login form
        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

            private void RegisterSelectionBTN_Click(object sender, EventArgs e)
        {
            // Opening of register form and closing of current form
            RegisterForm r1 = new RegisterForm();
            r1.FormClosed += RegisterFormClosed;
            r1.ShowDialog();
            this.Hide();

        }

        //method for closing login form
        private void RegisterFormClosed(object sender, FormClosedEventArgs e)
        { 
            this.Close(); 
        }

    }
}
