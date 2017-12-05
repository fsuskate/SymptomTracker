using System;

namespace SymptomTracker.Domain
{
    public class User
    {
        public long UserId { get; set;  }
        public string UserName { get; set; }
        public string PassToken { get; set; }
    }
}