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
            label3.Text = "Book lending";
            pictureBox1.ImageLocation = @"C:\Users\ayten\OneDrive\Masaüstü\ABDCJSH\C#\Workspace\LibraryTrackingSystem\images\return-ico.png";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bookDB();
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
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 000 + "')", conn);
            }
            
            else if (bookClass == "Philosophy" || bookClass == "Philosophy and psychology" || bookClass == "psychology")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 100 + "')", conn);
            }

            else if(bookClass == "Religion")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 200 + "')", conn);
            }

            else if( bookClass == "social sciences")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 300 + "')", conn);
            }

            else if ( bookClass == "language")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 400 + "')", conn);
            }

            else if(bookClass == "fundamental sciences")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 500 + "')", conn);
            }

            else if(bookClass == "technology")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 600 + "')", conn);
            }

            else if(bookClass == "art and creativity" || bookClass == "art" || bookClass == "creativity")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 700 + "')", conn);
            }

            else if(bookClass == "literature")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 800 + "')", conn);
            }

            else if(bookClass == "history and geography" || bookClass == "history" || bookClass == "geography")
            {
                cmnd = new SqlCommand("INSERT INTO bookData (bookName,bookClass,id) VALUES('" + bookName + "','" + bookClass + "','" + 900 + "')",conn);
            }

            else
            {
                MessageBox.Show("Undefined Book Class please re enter");

                bookClass = Interaction.InputBox("");

                goto bookClassReturn;
            }

            cmnd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Book sucsessfully added");

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string
                borrowName = Interaction.InputBox("Borrow's Name", "Book Lending", "", 500, 500),
                borrowPhone = Interaction.InputBox("Borrow's Phone", "Book Lending", "", 500, 500),
                borrowAdress = Interaction.InputBox("Borrow's Phone", "Book Lending", "", 500, 500),
                borrowBook = Interaction.InputBox("Borrowed Book Name", "Book Lending", "", 500, 500);

            

            if (borrowBook != )
            {

            }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}
