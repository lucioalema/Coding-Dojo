using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Api.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        [StringLength(14,MinimumLength =14)]
        public string Account { get; set; }
        [Required]

        public DateTime StartDate { get; set; }
        [Required]

        public Category Category { get; set; }
    }
    public enum Category
    {
        CajaAhorro = 4,
        CuentaCorriente = 3
    }

}
