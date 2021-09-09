using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDBFirst.Entities
{
    public partial class DesigMaster
    {
        public DesigMaster()
        {
            StaffMasters = new HashSet<StaffMaster>();
        }

        public decimal DesignCode { get; set; }
        public string DesignName { get; set; }

        public virtual ICollection<StaffMaster> StaffMasters { get; set; }
    }
}
