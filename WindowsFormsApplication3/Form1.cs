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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бонусы спишет администратор на локации");
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // This is bad
            f.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // This is bad
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за подтверждение. Ждем вас!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Временно недоступно");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эх, а мы вас ждали");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Временно недоступно");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(); // This is bad
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            string quest = comboBox1.Text;
            int rating = Convert.ToInt32(numericUpDown1.Value);
            string reviewText = textBox2.Text;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Арина\Documents\Мои документы\Access\Администраторы.accdb";

            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                // ВАЖНО: Проверьте названия столбцов в вашей таблице "Отзывы"
                string query = "INSERT INTO [Отзывы] ([Ваше имя], [Дата], [Название квеста], [Оценка квеста], [Текст отзыва]) VALUES (@name, @date, @quest, @rating, @text)";

                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                dbCommand.Parameters.AddWithValue("@name", name);
                dbCommand.Parameters.AddWithValue("@date", date);
                dbCommand.Parameters.AddWithValue("@quest", quest);
                dbCommand.Parameters.AddWithValue("@rating", rating);
                dbCommand.Parameters.AddWithValue("@text", reviewText);

                if (dbCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Спасибо, что оставили отзыв!");
                else
                    MessageBox.Show("Ошибка при отправке отзыва", "Внимание!");
            }
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
