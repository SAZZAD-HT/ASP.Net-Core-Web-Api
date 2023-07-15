using System;

namespace TaskList.DTO
{
    public class ReportTable
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? unitprice{ get; set; }
        /// <summary>s
        /// 
        /// </summary>
        public string  MonthName { get; set; }
        public int? snitprice { get; set; }
        public DateTime Year { get; set; }
        public int TotalPurchaseAmount { get; set; }
        public int SalesAmount { get; set; }
        public string plStatus { get; set; }

    }
}
