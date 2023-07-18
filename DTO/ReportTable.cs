using System;

namespace TaskList.DTO
{
    public class ReportTable
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
      
        /// <summary>s
        /// 
        /// </summary>
    
        public int? PurchaseTotal { get; set; }
        public string  MonthName { get; set; }
        
        public string Year { get; set; }
        
       
        public string plStatus { get; set; }
        
        public int? SellTotal { get; set; }
    }
}
