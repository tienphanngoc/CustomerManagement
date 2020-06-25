using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Application.CarStock.Brands.Dtos
{
    public class BrandEditRequest
    {
        public int Id { get; set; } = -1;
        public string Name { get; set; } = null;
        public string Logo { get; set; } = null;
    }
}
