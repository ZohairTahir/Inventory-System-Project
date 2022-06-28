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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-SNT8I0K;Initial Catalog=DB Inventory Management;Integrated Security=True";

       


        /*
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                //string l = ("update Products set Product_Name= @textBox2.Text,Category=@textBox3.Text,Quantity=@textBox4.Text,Manufacturer_ID=@textBox5.Text,Price=@textBox6.Text,Category_ID = @textBox7,Order_ID = @textBox8 where Product_ID = textBox1", con);
                SqlCommand cmd = new SqlCommand("update Products set Product_Name = '" + textBox2.Text + "', Category = '" + textBox3.Text + "', Quantity = '" + textBox4.Text + "', Manufacturer_ID = '" + textBox5.Text + "', Price = '" + textBox6.Text + "', Category_ID = '" + textBox7.Text + "', Order_ID = '" + textBox8.Text + "' where Product_ID = '" + int.Parse(textBox1.Text) + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully");
            }
        }
        */
        /*

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string l = "DELETE FROM Products WHERE Product_ID =" + "'" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(l, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully");

            }

        }
        */
        /*
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Product_ID,Product_Name,Price,Category_Name from Products Right JOIN Categories ON Products.Category_ID=Categories.Category_ID", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                // MessageBox.Show("Product updated successfully");
            }
        }
        */
        /*
        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Product_Name, Price,Date_of_Sale from Products inner JOIN Sales ON Products.Product_ID=Sales.Product_ID ", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }


        }
        */


        /*
        private void button8_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("select Manufacturer_Name,Product_Name from Products left join Manufacturers  on Products.Manufacturer_ID = Manufacturers.Manufacturer_ID ", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }
        */
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Products", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Products(Product_ID,Product_Name,Category,Quantity,Manufacturer_ID,Price,Category_ID,Order_ID) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Products", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Products(Product_ID,Product_Name,Category,Quantity,Manufacturer_ID,Price,Category_ID,Order_ID) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                //string l = ("update Products set Product_Name= @textBox2.Text,Category=@textBox3.Text,Quantity=@textBox4.Text,Manufacturer_ID=@textBox5.Text,Price=@textBox6.Text,Category_ID = @textBox7,Order_ID = @textBox8 where Product_ID = textBox1", con);
                SqlCommand cmd = new SqlCommand("update Products set Product_Name = '" + textBox2.Text + "', Category = '" + textBox3.Text + "', Quantity = '" + textBox4.Text + "', Manufacturer_ID = '" + textBox5.Text + "', Price = '" + textBox6.Text + "', Category_ID = '" + textBox7.Text + "', Order_ID = '" + textBox8.Text + "' where Product_ID = '" + int.Parse(textBox1.Text) + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string l = "DELETE FROM Products WHERE Product_ID =" + "'" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(l, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully");

            }
        }
    }
}
