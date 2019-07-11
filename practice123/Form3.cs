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
    public partial class Form3 : Form
    {
        public Form3(string un)
        {
            //get the user name from the login page
            InitializeComponent();
            label1.Text = un;
            //show it 
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = label1.Text;
            using (var connection = DB.GetConnection())
            {
                string qry = "select birthyear from alluser where username = '" + name + "'";
                SqlCommand cmd = new SqlCommand(qry, connection);
                connection.Open();
                SqlDataReader sr = cmd.ExecuteReader();
                sr.Read();
                //check wether it has a data 
                if(sr.HasRows)
                {
                    //print it birth dat
                    label4.Text = sr["birthyear"].ToString();
                }
            }
            int dd = int.Parse(label4.Text);
           
                calculation cm = new calculation();
            //call the encapsulation methods
            cm.setvalu(dd);
                label2.Text = cm.getage().ToString();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (var connection = DB.GetConnection())
            {
                //show the database
                //alluser is my table
                string qry = "select * from alluser";
                SqlDataAdapter da = new SqlDataAdapter(qry, connection);  
                DataSet ds = new DataSet();
                da.Fill(ds, "alluser");
                //dataGridView1 is my dataGrid name
                dataGridView1.DataSource = ds.Tables["alluser"].DefaultView;
            }
        }
    }
}
