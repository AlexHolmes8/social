using Social.Profiles.Data;
using Social.Profiles.Data.Models;
using System;
using System.Threading.Tasks;

namespace Social.Profiles.Logic.Services
{
    public class ProfileService : IProfileService
    {
        private readonly ProfileContext db;

        public ProfileService(ProfileContext db)
        {
            this.db = db;
        }

        public async Task<Profile> Get(Guid id)
        {
            return await db.Profiles.FindAsync(id);
        }

        public async Task<Profile> Update(Profile profile)
        {
            db.Profiles.Update(profile);
            await db.SaveChangesAsync();

            return profile;
        }

        public async Task<bool> Remove(Guid id)
        {
            var profile = await Get(id);
            if(profile == null)
            {
                return false;
            }
            db.Profiles.Remove(profile);
            return true;
        }
    }
}
