using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obb12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void addStudent(string name, string surname, string recordBookNumber)
        {
            Student s = new Student(name, surname, recordBookNumber);
            studentList.Add(s);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            showListInGrid();
        }

        private void deleteStudent(int elementIndex)
        {
            studentList.RemoveAt(elementIndex);
            showListInGrid();
        }

        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Student s in studentList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell celll = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                celll.ValueType = typeof(string);
                celll.Value = s.getName();
                cell2.ValueType = typeof(string);
                cell2.Value = s.getSurname();
                cell3.ValueType = typeof(string);
                cell3.Value = s.getRecordBookNumber();
                row.Cells.Add(celll); 
                row.Cells.Add(cell2); 
                row.Cells.Add(cell3); 
                dataGridView1.Rows.Add(row);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStudent(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить студента?", "", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                try
                {
                    deleteStudent(selectedRow);
                }
                catch (Exception)
                { }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
