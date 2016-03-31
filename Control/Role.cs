using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.DeskApp
{
    public class Role
    {
        public List<string> Roles { get; set; }

        public Role()
        {
            Roles = new List<string>();
            this.Roles.Add("Administrator");
            this.Roles.Add("Operator");
            this.Roles.Add("Register");
            this.Roles.Add("Payment");
        }
    }


}
