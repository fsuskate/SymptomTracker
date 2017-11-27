using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymptomTracker.Domain
{
    public class MedMapper
    {
        public static Med Map(IDataReader reader)
        {
            var med = new Med();
            med.MedId = reader.GetInt64(0);
            med.MedName = reader.GetString(1);
            med.Description = reader.GetString(2);
            med.Dose = reader.GetInt64(3);
            med.DoseDate = reader.GetDateTime(4);
            med.UserId = reader.GetInt32(5);
            return med;
        }
    }
}
