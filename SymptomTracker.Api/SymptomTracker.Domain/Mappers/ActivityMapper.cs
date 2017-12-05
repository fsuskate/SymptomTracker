﻿using System.Data;

namespace SymptomTracker.Domain
{
    public class ActivityMapper
    {
        public static Activity Map(IDataReader reader)
        {
            return new Activity
            {
                ActivityId = reader.GetInt64(0),
                ActivityName = reader.GetString(1),
                Description = reader.GetString(2),
                ActivityLength = reader.GetInt64(3),
                ActivityDate = reader.GetDateTime(4),
                UserId = reader.GetInt32(5),
            };
        }
    }
}
