﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstproject.Models;

namespace MVCFirstproject.Controllers
{
    public class EmployeeController : Controller
    
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        {

            Employee employee = new Employee()
            {
                EmployeeId = 1001,
                EmployeeName = "chandra",
                 EmployeeLocation = "banglore"
            };
            return View(employee);
            
        }
    }
}