using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class info_del : Form
    {
        public info_del()
        {
            InitializeComponent();
        }

        private void info_del_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnelOfTheEnterpriseDataSet1.Personnel". При необходимости она может быть перемещена или удалена.
            this.personnelTableAdapter.Fill(this.personnelOfTheEnterpriseDataSet1.Personnel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.personnelTableAdapter.Update(this.personnelOfTheEnterpriseDataSet1.Personnel);
        }

    }
}
