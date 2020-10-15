using System;
using System.Collections.Generic;
using System.Text;

namespace P4ProjectApi.Domain
{
    public class UserStat
    {
        public int StatId { get; set; }
        public User User { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Dexterity { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }

    }
}
