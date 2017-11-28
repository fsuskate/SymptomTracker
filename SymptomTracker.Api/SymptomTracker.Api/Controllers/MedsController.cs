using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SymptomTracker.DataAccess;
using SymptomTracker.Domain;

namespace SymptomTracker.Api.Controllers
{
    public class MedsController : ApiController
    {
        // GET api/meds
        public IEnumerable<Med> Get()
        {
            return MedDataAccessor.Get();
        }

        // GET api/values/5
        public Med Get(int id)
        {
            return MedDataAccessor.Get(id);
        }

        // POST api/values
        public void Post([FromBody]Med value)
        {
            MedDataAccessor.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Med value)
        {
            MedDataAccessor.Update(id, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            MedDataAccessor.Delete(id);
        }
    }
}
