using System.Data;

namespace SymptomTracker.Domain
{
    public class UserMapper
    {
        public static User Map(IDataReader reader)
        {
            return new User
            {
                UserId = reader.GetInt64(0),
                UserName = reader.GetString(1),
                PassToken = reader.GetString(2)
            };
        }
    }
}
