using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskList.DbContexts.Models
{
    public partial class TblSalesDetails
    {
        public int DetailsId { get; set; }
        public int? SalesId { get; set; }
        public int? ItemId { get; set; }
        public int? ItemQuantity { get; set; }
        public int? UnitPrice { get; set; }
        public string IsActive { get; set; }
    }
}
