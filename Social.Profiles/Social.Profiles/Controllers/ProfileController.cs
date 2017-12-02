using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Social.Profiles.Logic.Services;
using Social.Profiles.Data.Models;

namespace Social.Profiles.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        private readonly IProfileService profileService;

        public ProfileController(IProfileService profileService)
        {
            this.profileService = profileService;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var profile = profileService.Get(id);
            if(profile == null)
            {
                return NotFound();
            }
            return Ok(profile);
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]Profile profile)
        {
            await profileService.Update(profile);
            return Ok(profile);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var success = await profileService.Remove(id);
            if(!success)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
