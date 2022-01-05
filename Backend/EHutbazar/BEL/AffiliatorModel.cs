using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AffiliatorModel
    {
        public int Affiliate_Id { get; set; }
        public string Affiliate_Name { get; set; }
        public string Affiliate_Username { get; set; }
        public string Affiliate_Password { get; set; }
        public string Affiliate_Email { get; set; }
        public string Affiliate_Phone { get; set; }
        public int Affiliate_UserType { get; set; }
        public string Affiliate_Code { get; set; }
        public string Authorization { get; set; }
    }
}
