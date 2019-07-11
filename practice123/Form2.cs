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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string unm = textBox1.Text;
            string psw = textBox2.Text;
            //call the abstact methods
            login lg = new student();
            //there is a return value so i assign this to a variable so i can check values
            int a =lg.log(unm, psw);
            if(a == 1)
            {
                Form3 fm = new Form3(unm);
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("error");
            }

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string unm = textBox4.Text;
            string psw = textBox3.Text;

            //call the abstact methods
            login lg = new lectures();
            int a = lg.log(unm, psw);
            //there is a return value so i assign this to a variable so i can check values
            if (a == 1)
            {
                Form3 fm = new Form3(unm);
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
