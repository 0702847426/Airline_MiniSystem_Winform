using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine_System
{
    public partial class FormSignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SCBOTSE\SQLEXPRESS;Initial Catalog=AirLine;Integrated Security=True");

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string firstName = firstNameBox.Text;
            //string lastName = lastNameBox.Text;
            //string adminID = adminBox.Text;
            //string userName = namBox.Text;
            //string password = passBox.Text;
            //string email = emailBox.Text;
            //string contact = contactBox.Text;
            //string address = addressBox.Text;

            con.Open();
            string firstQuery = "INSERT INTO ADMIN values(@a, @b, @c, @d, @e)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@a", firstNameBox.Text);
            cmd.Parameters.AddWithValue("@b", lastNameBox.Text);
            cmd.Parameters.AddWithValue("@c", adminBox.Text);
            cmd.Parameters.AddWithValue("@d", namBox.Text);
            cmd.Parameters.AddWithValue("@e", passBox.Text);
            //cmd.Parameters.AddWithValue("@f", email);
            //cmd.Parameters.AddWithValue("@g", contact);
            //cmd.Parameters.AddWithValue("@h", address);
            cmd.ExecuteNonQuery();
            con.Close();

            new FormLogin().Show();
            this.Hide();
        }
    }
    }
