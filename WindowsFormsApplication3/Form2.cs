using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToShortDateString();
            string questName = comboBox1.Text;
            string timeSlot = comboBox2.Text;
            int peopleCount = Convert.ToInt32(numericUpDown1.Value);
            string clientName = textBox2.Text;
            string phone = textBox3.Text;
            string email = textBox4.Text;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Арина\Documents\Мои документы\Access\Администраторы.accdb";

            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                // ВАЖНО: Проверьте, чтобы названия столбцов в квадратных скобках точно совпадали с вашей таблицей в Access
                string query = "INSERT INTO [Бронирование квеста] ([Дата], [Название квеста], [Свободные слоты], [Количество участников], [Имя заказчика], [Номер телефона], [Электронная почта]) VALUES (@date, @quest, @slot, @count, @name, @phone, @email)";

                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                dbCommand.Parameters.AddWithValue("@date", date);
                dbCommand.Parameters.AddWithValue("@quest", questName);
                dbCommand.Parameters.AddWithValue("@slot", timeSlot);
                dbCommand.Parameters.AddWithValue("@count", peopleCount);
                dbCommand.Parameters.AddWithValue("@name", clientName);
                dbCommand.Parameters.AddWithValue("@phone", phone);
                dbCommand.Parameters.AddWithValue("@email", email);

                if (dbCommand.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы успешно забронировали квест!");
                else
                    MessageBox.Show("Ошибка при бронировании", "Внимание!");
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Время забронировано за вами");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Время забронировано за вами");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); // This is bad
            f.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
