using System;

namespace Tatianna_Aria_Public_Model
{
      public class Broadcast : IBroadcast
    {
        public Guid BroadcastSeatID { get; set; }

        public bool Delete
        { get; set; }

        public bool IsDeleted
        { get; set; }

        public Guid ItemID
        { get; set; }
        public bool Read
        { get; set; }

        public DateTime Stamp
        { get; set; }
        public bool Update
        { get; set; }

        public Guid UserID
        { get; set; }
    }
}
