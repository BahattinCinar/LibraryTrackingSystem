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
using Microsoft.VisualBasic;

namespace LibraryTrackingSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\ayten\OneDrive\Masaüstü\ABDCJSH\C#\Workspace\LibraryTrackingSystem\images\return-ico.png";

            dbView();

        }

        private void dbView()
        {
            Form2.conn.Open();
            Form2.cmnd = new SqlCommand("SELECT * FROM bookData", Form2.conn);

            SqlDataReader read = Form2.cmnd.ExecuteReader();

            while(read.Read())
            {
                ListViewItem bookItem = new ListViewItem();

                bookItem.Text = read["bookName"].ToString();
                bookItem.SubItems.Add(read["bookClass"].ToString());
                bookItem.SubItems.Add(read["id"].ToString());
                listView1.Items.Add(bookItem);
            }

            Form2.cmnd = new SqlCommand("SELECT * FROM userData LEFT JOIN takenData on userData.bookName = bookData.bookName", Form2.conn);
            
            while (read.Read())
            {
                ListViewItem takenBook = new ListViewItem();

                takenBook.Text = read["userName"].ToString();
                takenBook.SubItems.Add(read["bookName"].ToString());
                listView2.Items.Add(takenBook);
            }

            Form2.conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.form2.ShowDialog();
        }
    }
}
