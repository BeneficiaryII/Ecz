using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class info_viv : Form
    {
        public info_viv()
        {
            InitializeComponent();
        }

        private void info_viv_Load(object sender, EventArgs e)
        {
            this.personnelTableAdapter.Fill(this.personnelOfTheEnterpriseDataSet2.Personnel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.personnelTableAdapter.Update(this.personnelOfTheEnterpriseDataSet2.Personnel);
        }
    }
}
