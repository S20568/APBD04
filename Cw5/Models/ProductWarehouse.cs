using System;
using System.ComponentModel.DataAnnotations;

namespace Cw5.Models
{
    public class ProductWarehouse
    {
        //IdProduct
        [Required]
        public int IdProduct { get; set; }

        //IdWarehouse
        [Required]
        public int IdWarehouse { get; set; }

        //Amount
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than 0!")]
        public int Amount { get; set; }

        //CreatedAt
        [Required]
        public DateTime CreatedAt { get; set; }

    }
}
