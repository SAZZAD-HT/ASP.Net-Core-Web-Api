namespace TaskList.DTO
{
    public class ItemDto
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? StockQuantity { get; set; }
        public string IsActive { get; set; }
    }
}
