using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is not empty!")]
        [StringLength(20, ErrorMessage = "Min 4, max 20 characters!", MinimumLength = 4)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Category description is not empty!")]
        [StringLength(50, ErrorMessage = "Min 4 ,max 20 characters!", MinimumLength = 4)]
        public string CategoryDescription { get; set; }
        public List<Food> Foods { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
