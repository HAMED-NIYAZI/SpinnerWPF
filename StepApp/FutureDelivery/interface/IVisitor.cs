using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepApp
{
    // Define the Visitor interface
    public interface IVisitor
    {
        void Visit(PrepareContract prepareContract);
        void Visit(RemoveSymbolFromBoard removeSymbolFromBoard);
        void Visit(DeliveryPrepation deliveryPrepation);
        void Visit(DeliveryPreview deliveryPreview);
        void Visit(UpdateBuyeraccounts updateBuyeraccounts);
        void Visit(GetAssets getAssets);
        void Visit(UpdateAssets updateAssets);
        void Visit(CalcSellerDefault calcSellerDefault);
        void Visit(CalculateDefault calculateDefault);
        void Visit(FinalDelivery finalDelivery);
        void Visit(CreatAssignmentList creatAssignmentList);
        void Visit(SendAssignmentList sendAssignmentList);
        void Visit(GetWareHouseCosts getWareHouseCosts);
        void Visit(SaveWarehouseCosts saveWarehouseCosts);
        void Visit(EndProcess end);

        // Add more methods for other steps
    }

}
