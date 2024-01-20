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

namespace WPFMenu
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

        public static string MakeTitle(string str)
        {
             char[] str2 = new char[str.Length];
            for (int i = 0; i < str.Count(); i++)
            {
                if (str2[i]== char.Parse("\0") && i!=0 )
                str2[i] += str[i];

                if (i == 0)
                {
                    str2[0] = Char.ToUpper(str[0]);
                    continue;
                }

                if (str[i] ==  char.Parse(" "))
                {
                    str2[i + 1] = Char.ToUpper(str[i + 1]);
                    continue;
                }
            }
            return new string(str2);
         }

        private void button_Click(object sender, RoutedEventArgs e)
        {
          var s0=  MakeTitle("i am is");
          var s1=  MakeTitle("This is a title");

            var s2 = MakeTitle("capitalize every word");

            var s3 = MakeTitle("I Like Pizza");

            var s4 = MakeTitle("PIZZA PIZZA PIZZA");


        }
    }
}
