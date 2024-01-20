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

namespace WpfDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class MyModel
        {
            public string Title { get; set; }
            public string Name { get; set; }
            public bool IsChecked { get; set; }
        }

        List<MyModel> lists = new List<MyModel>();

        public MainWindow()
        {
            InitializeComponent();
            lists.Add(new MyModel { Title = "asp", Name = "asp.net core" , IsChecked =true});
            lists.Add(new MyModel { Title = "php", Name = "laravel", IsChecked =false});
            lists.Add(new MyModel { Title = "python", Name = "jango", IsChecked =true});
            lists.Add(new MyModel { Title = "java", Name = "js", IsChecked =false});

            datagrid.ItemsSource = lists;
        }
    }
}
