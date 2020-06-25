using CustomerManagement.Application.CarStock.Brands.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Application.CarStock.Brands
{
    public interface IPublicBrandService
    {
        public List<BrandViewModel> GetAll();
    }
}
