using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class TokenModel
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string AccessToken { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public string UserType { get; set; }

        public virtual AdminModel Admin { get; set; }
        public virtual AffiliatorModel Affiliator { get; set; }
        public virtual CustomerModel Customer { get; set; }
        public virtual ShopOwnerModel ShopOwner { get; set; }
    }
}
