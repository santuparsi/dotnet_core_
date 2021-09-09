using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDBFirst.Entities
{
    public partial class BookTransaction
    {
        public decimal? BookCode { get; set; }
        public decimal? StudCode { get; set; }
        public decimal? StaffCode { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }

        public virtual BookMaster BookCodeNavigation { get; set; }
        public virtual StaffMaster StaffCodeNavigation { get; set; }
        public virtual StudentMaster StudCodeNavigation { get; set; }
    }
}
