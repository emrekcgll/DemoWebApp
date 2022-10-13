using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AdminRole { get; set; }
    }
}
