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

namespace WpfLOG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyLog.LogError("error eroe" +
                "Error logic for MainWindow.xaml" +
                "Error logic for MainWindow.xaml" +
                "Error logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "Error logic for MainWindow.xaml" +
                "Error logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "Error logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xamlError logic for MainWindow.xaml" +
                "");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyLog.LogInfo("info Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml " +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xaml Interaction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xamlInteraction logic for MainWindow.xamlInteraction logic for MainWindow.xamlInteraction logic for MainWindow.xaml" +
                "Interaction logic for MainWindow.xamlInteraction logic for MainWindow.xaml");

        }

        private void Button_Click_2(object sender, object e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _log.Error("Error logic for MainWindow.xaml");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _log.Info("Info logic for MainWindow.xaml");

        }
    }
}
