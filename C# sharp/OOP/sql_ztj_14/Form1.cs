using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sql_ztj_14
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dataSet1.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            ageTextBox.Clear();
            genderTextBox.Clear();
            cityTextBox.Clear();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
