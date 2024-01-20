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

namespace WpfComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public class myModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            List<myModel> items = new List<myModel>();
            items.Add(new myModel { Id = 1, Name = "items 1" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 2, Name = "items 2" });
            items.Add(new myModel { Id = 3, Name = "items 3" });
            items.Add(new myModel { Id = 4, Name = "items 4" });

            myComboBox.ItemsSource = items;

        }
    }
}
