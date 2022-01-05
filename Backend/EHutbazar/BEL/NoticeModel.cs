using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NoticeModel
    {
        public int Notice_Id { get; set; }
        public string Notice_Post { get; set; }
        public System.DateTime Post_Date { get; set; }
        public int Admin_Id { get; set; }

        public virtual AdminModel Admin { get; set; }
    }
}
