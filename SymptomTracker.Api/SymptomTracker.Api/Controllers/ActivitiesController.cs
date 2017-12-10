using System.Collections.Generic;
using System.Web.Http;
using SymptomTracker.DataAccess;
using SymptomTracker.Domain;

namespace SymptomTracker.Api.Controllers
{
    public class ActivitiesController : ApiController
    {
        // GET api/meds
        public IEnumerable<Activity> Get()
        {
            return ActivityDataAccessor.Get();
        }

        // GET api/values/5
        public Activity Get(int id)
        {
            return ActivityDataAccessor.Get(id);
        }

        // POST api/values
        public void Post([FromBody]Activity value)
        {
            ActivityDataAccessor.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Activity value)
        {
            ActivityDataAccessor.Update(id, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            ActivityDataAccessor.Delete(id);
        }
    }
}
