using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Social.Profiles.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Social.Profiles.API.Authorization
{
    public class IsFriendHandler : AuthorizationHandler<IsFriendRequirement>
    {
        private readonly ProfileContext db;

        public IsFriendHandler(ProfileContext db)
        {
            this.db = db;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsFriendRequirement requirement)
        {
            if(!context.User.HasClaim(c => c.Type == ClaimTypes.NameIdentifier))
            {
                return Task.CompletedTask;
            }

            
        }
    }
}
