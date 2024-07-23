using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_JWT.Models
{
    public class AddUserRole
    {
        public int UserId { get; set; }
        public List<int> RoleIds { get; set; }
    }
}
