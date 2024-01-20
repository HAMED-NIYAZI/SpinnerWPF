using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepApp
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(PrepareContract prepareContract)
        {
            // Logic for PrepareContractElement
        }

        public void Visit(RemoveSymbolFromBoard removeSymbolFromBoard)
        {
            // Logic for RemoveSymbolFromBoardElement
        }

        public void Visit(DeliveryPrepation deliveryPrepation)
        {
            // Logic for DeliveryPrepation
        }  

        public void Visit(DeliveryPreview deliveryPreview)
        {
            // Logic for DeliveryPrepation
        }     
        
        public void Visit(UpdateBuyeraccounts updateBuyeraccounts)
        {
            // Logic for DeliveryPrepation
        }        
        public void Visit(GetAssets getAssets)
        {
            // Logic for DeliveryPrepation
        }        
        public void Visit(UpdateAssets updateAssets)
        {
            // Logic for DeliveryPrepation
        }        
        public void Visit(CalcSellerDefault calcSellerDefault)
        {
            // Logic for DeliveryPrepation
        }        
        public void Visit(CalculateDefault calculateDefault)
        {
            // Logic for DeliveryPrepation
        }        
        public void Visit(FinalDelivery finalDelivery)
        {
            // Logic for DeliveryPrepation
        }        
        public void Visit(CreatAssignmentList creatAssignmentList)
        {
            // Logic for DeliveryPrepation
        }        
        public void Visit(SendAssignmentList sendAssignmentList)
        {
            // Logic for DeliveryPrepation
        }
                
        public void Visit(GetWareHouseCosts getWareHouseCosts)
        {
            // Logic for DeliveryPrepation
        }
                
        public void Visit(SaveWarehouseCosts saveWarehouseCosts)
        {
            // Logic for DeliveryPrepation
        }
                
        public void Visit(EndProcess end)
        {
            // Logic for DeliveryPrepation
        }

        // Add more methods for other steps
    }

}
