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

namespace Inventory_System_Project
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public string conString = "Data Source=DESKTOP-SNT8I0K;Initial Catalog=DB Inventory Management;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            string q = "select * from Tbl_Login where Username = '" +textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(q, conString);
            DataTable dtbl = new DataTable();
            sda.Fill (dtbl);
            if(dtbl.Rows.Count == 1)
            {
                Form2 form = new Form2();
                form.Show();
                MessageBox.Show("Logged in succefully");
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password! Please try again");
            }
            

        }
    }

    }

