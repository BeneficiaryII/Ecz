using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class dob_post : Form
    {
        public dob_post()
        {
            InitializeComponent();
        }

        private void dob_post_Load(object sender, EventArgs e)
        {
            this.wagesTableAdapter.Fill(this.personnelOfTheEnterpriseDataSet4.Wages);
 
            this.postTableAdapter.Fill(this.personnelOfTheEnterpriseDataSet3.Post);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.wagesTableAdapter.Update(this.personnelOfTheEnterpriseDataSet4.Wages);
            this.postTableAdapter.Update(this.personnelOfTheEnterpriseDataSet3.Post);
        }
    }
}
