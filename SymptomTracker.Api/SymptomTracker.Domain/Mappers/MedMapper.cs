using System.Data;

namespace SymptomTracker.Domain
{
    public class MedMapper
    {
        public static Med Map(IDataReader reader)
        {
            return new Med
            {
                MedId = reader.GetInt64(0),
                MedName = reader.GetString(1),
                Description = reader.GetString(2),
                Dose = reader.GetInt64(3),
                DoseDate = reader.GetDateTime(4),
                UserId = reader.GetInt32(5),
                MedImage = reader.GetString(6)
            };
        }
    }
}
