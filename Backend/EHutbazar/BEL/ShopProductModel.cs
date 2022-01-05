using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class ShopProductModel
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public string Product_Stock { get; set; }
        public string Product_Price { get; set; }
        public int ShopO_Id { get; set; }
        public virtual ShopOwnerModel ShopOwner { get; set; }
    }
}
