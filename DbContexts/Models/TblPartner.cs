using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskList.DbContexts.Models
{
    public partial class TblPartner
    {
        public int IntPartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerTypeId { get; set; }
        public string IsActive { get; set; }
    }
}
