using System.Collections.Generic;
using System.Data;
using SymptomTracker.Domain;

namespace SymptomTracker.DataAccess
{
    public class SymptomDataAccessor
    {
        public static List<Symptom> Get()
        {
            List<Symptom> list = new List<Symptom>();

            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [SymptomId]
                      ,[SymptomName]
                      ,[Description]
                      ,[SymptomLevel]
                      ,[SymptomLength]
                      ,[SymptomDate]
                      ,[UserId]
                    FROM [SymptomTracker].[dbo].[ST_Symptoms]"))
            {
                while (reader.Read())
                {
                    list.Add(SymptomMapper.Map(reader));
                }
            }

            return list;
        }

        public static Symptom Get(long id)
        {
            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [SymptomId]
                      ,[SymptomName]
                      ,[Description]
                      ,[SymptomLevel]
                      ,[SymptomLength]
                      ,[SymptomDate]
                      ,[UserId]
                    FROM [SymptomTracker].[dbo].[ST_Symptoms] where SymptomId = " + id))
            {
                while (reader.Read())
                {
                    return SymptomMapper.Map(reader);
                }
            }

            return null;
        }

        public static long Insert(Symptom symptom)
        {
            string insertCommand =
                $@"INSERT INTO ST_Symptoms 
                    (SymptomName, Description, SymptomLevel, SymptomLength, SymptomDate, UserId) 
                    VALUES('{symptom.SymptomName}', '{symptom.Description}', {symptom.SymptomLevel}, {symptom.SymptomLength}, GETDATE(), {symptom.UserId})";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, insertCommand);
        }

        public static long Update(long id, Symptom symptom)
        {
            string updateCommand =
                    $@"UPDATE ST_Symptoms 
                        SET SymptomName = '{symptom.SymptomName}', Description = '{symptom.Description}', SymptomLevel = {symptom.SymptomLevel}, SymptomLength = {symptom.SymptomLength}, SymptomDate = GETDATE(), UserId = {symptom.UserId} 
                       WHERE SymptomId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, updateCommand);
        }

        public static long Delete(long id)
        {
            string deleteCommand = $"DELETE FROM ST_Symptom WHERE SymptomId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, deleteCommand);
        }
    }
}
