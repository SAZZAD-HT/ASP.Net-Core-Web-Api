namespace TaskList.DTO
{
    public class ReportDto
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? PurchaseQuantity { get; set; }
        public int? PUnitPrice { get; set; }

        public int? SurchaseQuantity { get; set; }
        public int? SUnitPrice { get; set; }


    }
}
