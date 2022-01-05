using BEL;
using BLL;
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
    public class AffiliatorController : ApiController
    {
        // GET api/<controller>
        [Route("api/Affiliator/GetAll")]
        [HttpGet]
        public List<AffiliatorModel> GetAll()
        {
            return AffiliatorService.GetAll();
        }


        // GET api/<controller>/5
        [Route("api/Affiliator/Get/{id}")]
        [HttpGet]
        public AffiliatorModel Get(int id)
        {
            return AffiliatorService.Get(id);
        }



        // POST api/<controller>
        [Route("api/Affiliator/Insert")]
        [HttpPost]
        public void Insert([FromBody] AffiliatorModel affiliator)
        {
            AffiliatorService.Insert(affiliator);
        }


        // PUT api/<controller>/5
        [Route("api/Affiliator/Update")]
        [HttpPut]
        public void Update([FromBody] AffiliatorModel affiliator)
        {
            AffiliatorService.Upadte(affiliator);
        }

        // DELETE api/<controller>/5
        [Route("api/Affiliator/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            AffiliatorService.Delete(id);
        }
    }
}