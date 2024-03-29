﻿using System;
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

namespace WpfRGB_Slider
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color =   Color.FromRgb((byte)sliderR.Value, (byte)sliderB.Value, (byte)sliderG.Value);
            stck.Background = new SolidColorBrush (color);
        }

        private async  void Button_Click(object sender, RoutedEventArgs e)
        {
            prg.Value =0;
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(20);
               // Thread.Sleep(70);
                prg.Value += 1;
             }
        }
    }
}
