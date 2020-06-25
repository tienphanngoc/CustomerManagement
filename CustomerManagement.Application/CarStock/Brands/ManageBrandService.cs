using CustomerManagement.Application.CarStock.Brands.Dtos;
using CustomerManagement.Data.EF;
using CustomerManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Application.CarStock.Brands
{
    class ManageBrandService : IManageBrandService
    {
        private readonly CRMDbContext _context;
        public ManageBrandService(CRMDbContext dbContext)
        {
            _context = dbContext;   
        }
        public async Task<int> Create(BrandCreateRequest request)
        {
            Brand br = new Brand()
            {
                Name = request.Name,
                Logo = request.Logo
            };
            _context.Brands.Add(br);
            await _context.SaveChangesAsync();
            return br.Id;
        }

        public async Task<int> Delete(int brandId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BrandViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(BrandEditRequest request)
        {
            if (request.Id < 0)
                return request.Id;
            Brand br = _context.Brands.Find(request.Id);
            if (br == null) return 0;
            if (request.Name != null)
                br.Name = request.Name;
            if (request.Logo != null)
                br.Logo = request.Logo;
            await _context.SaveChangesAsync();
            return br.Id;
        }
    }
}
