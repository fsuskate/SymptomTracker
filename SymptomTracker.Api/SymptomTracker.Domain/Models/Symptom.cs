using System;

namespace SymptomTracker.Domain
{
    public class Symptom
    {
        public long SymptomId { get; set;  }
        public string SymptomName { get; set; }
        public string Description { get; set; }
        public long SymptomLevel { get; set; }
        public long SymptomLength { get; set; }
        public DateTime SymptomDate { get; set; }
        public int UserId { get; set; }
    }
}