using System.Collections.Generic;
using System.Data;
using SymptomTracker.Domain;

namespace SymptomTracker.DataAccess
{
    public class UserDataAccessor
    {
        public static List<User> Get()
        {
            List<User> list = new List<User>();

            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [UserId]
                      ,[UserName]
                      ,[PassToken]
                    FROM [SymptomTracker].[dbo].[ST_Users]"))
            {
                while (reader.Read())
                {
                    list.Add(UserMapper.Map(reader));
                }
            }

            return list;
        }

        public static User Get(long id)
        {
            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [UserId]
                      ,[UserName]
                      ,[PassToken]
                    FROM [SymptomTracker].[dbo].[ST_Users] where Userid = " + id))
            {
                while (reader.Read())
                {
                    return UserMapper.Map(reader);
                }
            }

            return null;
        }

        public static long Insert(User user)
        {
            string insertCommand =
                $"INSERT INTO ST_Users (UserName, PassToken) VALUES('{user.UserName}', '{user.PassToken}')";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, insertCommand);
        }

        public static long Update(long id, User user)
        {
            string updateCommand =
                    $"UPDATE ST_Users SET UserName = '{user.UserName}', PassToken = '{user.PassToken}' WHERE UserId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, updateCommand);
        }

        public static long Delete(long id)
        {
            string deleteCommand = $"DELETE FROM ST_Users WHERE UserId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, deleteCommand);
        }
    }
}
