using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FluentValidator.Model;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpPost("SaveUser")]
        public HttpResponseMessage SaveUser(UserModel user)
        {
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        
    }
}
