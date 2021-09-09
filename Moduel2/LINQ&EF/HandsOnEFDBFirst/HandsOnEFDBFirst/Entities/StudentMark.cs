using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDBFirst.Entities
{
    public partial class StudentMark
    {
        public decimal? StudCode { get; set; }
        public int StudYear { get; set; }
        public decimal? Subject1 { get; set; }
        public decimal? Subject2 { get; set; }
        public decimal? Subject3 { get; set; }

        public virtual StudentMaster StudCodeNavigation { get; set; }
    }
}
