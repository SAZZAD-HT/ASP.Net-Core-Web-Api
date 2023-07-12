using System;

namespace TaskList.DTO
{
    public class SellCustomerDto
    {//Sales
        public int SalesId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? SalesDate { get; set; }
        public string IsActive { get; set; }
        public int DetailsId { get; set; }
      //details
        public int? ItemId { get; set; }
        public int? ItemQuantity { get; set; }
        public int? UnitPrice { get; set; }
       

    }
}
