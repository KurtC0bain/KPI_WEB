using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class LoginInfo
    {
        [Required]
        [MinLength(6)]
        [StringLength(25)]
        public string Username { get; set; }   

        [Required]        
        [MinLength(6)]
        [StringLength(25)]
        public string Password { get; set; }
    }
}
