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

namespace WpfList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            lists.Add(new MyModel { Title="item 1" , Value =12});
            lists.Add(new MyModel { Title="item 2" , Value =33});
            lists.Add(new MyModel { Title="item 3" , Value =44});
            lists.Add(new MyModel { Title="item 4" , Value =55});
            lists.Add(new MyModel { Title="item 5" , Value =77});
            lists.Add(new MyModel { Title="item 6" , Value =156});
            cmb.ItemsSource = lists; 
        }

        public class MyModel {
            public string Title { get; set; }
            public int Value { get; set; }
        }

        List<MyModel> lists=new List<MyModel>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((string)cmb.SelectedValue.ToString());
        }

        private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
