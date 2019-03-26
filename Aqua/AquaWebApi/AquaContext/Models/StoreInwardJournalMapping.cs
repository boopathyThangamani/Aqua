using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class StoreInwardJournalMapping
    {
        public long PKID { get; set; }
        public long StoreInwardFKID { get; set; }
        public long JournalFKID { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
        public virtual Journal Journal { get; set; }
    }
}
