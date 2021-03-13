using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bussines.Bussines_Category;
using Entities;

namespace myMicroservice.Controllers.ProductController
{
    [ApiController]
    [Route("[controller]")]
    public class ReadCategoryController : ControllerBase
    {
        
        private readonly ILogger<ReadCategoryController> _logger;
        private ReadCategories readCategories = new ReadCategories();
        public ReadCategoryController(ILogger<ReadCategoryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<CategoryEntity> Get()
        {  
            return readCategories.ItemList();
        }
    }
}
