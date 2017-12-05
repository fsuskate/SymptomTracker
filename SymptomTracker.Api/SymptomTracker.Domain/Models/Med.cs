using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymptomTracker.Domain
{
    public class Med
    {
        public long MedId { get; set;  }
        public string MedName { get; set; }
        public string Description { get; set; }
        public long Dose { get; set; }
        public DateTime DoseDate { get; set; }
        public int UserId { get; set; }
        public string MedImage { get; set; }
    }
}