using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ShopOwnerModel
    {
        public int ShopO_Id { get; set; }
        public string ShopO_Name { get; set; }
        public string ShopO_Username { get; set; }
        public string ShopO_Password { get; set; }
        public string ShopO_Email { get; set; }
        public string ShopO_Phone { get; set; }
        public string ShopO_Shopname { get; set; }
        public string ShopO_Description { get; set; }
        public int User_Type { get; set; }
        public string User_Validation { get; set; }
    }
}
