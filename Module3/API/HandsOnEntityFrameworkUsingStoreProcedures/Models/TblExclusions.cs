using System;
using System.Collections.Generic;

namespace HandsOnEntityFrameworkUsingStoreProcedures.Models
{
    public partial class TblExclusions
    {
        public int IntExclusionsId { get; set; }
        public string StrDrugNdc { get; set; }
        public string StrContractCode { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DtmCreated { get; set; }
        public DateTime DtmUpdated { get; set; }
    }
}
