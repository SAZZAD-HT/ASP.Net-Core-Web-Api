using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskList.DTO;
using TaskList.IRepository;
using TaskList.Services;

namespace TaskList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductTypeController : ControllerBase
    {
        private readonly ICreate _service;

        public ProductTypeController(ICreate service)
        {
            _service = service;
        }
       
        [HttpPost]
        [Route("Partnertype")]
        public IActionResult AddPartnerType( PartnertypeDto dto)
        {
            _service.AddPartnerType(dto);
            return Ok();
        }

        [HttpPost]

        [Route("AddPartner")]
        public IActionResult AddPartner(PartnerDto dto)
        {
            _service.AddPartner(dto);
            return Ok();
        }
        [HttpPost]
        [Route("AddIteam")]
        public IActionResult AddItems(List<ItemDto> items)
        {
            _service.AddItems(items);
            return Ok();

        }
        [HttpPut]
        [Route("updateIteam")]
        public  IActionResult UpdateItems(List<ItemDto> items)
        {
            var value=_service.UpdateItems(items);
            return Ok(value);


        }
        [HttpPost]
        [Route("PurchaseItem")]
        public IActionResult PurchaseItem(PurchaseDto items)
        {
            _service.PurchaseItem(items);
            return Ok();


        }
        [HttpPost]
        [Route("Sell")]
        public IActionResult SellItem(Salesdto sales)
        {
            _service.SellItem(sales);
            return Ok();
        }



        [HttpGet]
        [Route("GettingPurchaseDetailsDaily")]
        public async  Task<IActionResult> DailyPurchase(DateTime     dto) {
          var sb = await _service.DailyPurchase(dto);
            return Ok(sb);
        }
        [HttpGet]
        [Route("GettingPurchaseDetailsMonthly")]
        public async Task<IActionResult> MonthlyPurchase(DateTime dto)
        {
            var sb =await  _service.MonthlyPurchase(dto);
            return Ok(sb);
        }
        [HttpGet]
        [Route("Repotsvs")]
        public async Task<IActionResult> Report(DateTime dto)
        {
            var sb =await _service.Report(dto);
            return Ok(sb);
        }
        [HttpGet]
        [Route("Reporttable")]
        public async Task<IActionResult> ReportTT(DateTime dto)
        {
            var sb = await _service.Revenue(dto);
            return Ok(sb);
        }


    }
}
