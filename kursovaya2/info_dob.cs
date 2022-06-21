using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class info_dob : Form
    {
        public info_dob()
        {
            InitializeComponent();
        }
      
        private void info_dob_Load(object sender, EventArgs e)
        {
            this.personnelTableAdapter.Fill(this.personnelOfTheEnterpriseDataSet.Personnel);
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            try
            {
                this.personnelTableAdapter.Update(this.personnelOfTheEnterpriseDataSet.Personnel);
            }
            catch { MessageBox.Show("Введены неверные данные! Повторить ввод?", "Предупреждение!"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dob_post  post = new dob_post();
            post.Show();
        }
    }
}
