using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using SecurityApp.WebApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecurityApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;
        public DataController(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtectionProvider = dataProtectionProvider;
        }
        [HttpGet("purpose-1")]
        public IActionResult GetPurposeString1()
        {
            string title = "Welcome to this course!";

            var dataprotector = _dataProtectionProvider.CreateProtector("DataController.GetPurposeString1");
            var protectedTitle = dataprotector.Protect(title);
            var unProtectedTitle = dataprotector.Unprotect(protectedTitle);

            return Ok(new DataProtection()
            {
                Title = title,
                ProtectedTitle = protectedTitle,
                UnProtectedTitle = unProtectedTitle 
            });
        }
        [HttpGet("purpose-2")]
        public IActionResult GetPurposeString2()
        {
            string title = "Welcome to this course!";

            var dataprotector = _dataProtectionProvider.CreateProtector("DataController.GetPurposeString2");
            var protectedTitle = dataprotector.Protect(title);
            var unProtectedTitle = dataprotector.Unprotect(protectedTitle);

            return Ok(new DataProtection()
            {
                Title = title,
                ProtectedTitle = protectedTitle,
                UnProtectedTitle = unProtectedTitle
            });
        }
    }
}

