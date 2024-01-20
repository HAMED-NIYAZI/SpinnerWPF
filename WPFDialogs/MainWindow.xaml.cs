using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;

namespace WPFDialogs
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt",
                FileName = "Hello",
                Title = "Only Text File (*.txt)",
                InitialDirectory = @"D:\temp",
                Multiselect = false,


            };

            if ((bool)dialog.ShowDialog())
            {
                txt.Text = File.ReadAllText(dialog.FileName);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt",
                FileName = "Hello",
                Title = "Only Text File (*.txt)",
                InitialDirectory = @"D:\temp",
            };

            if ((bool)dialog.ShowDialog())
            {
                File.WriteAllText(dialog.FileName, txt.Text);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog() 
            {
                Description="Select Folder"
            };

            if (dialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                txt.Text = dialog.SelectedPath;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
          var dialog=  new CustomDialog("Select organization");

            if ((bool)dialog.ShowDialog())
            {
                txt.Text = dialog.Data;
            }
            
        }
    }
}
