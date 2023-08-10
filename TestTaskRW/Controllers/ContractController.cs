﻿using TestTaskRW.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskRW.Controllers
{
    [Authorize]
    public class ContractController : Controller
    {
        GanerateContracts getlistexcel = new Models.DataModels.GanerateContracts();
        [HttpGet]
        public IActionResult Index()
        {
            getlistexcel = new Models.DataModels.GanerateContracts();
            return View(model: getlistexcel.GetExcelItems());
        }

        [HttpGet]
        public PhysicalFileResult GetSomeFile(int RowNumber)
        {
            RowNumber += 2;
            Contract contract = getlistexcel.ReadExcelRow(RowNumber);
                return PhysicalFile(getlistexcel.GenDocxContract(contract), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", contract.CompanyName+".docx");
            

        }
    }
}
