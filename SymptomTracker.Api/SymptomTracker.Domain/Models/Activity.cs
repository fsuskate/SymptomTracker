using System;

namespace SymptomTracker.Domain
{
    public class Activity
    {
        public long ActivityId { get; set;  }
        public string ActivityName { get; set; }
        public string Description { get; set; }
        public DateTime ActivityDate { get; set; }
        public long ActivityLength { get; set; }
        public int UserId { get; set; }
    }
}