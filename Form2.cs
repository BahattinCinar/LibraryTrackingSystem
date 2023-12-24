using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace LibraryTrackingSystem
{
    public partial class Form2 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source = Bahattin\SQLEXPRESS; Initial Catalog = bookDB; Integrated Security = TRUE");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + Form1.userName;
            button1.Text = "Add new book";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bookDB()
        {
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM bookData", conn);
            SqlDataReader read = sqlCommand.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["bookName"].ToString();
                add.SubItems.Add(read["bookClass"].ToString());
            }
        }
    }
}
