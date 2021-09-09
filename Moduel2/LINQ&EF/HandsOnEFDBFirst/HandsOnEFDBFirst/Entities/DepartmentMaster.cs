using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDBFirst.Entities
{
    public partial class DepartmentMaster
    {
        public DepartmentMaster()
        {
            StaffMasters = new HashSet<StaffMaster>();
            StudentMasters = new HashSet<StudentMaster>();
        }

        public decimal DeptCode { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<StaffMaster> StaffMasters { get; set; }
        public virtual ICollection<StudentMaster> StudentMasters { get; set; }
    }
}
