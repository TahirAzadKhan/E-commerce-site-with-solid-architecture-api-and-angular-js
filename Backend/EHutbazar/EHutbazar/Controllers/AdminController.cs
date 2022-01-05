using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EHutbazar.Auth;

namespace EHutbazar.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {
        
        // GET api/<controller>
        [Route("api/Admin/GetAll")]
        [HttpGet]
        public List<AdminModel> GetAll()
        {
            return AdminService.GetAll();
        }


        // GET api/<controller>/5
        [Route("api/Admin/Get/{id}")]
        [HttpGet]
        public AdminModel Get(int id)
        {
            return AdminService.Get(id);
        }
        


        // POST api/<controller>
        [Route("api/Admin/Insert")]
        [HttpPost]
        public void Insert([FromBody] AdminModel admin)
        {
            AdminService.Insert(admin);
        }
        

        // PUT api/<controller>/5
        [Route("api/Admin/Update")]
        [HttpPut]
        public void Update([FromBody] AdminModel admin)
        {
            AdminService.Upadte(admin);
        }

        // DELETE api/<controller>/5
        [Route("api/Admin/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            AdminService.Delete(id);
        }


        
    }
}