using System.Collections.Generic;
using System.Web.Http;
using SymptomTracker.DataAccess;
using SymptomTracker.Domain;

namespace SymptomTracker.Api.Controllers
{
    public class SymptomsController : ApiController
    {
        // GET api/meds
        public IEnumerable<Symptom> Get()
        {
            return SymptomDataAccessor.Get();
        }

        // GET api/values/5
        public Symptom Get(int id)
        {
            return SymptomDataAccessor.Get(id);
        }

        // POST api/values
        public void Post([FromBody]Symptom value)
        {
            SymptomDataAccessor.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Symptom value)
        {
            SymptomDataAccessor.Update(id, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            SymptomDataAccessor.Delete(id);
        }
    }
}
