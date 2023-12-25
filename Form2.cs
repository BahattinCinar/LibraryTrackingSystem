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

        public static SqlConnection conn = new SqlConnection(@"Data Source = Bahattin\SQLEXPRESS; Initial Catalog = bookDB; Integrated Security = TRUE");
        public static SqlCommand cmnd = new SqlCommand();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Welcome " + Form1.userName;
            label1.Text = "Add new book";
            label2.Text = "List all records";
            pictureBox1.ImageLocation = @"C:\Users\ayten\OneDrive\Masaüstü\ABDCJSH\C#\Workspace\LibraryTrackingSystem\images\return-ico.png";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookDB()
        {
            conn.Open();

            string bookName, bookClass;

            bookName = Interaction.InputBox("Book Name","Book","here",500,500);
            bookClass = Interaction.InputBox("Book Class","class","here",500,500);

            bookClassReturn:

            if (bookClass == "computer" || bookClass == "informatics and general studies" || bookClass == "informatics" || bookClass == "general studies")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName,bookClass,id) VALUES ('" + bookName + bookClass + 000 + "')");
            }
            
            else if (bookClass == "Philosophy" || bookClass == "Philosophy and psychology" || bookClass == "psychology")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName,bookClass,id) VALUES ('" + bookName + bookClass + 100 + "')");
            }

            else if(bookClass == "Religion")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName,bookClass,id) VALUES ('" + bookName + bookClass + 200 + "')");
            }

            else if( bookClass == "social sciences")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName, bookClass, id) VALUES('" + bookName + bookClass + 300 + "')");
            }

            else if ( bookClass == "language")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName, bookClass, id) VALUES('" + bookName + bookClass + 400 + "')");
            }

            else if(bookClass == "fundamental sciences")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName, bookClass, id) VALUES('" + bookName + bookClass + 500 + "')");
            }

            else if(bookClass == "technology")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName, bookClass, id) VALUES('" + bookName + bookClass + 600 + "')");
            }

            else if(bookClass == "art and creativity" || bookClass == "art" || bookClass == "creativity")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName, bookClass, id) VALUES('" + bookName + bookClass + 700 + "')");
            }

            else if(bookClass == "literature")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName, bookClass, id) VALUES('" + bookName + bookClass + 800 + "')");
            }

            else if(bookClass == "history and geography" || bookClass == "history" || bookClass == "geography")
            {
                cmnd = new SqlCommand("cmnd INTO bookData(bookName, bookClass, id) VALUES('" + bookName + bookClass + 900 + "')");
            }

            else
            {
                MessageBox.Show("Undefined Book Class please re enter");

                bookClass = Interaction.InputBox("");

                goto bookClassReturn;
            }

            MessageBox.Show("Book sucsessfully added");

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bookDB();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.form3.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.form1.ShowDialog();
        }
    }
}
