using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                Dashbord ds = new Dashbord();
                ds.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or password");
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashbord ds = new Dashbord();
            ds.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

//dashbord form
/*
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login1
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        public Dashbord(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemoveItems.Hide();
            }
            else if (user == "Admin")
            {
               // btnAddItems.Show();
                //btnUpdate.Show();
                 // btnRemoveItems.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemoveItems.Hide();
        }
        
            
            
    
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm =new Form1();
            this.Hide();
            fm.Show();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }
    }
}

 
 
 */
