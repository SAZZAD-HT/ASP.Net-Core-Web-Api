﻿using TaskList.DbContexts;
using TaskList.DTO;
using TaskList.DbContexts.Models;
using TaskList.IRepository;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace TaskList.Services
{
    public class CustomerRepo:ICreate
    {
        private readonly ReadWriteContext _context;

        public CustomerRepo(ReadWriteContext context)
        {
            _context = context;
        }

      
       public Task<string> AddPartnerType(PartnertypeDto dto)
        {
            var entity = new TblPartnerType
            {
            
                PartnerTypeName = dto.PartnerTypeName,
                IsActive = dto.IsActive
            };

            _context.TblPartnerType.Add(entity);
            _context.SaveChanges();
           

            return Task.FromResult("Success");
        }

        public Task<string> AddPartner(PartnerDto dto)
        {
            var entity = new TblPartner
            {
               
                PartnerName = dto.PartnerName,
                PartnerTypeId = dto.PartnerTypeID,
                IsActive = dto.IsActive
            };

            _context.TblPartner.Add(entity);
            _context.SaveChanges();

            return Task.FromResult("Success");
        }
        public Task<string> AddItems(List<ItemDto> dtos)
        {
            foreach (var dto in dtos)
            {

                var existingItem = _context.TblItem.FirstOrDefault(i => i.ItemName == dto.ItemName);
                if (existingItem != null)
                {

                    return Task.FromResult("Error: Item name already exists");
                }


                var entity = new TblItem
                {
                   
                    ItemName = dto.ItemName,
                    StockQuantity = dto.StockQuantity,
                    IsActive = dto.IsActive
                };

                _context.TblItem.Add(entity);
            }

            _context.SaveChanges();

            return Task.FromResult("Success");
        }
        public async Task<string> UpdateItems(List<ItemDto> dtos)
        {
            foreach (var dto in dtos)
            {
                var existingItem = (from fd in _context.TblItem
                                    where fd.ItemId == dto.ItemId
                                    select fd).FirstOrDefault();

                if (existingItem == null)
                {
                    return $"Error: Item with ID {dto.ItemId} not found";
                }

                var duplicateItem = (from fd in _context.TblItem
                                     where fd.ItemName == dto.ItemName
                                     select fd).FirstOrDefault();
                if (duplicateItem != null)
                {
                    return $"Error: Item name '{dto.ItemName}' already exists";
                }

                existingItem.ItemName = dto.ItemName;
                existingItem.StockQuantity = dto.StockQuantity;
                existingItem.IsActive = dto.IsActive;

                _context.TblItem.Update(existingItem);
            }

            await _context.SaveChangesAsync();

            return "Success";
        }
        public Task<string> PurchaseItem(PurchaseDto dto)
        {
            var Purchase = new TblPurchase
            {
                
                SupplierId = dto.SupplierId,
                PurchaseDate = dto.PurchaseDate,
                IsActive = dto.IsActive
            };
            var PurchaseDetails = new TblPurchaseDetails
            {
               
                PurchaseId = dto.pid,
                ItemId = dto.ItemId,
                ItemQuantity = dto.ItemQuantity,
                IsActive = dto.IsActive
            };
            _context.TblPurchase.Add(Purchase);
            _context.SaveChanges();
            _context.TblPurchaseDetails.Add(PurchaseDetails);
            _context.SaveChanges();

            return Task.FromResult("Success");
        }
        public Task<string> SellItem(Salesdto dto)
        {

            var sell = new TblSales
            {
             
                CustomerId = dto.CustomerId,
                SalesDate = dto.SalesDate,
                IsActive = dto.IsActive
            };

            _context.TblSales.Add(sell);

            _context.SaveChanges();
            int generatedSalesId = sell.SalesId;
            


            var selld = new TblSalesDetails
            {

    
                SalesId= generatedSalesId,
                ItemId=dto.ItemId,
                ItemQuantity=dto.ItemQuantity,
                UnitPrice=dto.UnitPrice,
                IsActive=dto.IsActive,
             
             };

            _context.TblSalesDetails.Add(selld);
            _context.SaveChanges();

            return Task.FromResult("Success");



        }
        public async Task<DailyShowDto>  DailyPurchase(DailyDto dto)
        {
         
            var targetDate = dto.PurchaseDate;

            var result = await ( from item in _context.TblItem
                         join purchaseDetails in _context.TblPurchaseDetails
                             on item.ItemId equals purchaseDetails.ItemId
                         join purchase in _context.TblPurchase
                             on purchaseDetails.PurchaseId equals purchase.PurchaseId
                         where purchase.PurchaseDate == targetDate
                         select new DailyShowDto
                         {
                             ItemId = item.ItemId,
                             ItemName = item.ItemName,
                             ItemQuantity = purchaseDetails.ItemQuantity,

                         }).FirstOrDefaultAsync();

            return result;
        }

        
    }
    }
