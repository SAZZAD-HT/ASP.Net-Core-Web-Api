using ispat.DTO.Authentication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TaskList.DTO;

namespace TaskList.IRepository
{
    public interface ICreate
    {
        public Task<string> AddPartnerType(PartnertypeDto obj);
        public Task<string> AddPartner(PartnerDto dto);
        public Task<string> AddItems(List<ItemDto> dtos);
        public Task<string> UpdateItems(List<ItemDto> dtos);
        public Task<string> PurchaseItem(PurchaseDto dto);
        public Task<string> SellItem(Salesdto dto);
      

        public Task<List<DailyShowDto>> DailyPurchase(DateTime dto);
        public Task<List<DailyShowDto>> MonthlyPurchase(DateTime dto);
        public Task<List<ReportDto>> Report(DateTime dto);
      public Task<List<ReportTable>> Revenue(DateTime dto);
       public Task<DataTable> SP(DateTime dto);
    }
}
