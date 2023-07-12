using ispat.DTO.Authentication;
using System;
using System.Collections.Generic;
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
      

        public Task<DailyShowDto> DailyPurchase(DateTime dto);
        public Task<DailyShowDto> MonthlyPurchase(DateTime dto);
    }
}
