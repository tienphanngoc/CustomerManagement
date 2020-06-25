using CustomerManagement.Application.CarStock.Brands.Dtos;
using CustomerManagement.Application.CarStock.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Application.CarStock.Brands
{
    public interface IManageBrandService
    {
        Task<int> Create(BrandCreateRequest request);
        Task<int> Update(BrandEditRequest request);
        Task<int> Delete(int brandId);
        Task<List<BrandViewModel>> GetAll();

    }
}
