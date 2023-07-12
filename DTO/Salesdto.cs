using System;

namespace TaskList.DTO
{
    public class Salesdto
    {
        public int SalesId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? SalesDate { get; set; }
        public string IsActive { get; set; }
        public int DetailsId { get; set; }
        public int?sid { get; set; }
        public int? ItemId { get; set; }
        public int? ItemQuantity { get; set; }
        public int? UnitPrice { get; set; }
       
    }
}
