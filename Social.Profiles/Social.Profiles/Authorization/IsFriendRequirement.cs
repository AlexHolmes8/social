using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.Profiles.API.Authorization
{
    public class IsFriendRequirement : IAuthorizationRequirement
    {
        public string FriendIdParamName { get; set; }

        public IsFriendRequirement(string friendIdParamName = "id")
        {
            FriendIdParamName = friendIdParamName;
        }
    }
}
