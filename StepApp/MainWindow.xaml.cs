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

namespace StepApp
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


        private void PrepareContractButton_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var prepareContractElement = new PrepareContract();

            prepareContractElement.Accept(visitor);
        }

        private void RemoveSymbolFromBoardButton_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var prepareContractElement = new RemoveSymbolFromBoard();

            prepareContractElement.Accept(visitor);
        }

        private void DeliveryPrepationButton_Click(object sender, RoutedEventArgs e)
        {
           IVisitor visitor = new ConcreteVisitor();

            var DeliveryPrepation = new DeliveryPrepation();

            DeliveryPrepation.Accept(visitor);
        }

        private void DeliveryPreview_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var DeliveryPreview = new DeliveryPreview();

            DeliveryPreview.Accept(visitor);
        }

        private void UpdateBuyeraccounts_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var UpdateBuyeraccounts = new UpdateBuyeraccounts();

            UpdateBuyeraccounts.Accept(visitor);
        }

        private void GetAssets_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var GetAssets = new GetAssets();

            GetAssets.Accept(visitor);
        }

        private void UpdateAssets_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var UpdateAssets = new UpdateAssets();

            UpdateAssets.Accept(visitor);
        }

        private void CalcSellerDefault_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var CalcSellerDefault = new CalcSellerDefault();

            CalcSellerDefault.Accept(visitor);
        }

        private void CalculateDefault_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var CalculateDefault = new CalculateDefault();

            CalculateDefault.Accept(visitor);
        }

        private void FinalDelivery_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var FinalDelivery = new FinalDelivery();

            FinalDelivery.Accept(visitor);
        }

        private void CreatAssignmentList_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var CreatAssignmentList = new CreatAssignmentList();

            CreatAssignmentList.Accept(visitor);
        }

        private void SendAssignmentList_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var SendAssignmentList = new SendAssignmentList();

            SendAssignmentList.Accept(visitor);
        }

        private void GetWareHouseCosts_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var GetWareHouseCosts = new GetWareHouseCosts();

            GetWareHouseCosts.Accept(visitor);
        }

        private void SaveWarehouseCosts_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var SaveWarehouseCosts = new SaveWarehouseCosts();

            SaveWarehouseCosts.Accept(visitor);
        }

        private void EndProcess_Click(object sender, RoutedEventArgs e)
        {
            IVisitor visitor = new ConcreteVisitor();

            var EndProcess = new EndProcess();

            EndProcess.Accept(visitor);
        }
    }

}
