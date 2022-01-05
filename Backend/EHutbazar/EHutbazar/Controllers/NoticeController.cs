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
    public class NoticeController : ApiController
    {
        // GET api/<controller>
        [Route("api/Notice/GetAll")]
        [HttpGet]
        public List<NoticeModel> GetAll()
        {
            return NoticeService.GetAll();
        }


        // GET api/<controller>/5
        [Route("api/Notice/Get/{id}")]
        [HttpGet]
        public NoticeModel Get(int id)
        {
            return NoticeService.Get(id);
        }



        // POST api/<controller>
        [Route("api/Notice/Insert")]
        [HttpPost]
        public void Insert([FromBody] NoticeModel notice)
        {
            NoticeService.Insert(notice);
        }


        // PUT api/<controller>/5
        [Route("api/Notice/Update")]
        [HttpPut]
        public void Update([FromBody] NoticeModel notice)
        {
            NoticeService.Upadte(notice);
        }

        // DELETE api/<controller>/5
        [Route("api/Notice/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            NoticeService.Delete(id);
        }
    }
}