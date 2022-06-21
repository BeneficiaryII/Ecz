using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            info_dob info_dob = new info_dob();
            info_dob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            info_del info_del = new info_del();
            info_del.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info_viv info_viv = new info_viv();
            info_viv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
