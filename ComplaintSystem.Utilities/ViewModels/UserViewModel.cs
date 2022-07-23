using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Utilities.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
