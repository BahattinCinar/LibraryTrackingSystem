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
            SqlCommand booksDB = new SqlCommand("SELECT * FROM bookData", Form2.conn);

            SqlDataReader read = booksDB.ExecuteReader();

            while(read.Read())
            {
                ListViewItem bookItem = new ListViewItem();

                bookItem.Text = read["bookName"].ToString();
                bookItem.SubItems.Add(read["bookClass"].ToString());
                bookItem.SubItems.Add(read["id"].ToString());
                listView1.Items.Add(bookItem);
            }

            /*SqlCommand land = new SqlCommand("SELECT bookName FROM bookData INNER JOIN (SELECT userName FROM userData) ON bookName.bookData = bookName.userData", Form2.conn);

            
            while (readLand.Read())
            {
                ListViewItem takenBook = new ListViewItem();

                takenBook.Text = readLand["userName"].ToString();
                takenBook.SubItems.Add(readLand["bookName"].ToString());
                listView2.Items.Add(takenBook);
            }
            */
            Form2.conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
