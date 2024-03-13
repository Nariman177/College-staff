using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kama_ztj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.dataSet1.Работники);

        }

        private void работникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.работникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
