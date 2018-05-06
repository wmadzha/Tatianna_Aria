using System;
namespace Tatianna_Aria_Public_Model
{
 public class InventoryTransaction : IInventoryTransaction
    {
        public Guid InOutTransactionID
        { get; set; }

        public bool IsDeleted
        { get; set; }

        public bool IsEdited
        { get; set; }

        public bool IsOpen
        { get; set; }

        public bool IsVerified
        { get; set; }

        public Guid ItemID
        { get; set; }

        public Guid LastActiveUser
        { get; set; }

        public DateTime LastStamp
        { get; set; }

        public Guid PerformBy
        { get; set; }

        public string Quantity
        { get; set; }

        public string QuantityAfter
        { get; set; }

        public string QuantityBefore
        { get; set; }

        public DateTime TimeStamp
        { get; set; }

        public Guid VerifiedBy
        { get; set; }
    }
}
