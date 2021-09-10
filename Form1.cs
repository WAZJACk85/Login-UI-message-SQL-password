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
namespace Login_Demo_Shop
{

    public partial class Form1 : Form
    {
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();


        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = LAPTOP-LL7MF4G0\MSSQL_APPOINT; Initial Catalog = westlake; Integrated Security = True";
        }

        
        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username \ Email"))
            {
                txtUsername.Text = "";
            }

        }

        private void txtUserLeave(object sender, EventArgs e)
        {

            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username \ Email";
            }

        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }

        }

        private void txtPassLeave(object sender, EventArgs e)
        {

            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = ("Password");
            }



        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from AUTH";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtUsername.Text.Equals(dr["username"].ToString()) && txtPassword.Text.Equals(dr["password"].ToString()))
                {
                    MessageBox.Show("Login Successfull", "Well Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password or Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();


        }
    }   
}
