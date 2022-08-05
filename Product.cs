using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEfCodeFirts
{
    [Table ("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [MaxLength(50)]
        public string? name { get; set; }
    }
}
