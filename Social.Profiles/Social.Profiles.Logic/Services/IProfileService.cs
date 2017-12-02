using System;
using System.Threading.Tasks;
using Social.Profiles.Data.Models;

namespace Social.Profiles.Logic.Services
{
    public interface IProfileService
    {
        Task<Profile> Get(Guid id);
        Task<bool> Remove(Guid id);
        Task<Profile> Update(Profile profile);
    }
}