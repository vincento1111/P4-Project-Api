using System;
using System.Collections.Generic;
using System.Text;

namespace P4ProjectApi.Domain
{
    class UserProfile
    {
        public int ProfileId { get; set; }
        public User User { get; set; }
        public string ProfileDes { get; set; }
    }
}
    