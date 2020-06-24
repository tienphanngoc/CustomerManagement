using CustomerManagement.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CustomerManagement.Data.Entities
{
    public class Employee : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public Gender Gender { get; set; }
        public DateTime JoinDate { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime? ExitDate { get; set; }

        //Navigations


        public Employee()
        {

        }
    }
}
