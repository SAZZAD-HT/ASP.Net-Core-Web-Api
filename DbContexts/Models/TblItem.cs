using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TaskList.DbContexts.Models
{
    public partial class TblItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? StockQuantity { get; set; }
        public string IsActive { get; set; }
    }
}
