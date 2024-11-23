using PrjEIP.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEIP.models
{
    public class CUservice
    {
        private readonly Dictionary<string, UserRole> userRoles = new Dictionary<string, UserRole>
        {
            {"user",UserRole.Admin },
            {"user5",UserRole.User },
            {"user7",UserRole.Guset }
        };
        public UserRole GetUserRole(string userId)
        {
            if (userRoles.TryGetValue(userId,out UserRole role))
            {
                return role;
            }
            return UserRole.Guset;
        }
    }
}
