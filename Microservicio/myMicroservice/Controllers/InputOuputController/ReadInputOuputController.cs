using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bussines.Bussines_InputOutput;
using Entities;

namespace myMicroservice.Controllers.ProductController
{
    [ApiController]
    [Route("[controller]")]
    public class ReadInputOuputController : ControllerBase
    {
        
        private readonly ILogger<ReadInputOuputController> _logger;
        private ReadInputOuput readInputOuput = new ReadInputOuput();
        public ReadInputOuputController(ILogger<ReadInputOuputController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<InputOutputEntity> Get()
        {  
            return readInputOuput.ItemList();
        }
    }
}
