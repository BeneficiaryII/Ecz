using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        public void Avtoriz()
        {
            SqlConnection connection = new SqlConnection(@"Server = MSI\SQLEXPRESS; Database = PersonnelOfTheEnterprise; Trusted_Connection=True;");
            string Login1 = textBox1.Text;
            string Password2 = textBox2.Text;
            string sqlExpression = $"SELECT * From Autorizations WHERE Login = '{Login1}' AND Password = '{Password2}';";
            connection.Open();

            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (Login1 == (reader["Login"].ToString()) && Password2 == (reader["Password"].ToString()))
                    {
                        Glavnaya Glav = new Glavnaya();
                        Glav.Show();

                        Autorization auto = new Autorization();
                        Hide();
                    }
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Введены неверные данные! Повторить ввод?", "Предупреждение!", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    Close();
                }
            }
            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Avtoriz();
        }
    }
}
