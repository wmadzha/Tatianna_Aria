using System;
namespace Tatianna_Aria_Public_Model
{
     public class InventoryItem : IInventoryItem
     {
     public string IItemLastBoughtPrice
        { get; set; }

        public bool IsActive
        { get; set; }

        public bool IsDeleted
        { get; set; }

        public string ItemBrand
        { get; set; }

        public string ItemCategory
        { get; set; }

        public string ItemExpectedLocation
        { get; set; }

        public Guid ItemID
        { get; set; }

        public string ItemLastBoughtLocation
        { get; set; }

        public string ItemName
        { get; set; }

        public string ItemPrice
        { get; set; }

        public string ItemSubCategory
        { get; set; }

        public string ItemType
        { get; set; }

        public string ItemUnit
        { get; set; }

        public Guid? LastActiveUser
        { get; set; }

        public DateTime LastStamp
        { get; set; }

        public long? MaximumQuantity
        { get; set; }

        public long? MinimumQuantity
        { get; set; }

        public Guid? Owner
        { get; set; }

        public string Quantity
        { get; set; }

        public DateTime Stamp
        { get; set; }

        public Guid? WarehouseID
        { get; set; }
     }
}
