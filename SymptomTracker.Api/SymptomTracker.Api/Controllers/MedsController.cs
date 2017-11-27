using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SymptomTracker.Domain;

namespace SymptomTracker.Api.Controllers
{
    public class MedsController : ApiController
    {
        // GET api/meds
        public IEnumerable<Med> Get()
        {
            List<Med> list = new List<Med>();

            using (
                IDataReader reader = SymptomTracker.DataAccess.DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, "select * from st_meds"))
            {
                while (reader.Read())
                {
                    list.Add(MedMapper.Map(reader));
                }
            }

            return list;
        }

        // GET api/values/5
        public Med Get(int id)
        {
            using (
                IDataReader reader = SymptomTracker.DataAccess.DatabaseAccessor.Instance.ExecuteReader(
                    CommandType.Text, "select * from st_meds where medid = " + id))
            {
                while (reader.Read())
                {
                    return MedMapper.Map(reader);
                }
            }

            return null;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
