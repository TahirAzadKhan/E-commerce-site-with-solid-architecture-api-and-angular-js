using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AdminModel
    {
        public int Admin_Id { get; set; }
        public string Admin_Name { get; set; }
        public string Admin_Username { get; set; }
        public string Admin_Password { get; set; }
        public string Admin_Email { get; set; }
        public string Admin_Phone { get; set; }
        public int User_Type { get; set; }
        public string Admin_Type { get; set; }

    }
}
