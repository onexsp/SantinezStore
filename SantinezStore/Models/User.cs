using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SantinezStore.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Password { get; set; }
            
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public bool ConfirmedEmail { get; set; }

      }
}