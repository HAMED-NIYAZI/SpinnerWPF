using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SpinnerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool IsLoading { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spinner1.Visibility = Visibility.Visible;
            //mylabelLoading.Visibility = Visibility.Collapsed;
            //mylabel.Visibility = Visibility.Collapsed;

          Thread.Sleep(7000);



            spinner1.Visibility = Visibility.Collapsed;
             //mylabelLoading.Visibility = Visibility.Visible;
             //mylabel.Visibility = Visibility.Visible; 
        }
    }
}
