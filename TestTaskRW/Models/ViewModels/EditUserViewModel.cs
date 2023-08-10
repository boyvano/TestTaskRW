using System.ComponentModel.DataAnnotations;
using System;

namespace TestTaskRW.Models.ViewModels
{
    public class EditUserViewModel: CreateUserViewModel
    {        
        public string Id { get; set; }
    }
}
