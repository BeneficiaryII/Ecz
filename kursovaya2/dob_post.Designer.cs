
namespace kursovaya2
{
    partial class dob_post
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelOfTheEnterpriseDataSet3 = new kursovaya2.PersonnelOfTheEnterpriseDataSet3();
            this.postTableAdapter = new kursovaya2.PersonnelOfTheEnterpriseDataSet3TableAdapters.PostTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelOfTheEnterpriseDataSet4 = new kursovaya2.PersonnelOfTheEnterpriseDataSet4();
            this.wagesTableAdapter = new kursovaya2.PersonnelOfTheEnterpriseDataSet4TableAdapters.WagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelOfTheEnterpriseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelOfTheEnterpriseDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(243, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(254, 239);
            this.dataGridView1.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.personnelOfTheEnterpriseDataSet3;
            // 
            // personnelOfTheEnterpriseDataSet3
            // 
            this.personnelOfTheEnterpriseDataSet3.DataSetName = "PersonnelOfTheEnterpriseDataSet3";
            this.personnelOfTheEnterpriseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.wagDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.wagesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(366, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 239);
            this.dataGridView2.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // wagDataGridViewTextBoxColumn
            // 
            this.wagDataGridViewTextBoxColumn.DataPropertyName = "Wag";
            this.wagDataGridViewTextBoxColumn.HeaderText = "Wag";
            this.wagDataGridViewTextBoxColumn.Name = "wagDataGridViewTextBoxColumn";
            // 
            // wagesBindingSource
            // 
            this.wagesBindingSource.DataMember = "Wages";
            this.wagesBindingSource.DataSource = this.personnelOfTheEnterpriseDataSet4;
            // 
            // personnelOfTheEnterpriseDataSet4
            // 
            this.personnelOfTheEnterpriseDataSet4.DataSetName = "PersonnelOfTheEnterpriseDataSet4";
            this.personnelOfTheEnterpriseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wagesTableAdapter
            // 
            this.wagesTableAdapter.ClearBeforeFill = true;
            // 
            // dob_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 395);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "dob_post";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dob_post";
            this.Load += new System.EventHandler(this.dob_post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelOfTheEnterpriseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelOfTheEnterpriseDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonnelOfTheEnterpriseDataSet3 personnelOfTheEnterpriseDataSet3;
        private System.Windows.Forms.BindingSource postBindingSource;
        private PersonnelOfTheEnterpriseDataSet3TableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PersonnelOfTheEnterpriseDataSet4 personnelOfTheEnterpriseDataSet4;
        private System.Windows.Forms.BindingSource wagesBindingSource;
        private PersonnelOfTheEnterpriseDataSet4TableAdapters.WagesTableAdapter wagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagDataGridViewTextBoxColumn;
    }
}