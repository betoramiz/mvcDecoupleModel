using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;

namespace API.Controllers
{
    public class EmployeeController : ApiController
    {
        Context db = new Context();
        // GET api/employee
        public IEnumerable<Employee> Get()
        {
            var emp = db.employees.ToList();
            return emp;
        }

        // GET api/employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/employee
        public void Post([FromBody]string value)
        {
        }

        // PUT api/employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employee/5
        public void Delete(int id)
        {
        }
    }
}
