using System.Data;

namespace SymptomTracker.Domain
{
    public class SymptomMapper
    {
        public static Symptom Map(IDataReader reader)
        {
            return new Symptom
            {
                SymptomId = reader.GetInt64(0),
                SymptomName = reader.GetString(1),
                Description = reader.GetString(2),
                SymptomLevel = reader.GetInt64(3),
                SymptomLength = reader.GetInt64(4),
                SymptomDate = reader.GetDateTime(5),
                UserId = reader.GetInt32(6)
            };
        }
    }
}
