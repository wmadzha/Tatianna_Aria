using System;
namespace Tatianna_Aria_Public_Model
{
 public interface IInventoryTransaction
    {
        Guid InOutTransactionID { get; set; }
        string Quantity { get; set; }
        string QuantityBefore { get; set; }
        string QuantityAfter { get; set; }
        Guid PerformBy { get; set; }
        Guid VerifiedBy { get; set; }
        bool IsVerified { get; set; }
        bool IsDeleted { get; set; }
        bool IsOpen { get; set; }
        DateTime TimeStamp { get; set; }
        bool IsEdited { get; set; }
        DateTime LastStamp { get; set; }
        Guid LastActiveUser { get; set; }
        Guid ItemID { get; set; }
    }
}
