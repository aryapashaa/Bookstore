namespace Client.Models;
public class Payment
{
    public int Id { get; set; }
    public int? Amount { get; set; }
    public DateTime? PaymentDate { get; set; } = DateTime.Now;
    public int ProfileId { get; set; }
    public int ShoppingCartId { get; set; }
}
