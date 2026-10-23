using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Model
{
    [Table("orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("orderid")]
        public int OrderId { get; set; }

        [Column("customerid")]
        public int CustomerId { get; set; }

        [Column("orderdate")]
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    }
}