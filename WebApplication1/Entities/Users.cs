using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    [Table("san_Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(maximumLength: 256)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength: 256)]
        public string Email { get; set; }
        [Required, StringLength(maximumLength: 256)]
        public string Password { get; set; }
        [StringLength(maximumLength: 256)]
        public string Phone { get; set; }
        [StringLength(maximumLength: 256)]
        public string Address { get; set; }
    }
}