using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if(email=="admin"&& password == "123456")
            {
                Dashboard ds = new Dashboard();
                ds.ShowDialog();
            }
            else
            {
                MessageBox.Show("Duz gir əəə !!");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
