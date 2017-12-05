using System.Collections.Generic;
using System.Data;
using SymptomTracker.Domain;

namespace SymptomTracker.DataAccess
{
    public class MedDataAccessor
    {
        public static List<Med> Get()
        {
            List<Med> list = new List<Med>();

            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [MedId]
                      ,[MedName]
                      ,[Description]
                      ,[Dose]
                      ,[DoseDate]
                      ,[UserId]
                      ,[MedImage]
                    FROM [SymptomTracker].[dbo].[ST_Meds]"))
            {
                while (reader.Read())
                {
                    list.Add(MedMapper.Map(reader));
                }
            }

            return list;
        }

        public static Med Get(long id)
        {
            using (
                IDataReader reader = DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, @"
                    SELECT [MedId]
                      ,[MedName]
                      ,[Description]
                      ,[Dose]
                      ,[DoseDate]
                      ,[UserId]
                      ,[MedImage]
                    FROM [SymptomTracker].[dbo].[ST_Meds] where medid = " + id))
            {
                while (reader.Read())
                {
                    return MedMapper.Map(reader);
                }
            }

            return null;
        }

        public static long Insert(Med med)
        {
            string insertCommand =
                $"INSERT INTO ST_Meds (MedName, Description, Dose, DoseDate, UserId) VALUES('{med.MedName}', '{med.Description}', {med.Dose}, GETDATE(), {med.UserId})";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, insertCommand);
        }

        public static long Update(long id, Med med)
        {
            string updateCommand =
                    $"UPDATE ST_Meds SET MedName = '{med.MedName}', Description = '{med.Description}', Dose = {med.Dose}, DoseDate = GETDATE(), UserId = {med.UserId} WHERE MedId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, updateCommand);
        }

        public static long Delete(long id)
        {
            string deleteCommand = $"DELETE FROM ST_Meds WHERE MedId = {id}";

            return DatabaseAccessor.Instance.ExecuteNonQuery(CommandType.Text, deleteCommand);
        }
    }
}
