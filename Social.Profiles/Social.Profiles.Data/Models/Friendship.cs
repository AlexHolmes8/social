using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Profiles.Data.Models
{
    public class Friendship
    {
        public Guid RequestingProfileId { get; set; }
        public Guid RespondingProfileId { get; set; }
        public FriendshipStatus Status { get; set; }
        public DateTime RequestedOn { get; set; }
        public DateTime RespondedOn { get; set; }
        public DateTime DefriendedOn { get; set; }

        public Profile RequestingProfile { get; set; }
        public Profile RespondingProfile { get; set; }
    }

    public enum FriendshipStatus
    {
        Requested,
        Accepted,
        Declined,
        Defriended
    }
}
