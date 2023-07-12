using System;

namespace TaskList.DTO
{
    public class PurchaseDto
    {
        public int DetailsId { get; set; }
        public int? pid { get; set; }
        public int? ItemId { get; set; }
        public int? ItemQuantity { get; set; }
        public int? UnitPrice { get; set; }
        public string IsActive { get; set; }

        //
        public int PurchaseId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? PurchaseDate { get; set; }
       


    }
}
