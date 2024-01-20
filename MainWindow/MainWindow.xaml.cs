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

namespace MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentStep = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Step1Button_Click(object sender, RoutedEventArgs e)
        {
            // Process logic for Step 1
            // Update UI elements as needed

            // Move to next step
            currentStep++;
            CurrentStepLabel.Text = $"Current Step: {currentStep}";
            ProgressBar.Value = currentStep;
            Step1Button.IsEnabled = false;
            Step2Button.IsEnabled = true;
        }

        private void Step2Button_Click(object sender, RoutedEventArgs e)
        {
            // Process logic for Step 2
            // Update UI elements as needed

            // Move to next step
            currentStep++;
            CurrentStepLabel.Text = $"Current Step: {currentStep}";
            ProgressBar.Value = currentStep;
            Step2Button.IsEnabled = false;
            Step3Button.IsEnabled = true;
        }

        private void Step3Button_Click(object sender, RoutedEventArgs e)
        {
            // Process logic for Step 3
            // Update UI elements as needed

            // Reset for next time
            currentStep = 1;
            CurrentStepLabel.Text = $"Current Step: {currentStep}";
            ProgressBar.Value = currentStep;
            Step1Button.IsEnabled = true;
            Step2Button.IsEnabled = false;
            Step3Button.IsEnabled = false;
        }
    }

}
