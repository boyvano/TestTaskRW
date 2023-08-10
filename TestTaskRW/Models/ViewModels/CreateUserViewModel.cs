using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace TestTaskRW.Models.ViewModels
{
    public class CreateUserViewModel : RegisterViewModel
    {
        [Display(Name = "Роли")]
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Roles")]
        public System.Collections.Generic.List<string> RolesId { get; set; }
        public System.Collections.Generic.List<Microsoft.AspNetCore.Identity.IdentityRole> Roles { get; set; }
        
    }

}
