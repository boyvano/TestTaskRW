﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskRW.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        //public string Login { get; set; }
        public string Position { get; set; }
        
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
