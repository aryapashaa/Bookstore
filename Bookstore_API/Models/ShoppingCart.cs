using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Bookstore_API.Models;
[Table("tb_tr_shoppingcarts")]
public class ShoppingCart
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("quantity")]
    public int Quantity { get; set; }
    [Required, Column("profile_id")]
    public int ProfileId { get; set; }
    [Required, Column("book_id")]
    public int BookId { get; set; }

    // Cardinality
    [JsonIgnore]
    public Payment? Payment { get; set; }
    [JsonIgnore]
    //[ForeignKey(nameof(ProfileId))]
    public ICollection<Profile>? Profiles { get; set; }
    [JsonIgnore]
    //[ForeignKey(nameof(BookId))]
    public ICollection<Book>? Books { get; set; }
}
