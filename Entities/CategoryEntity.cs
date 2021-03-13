using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Entities
{
    public class CategoryEntity
    {
        [Key]//entity framework (data annotation) llave principal
        [StringLength(50)] // data annotation 
        public string CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        //relacion con productos
        public ICollection<ProductEntity> ProductEntities { get; set; }
    }
}
