using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EHutbazar.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        // GET api/<controller>
        [Route("api/Customer/GetAll")]
        [HttpGet]
        public List<CustomerModel> GetAll()
        {
            return CustomerService.GetAll();
        }


        // GET api/<controller>/5
        [Route("api/Customer/Get/{id}")]
        [HttpGet]
        public CustomerModel Get(int id)
        {
            return CustomerService.Get(id);
        }



        // POST api/<controller>
        [Route("api/Customer/Insert")]
        [HttpPost]
        public void Insert([FromBody] CustomerModel customer)
        {
            CustomerService.Insert(customer);
        }


        // PUT api/<controller>/5
        [Route("api/Customer/Update")]
        [HttpPut]
        public void Update([FromBody] CustomerModel customer)
        {
            CustomerService.Upadte(customer);
        }

        // DELETE api/<controller>/5
        [Route("api/Customer/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            CustomerService.Delete(id);
        }
    }
}