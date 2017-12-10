using System.Collections.Generic;
using System.Data;
using SymptomTracker.Domain;

namespace SymptomTracker.DataAccess
{
    public class ActivityDataAccessor
    {
        public static List<Activity> Get()
        {
            List<Activity> list = new List<Activity>();

            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [ActivityId]
                      ,[ActivityName]
                      ,[Description]
                      ,[ActivityDate]
                      ,[ActivityLength]
                      ,[UserId]
                    FROM [SymptomTracker].[dbo].[ST_Activities]"))
            {
                while (reader.Read())
                {
                    list.Add(ActivityMapper.Map(reader));
                }
            }

            return list;
        }

        public static Activity Get(long id)
        {
            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [ActivityId]
                      ,[ActivityName]
                      ,[Description]
                      ,[ActivityDate]
                      ,[ActivityLength]
                      ,[UserId]
                    FROM [SymptomTracker].[dbo].[ST_Activities] where ActivityId = " + id))
            {
                while (reader.Read())
                {
                    return ActivityMapper.Map(reader);
                }
            }

            return null;
        }

        public static long Insert(Activity activity)
        {
            string insertCommand =
                $"INSERT INTO ST_Activities (ActivityName, Description, ActivityDate, ActivityLength, UserId) VALUES('{activity.ActivityName}', '{activity.Description}', GETDATE(), {activity.ActivityLength}, {activity.UserId})";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, insertCommand);
        }

        public static long Update(long id, Activity activity)
        {
            string updateCommand =
                    $"UPDATE ST_Activities SET ActivityName = '{activity.ActivityName}', Description = '{activity.Description}', ActivityDate = GETDATE(), ActivityLength = {activity.ActivityLength} UserId = {activity.UserId} WHERE ActivityId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, updateCommand);
        }

        public static long Delete(long id)
        {
            string deleteCommand = $"DELETE FROM ST_Activities WHERE ActivityId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, deleteCommand);
        }
    }
}
