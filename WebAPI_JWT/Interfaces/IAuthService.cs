using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_JWT.Models;

namespace WebAPI_JWT.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole obj);
        
    }
}