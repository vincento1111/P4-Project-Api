﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P4ProjectApi.Domain
{
    public class UserInventory
    {
        public int InventoryId { get; set; }
        public User User { get; set; }
        public Item Item { get; set; }
        public int Money { get; set; }

    }
}
