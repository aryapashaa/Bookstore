using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text.Json.Serialization;

namespace Bookstore_API.Models;
[Table("tb_tr_payments")]
public class Payment
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("amount", TypeName = "numeric(19,0)")]
    public int? Amount { get; set; }
    [Column("payment_date")]
    public DateTime? PaymentDate { get; set; } = DateTime.Now;
    [Required, Column("admin_id")]
    public int AdminId { get; set; }
    [Required, Column("shoppingcart_id")]
    public int ShoppingCartId { get; set; }

    // Cardinality
    [JsonIgnore]
    public Profile? Profile { get; set; }
    [JsonIgnore]
    public ShoppingCart? ShoppingCart { get; set; }
}
