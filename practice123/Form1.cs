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

namespace practice123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // get the input from text boxes 
            string u_name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            int by = int.Parse(textBox4.Text);
            //assign the radio btn value to 0 
            int value = 0;
            //check and assign if radio btn is clicked
            if (radioButton1.Checked)
            {
                value = 1;
                
                radioButton1.Checked = false;
            }
            //get the connection from DB class 
            using (var connection = DB.GetConnection())
            {
                //insert value to the data base
                string qry = "insert into alluser values('" + u_name + "','" + email + "','" + password + "','" + value + "','" + by + "')";
                SqlCommand cmd = new SqlCommand(qry, connection);
                try {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data inserted");

                }
                catch(SqlException sq)
                {
                    MessageBox.Show("" + sq);
                }

                
            }
                
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //when the btn click open the next form and close this form
            Form2 fm = new Form2();
            this.Hide();
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
