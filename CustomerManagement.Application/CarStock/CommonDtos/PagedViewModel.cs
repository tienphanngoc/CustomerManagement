using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Application.CarStock.CommonDtos
{
    public class PagedViewModel<T>
    {
        public int TotalRecord { get; set; }
        public List<T> Items { get; set; }
    }
}
