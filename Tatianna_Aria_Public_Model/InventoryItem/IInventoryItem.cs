using System;
namespace Tatianna_Aria_Public_Model
{
public interface IInventoryItem
    {
        Guid ItemID { get; set; }
        string ItemName { get; set; }
        string ItemBrand { get; set; }
        string ItemType { get; set; }
        string ItemCategory { get; set; }
        string ItemSubCategory { get; set; }
        string Quantity { get; set; }
        string ItemUnit { get; set; }
        DateTime Stamp { get; set; }
        System.Nullable<System.Guid> Owner { get; set; }
        DateTime LastStamp { get; set; }
        bool IsDeleted { get; set; }
        System.Nullable<System.Guid> LastActiveUser { get; set; }
        bool IsActive { get; set; }
        string ItemPrice { get; set; }
        string IItemLastBoughtPrice { get; set; }
        string ItemLastBoughtLocation { get; set; }
        string ItemExpectedLocation { get; set; }
        System.Nullable<long> MinimumQuantity { get; set; }
        System.Nullable<long> MaximumQuantity { get; set; }
        System.Nullable<System.Guid> WarehouseID { get; set; }
    }
}
