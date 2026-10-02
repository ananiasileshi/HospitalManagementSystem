using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_MS
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            Admin.Text = " ";
            Password.Text = " ";
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Admin.Text== "" && Password.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Admin.Text== "Admin" && Password.Text== "Password") 
            { 
                Home obj = new Home();  
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Username And Password");
            }
        }
    }
}
