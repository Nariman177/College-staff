using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace ztj_14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WPF на METANIT.COM");
        }

        public MainWindow()
        {
            
            InitializeComponent();
        }
        public void clearData()
        {
            name_txt.Clear();
            age_txt.Clear();
            gender_txt.Clear();
            city_txt.Clear();
            search_txt.Clear();
        }
        public string con_string = "Data Source=LAPTOP-2CSQKGGH\\SQLEXPRESS;Initial Catalog=NewBase;Integrated Security=True";
        public void LoadGrid()
        {
           
        }
    }

}
