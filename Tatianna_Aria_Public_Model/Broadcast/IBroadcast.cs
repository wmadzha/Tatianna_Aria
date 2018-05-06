using System;
namespace Tatianna_Aria_Public_Model
{
    public interface IBroadcast
    {
        Guid BroadcastSeatID { get; set; }
        Guid ItemID { get; set; }
        Guid UserID { get; set; }
        bool Read { get; set; }
        bool Update { get; set; }
        bool Delete { get; set; }
        DateTime Stamp { get; set; }
        bool IsDeleted { get; set; }

    }
}
