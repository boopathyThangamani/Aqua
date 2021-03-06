﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVM
{
    public class AccountTypeMasterVM
    {
        public long PKID { get; set; }
        public string Name { get; set; }
        public string Balance { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    }
}
