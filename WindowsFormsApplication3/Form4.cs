using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text;
            string password = textBox2.Text;

            // Проверьте точное расширение файла (.accdb или .mdb)
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Арина\Documents\Мои документы\Access\Администраторы.accdb";

            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                string query = "SELECT COUNT(*) FROM [Администраторы] WHERE [Номер телефона] = @phone AND [Пароль] = @pass";

                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                dbCommand.Parameters.AddWithValue("@phone", phone);
                dbCommand.Parameters.AddWithValue("@pass", password);

                int count = Convert.ToInt32(dbCommand.ExecuteScalar());

                if (count > 0)
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный номер телефона или пароль!", "Ошибка");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
