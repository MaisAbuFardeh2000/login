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
                //btnAddItems.Show();
                //btnUpdate.Show();
                //btnRemoveItems.Hide();
            }
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAddItems.Hide();
            btnUpdate.Hide();
            btnRemoveItems.Hide();
        }
    }
}
