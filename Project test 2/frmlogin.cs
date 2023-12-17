using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_test_2
{
    public partial class frmLogin : Form
    {
        bool exit = true;

      
      
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(exit)       
                Application.Exit();
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ckbShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowpass.Checked)
                txbPassword.UseSystemPasswordChar = false;
            else
                txbPassword.UseSystemPasswordChar = true;
    
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            if(exit)
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            if (MessageBox.Show("You're closing the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            exit = false;
            if(txbUsername.Text == "")
            {
                MessageBox.Show("Please enter User name", "Warning");
                txbUsername.Focus();
                return;
            }

            if (txbPassword.Text == "")
            {
                MessageBox.Show("Please enter Password", "Warning");
                txbPassword.Focus();
                return;
            }
            frmworkingspace fws = new frmworkingspace();
            this.Close();
            fws.Show();                      
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
