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
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SCBOTSE\SQLEXPRESS;Initial Catalog=AirLine;Integrated Security=True");
        public FormLogin()
        {
            InitializeComponent();
        }



        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string user, pass;
            user = namBox.Text;
            pass = passBox.Text;

            string logQuery = "select * from ADMIN where Username = @id and  Password= @pin";

            SqlCommand logCmd = new SqlCommand(logQuery, con);
            logCmd.Parameters.AddWithValue("@id", user);
            logCmd.Parameters.AddWithValue("@pin", pass);

            SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
            DataSet LogSet = new DataSet();
            LogAdpater.Fill(LogSet);

            if ((LogSet.Tables[0].Rows.Count) > 0)
            {
                new FormAirport().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credientials are incorrect. Try Again :)");
                namBox.Text = "";
                passBox.Text = "";
            }

            con.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormSignUp().Show();
            this.Hide();
        }
        
    }
    }
