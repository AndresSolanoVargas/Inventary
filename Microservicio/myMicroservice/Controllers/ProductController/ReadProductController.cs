using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bussines.Bussines_Product;
using Entities;

namespace myMicroservice.Controllers.ProductController
{
    [ApiController]
    [Route("[controller]")]
    public class ReadProductController : ControllerBase
    {
        
        private readonly ILogger<ReadProductController> _logger;
        private ReadProduct readProduct = new ReadProduct();
        public ReadProductController(ILogger<ReadProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<ProductEntity> Get()
        {  
            return readProduct.ItemList();
        }
    }
}
