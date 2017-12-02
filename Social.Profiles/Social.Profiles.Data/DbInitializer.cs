using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Profiles.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProfileContext context)
        {
            context.Database.Migrate();

            //Seed data here

            context.SaveChanges();
        }
    }
}
