using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Services.PaymentSchemes
{
    public interface IPaymentScheme
    {
        bool MakePayment(Account account);
    }
}
