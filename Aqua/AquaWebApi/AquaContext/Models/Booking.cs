using System;
using System.Collections.Generic;

namespace AquaContext
{
    public partial class Booking
    {
        public Booking()
        {
            this.BookingDetails = new List<BookingDetail>();
        }

        public long PKID { get; set; }
        public Nullable<long> DealerFKID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsDeliveryRequired { get; set; }
        public Nullable<System.DateTime> DeliveryDateTime { get; set; }
        public Nullable<bool> IsDelivered { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<bool> IsFreightRequired { get; set; }
        public Nullable<decimal> FreightAmount { get; set; }
        public Nullable<bool> IsFreightBorneByUs { get; set; }
        public Nullable<bool> IsFreightPaidByUs { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string BillNo { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual DealerMaster DealerMaster { get; set; }
    }
}
