namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Description { get; set; }
        public Decimal Price { get; set; } //Decimal para moneda
        public bool IsAvailable { get; set; }
        public DateTime PublishOn { get; set; }


    }
}
