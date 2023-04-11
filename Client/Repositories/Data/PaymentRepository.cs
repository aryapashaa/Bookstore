using Client.Models;

namespace Client.Repositories.Data;

public class PaymentRepository : GeneralRepository<Payment, int>
{
    public PaymentRepository(string request = "Payments/") : base(request)
    {
    }
}
