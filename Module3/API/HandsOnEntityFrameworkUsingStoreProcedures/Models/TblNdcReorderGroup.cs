using System;
using System.Collections.Generic;

namespace HandsOnEntityFrameworkUsingStoreProcedures.Models
{
    public partial class TblNdcReorderGroup
    {
        public int IntNdcReorderGroupId { get; set; }
        public string StrDescription { get; set; }
        public string StrNote { get; set; }
        public string StrCreatedBy { get; set; }
        public int? IntDrugPriceTypeId { get; set; }
        public bool? YnActive { get; set; }
        public DateTime? DtmCreatedDateTime { get; set; }
        public string StrUpdatedBy { get; set; }
        public DateTime? DtmUpdatedDateTime { get; set; }
    }
}
