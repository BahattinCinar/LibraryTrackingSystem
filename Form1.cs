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

namespace LibraryTrackingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string userName, password;

        public static Form2 form2 = new Form2();
        public static Form3 form3 = new Form3();

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide(); button3.Show();

            textBox2.PasswordChar = '\0';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide(); button2.Show();

            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text;
            password = textBox2.Text;

            if (userName == "admin" && password == "admin")
            {
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong user name or password");
                
                userName = ""; password = "";
            }
        }
    }
}
