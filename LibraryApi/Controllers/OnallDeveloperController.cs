using LibraryApi.Models;
using LibraryApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public class OnallDeveloperController : ControllerBase
    {
        ILookupOnCallDevelopers OnCallLookup;

        public OnallDeveloperController(ILookupOnCallDevelopers onCallLookup)
        {
            OnCallLookup = onCallLookup;
        }

        [HttpGet("/oncalldeveloper")]
        public async Task<ActionResult> GetOnCallDeveloper()
        {
            OnCallDeveloperResponse response = await OnCallLookup.GetDeveloper();
            return Ok(response);
        }
    }
}
