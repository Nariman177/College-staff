using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged 
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private int _boundnumber;
        public int BoundNumber
        {
            get { return _boundnumber; }
            set { 
                if (_boundnumber != value)
                {
                    _boundnumber = value;
                    OnPropertyChanged();
                }
            
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
