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

    public class ShopProductController : ApiController
    {
        // GET api/<controller>
        [Route("api/Shop_Product/GetAll")]
        [HttpGet]
        public List<ShopProductModel> GetAll()
        {
            return ShopProductServices.GetAll();
        }


        // GET api/<controller>/5
        [Route("api/Shop_Product/Get/{id}")]
        [HttpGet]
        public ShopProductModel Get(int id)
        {
            return ShopProductServices.Get(id);
        }



        // POST api/<controller>
        [Route("api/Shop_Product/Insert")]
        [HttpPost]
        public void Insert([FromBody] ShopProductModel shopProduct)
        {
            ShopProductServices.Insert(shopProduct);
        }


        // PUT api/<controller>/5
        [Route("api/Shop_Product/Update")]
        [HttpPut]
        public void Update([FromBody] ShopProductModel shopProduct)
        {
            ShopProductServices.Upadte(shopProduct);
        }

        // DELETE api/<controller>/5
        [Route("api/Shop_Product/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            ShopOwnerService.Delete(id);
        }
    }
}