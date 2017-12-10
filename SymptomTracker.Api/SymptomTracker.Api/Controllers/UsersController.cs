using System.Collections.Generic;
using System.Web.Http;
using SymptomTracker.DataAccess;
using SymptomTracker.Domain;

namespace SymptomTracker.Api.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/meds
        public IEnumerable<User> Get()
        {
            return UserDataAccessor.Get();
        }

        // GET api/values/5
        public User Get(int id)
        {
            return UserDataAccessor.Get(id);
        }

        // POST api/values
        public void Post([FromBody]User value)
        {
            UserDataAccessor.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]User value)
        {
            UserDataAccessor.Update(id, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            UserDataAccessor.Delete(id);
        }
    }
}
