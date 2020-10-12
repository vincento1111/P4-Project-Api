using System;
using System.Collections.Generic;
using System.Text;

namespace P4ProjectApi.Domain
{
    class UserChats
    {
        public int MessegeId { get; set; }
        public User User { get; set; }
        public int Reciever { get; set; }
        public string Messege { get; set; }
    }
}
