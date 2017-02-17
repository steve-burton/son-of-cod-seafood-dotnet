using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace SonOfCodSeafood.Models
{
    [Table("PublicUsers")]
    public class PublicUser
    {
        [Key]
        public int PublicUserId { get; set; }
        public string Email { get; set; }
        public string Seafood { get; set; }
    }
}
