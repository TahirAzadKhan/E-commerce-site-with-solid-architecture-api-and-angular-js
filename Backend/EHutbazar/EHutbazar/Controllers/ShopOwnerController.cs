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

    public class ShopOwnerController : ApiController
    {
        // GET api/<controller>
        [Route("api/ShopOwner/GetAll")]
        [HttpGet]
        public List<ShopOwnerModel> GetAll()
        {
            return ShopOwnerService.GetAll();
        }


        // GET api/<controller>/5
        [Route("api/ShopOwner/Get/{id}")]
        [HttpGet]
        public ShopOwnerModel Get(int id)
        {
            return ShopOwnerService.Get(id);
        }



        // POST api/<controller>
        [Route("api/ShopOwner/Insert")]
        [HttpPost]
        public void Insert([FromBody] ShopOwnerModel shopOwner)
        {
            ShopOwnerService.Insert(shopOwner);
        }


        // PUT api/<controller>/5
        [Route("api/ShopOwner/Update")]
        [HttpPut]
        public void Update([FromBody] ShopOwnerModel shopOwner)
        {
            ShopOwnerService.Upadte(shopOwner);
        }

        // DELETE api/<controller>/5
        [Route("api/ShopOwner/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            ShopOwnerService.Delete(id);
        }
    }
}