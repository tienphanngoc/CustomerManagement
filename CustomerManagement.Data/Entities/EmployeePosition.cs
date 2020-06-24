using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class EmployeePosition : IdentityRole<int>
    {
        public int? ParentId { get; set; }
        public int Level { get; set; }

        //Navigations
        public virtual EmployeePosition Parent { get; set; }
        public virtual HashSet<EmployeePosition> Childs { get; set; }
        public EmployeePosition()
        {
            Childs = new HashSet<EmployeePosition>();
        }
    }
}
