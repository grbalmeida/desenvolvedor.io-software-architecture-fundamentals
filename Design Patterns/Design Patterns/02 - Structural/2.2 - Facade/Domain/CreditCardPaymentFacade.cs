using DesignPatterns.Facade.CrossCutting;

namespace DesignPatterns.Facade.Domain
{
    public class CreditCardPaymentFacade : ICreditCardPaymentFacade
    {
        private readonly IPayPalGateway _payPalGateway;
        private readonly IConfigurationManager _configurationManager;

        public CreditCardPaymentFacade(IPayPalGateway payPalGateway, IConfigurationManager configurationManager)
        {
            _payPalGateway = payPalGateway;
            _configurationManager = configurationManager;
        }

        public bool MakePayment(Order order, Payment payment)
        {
            var apiKey = _configurationManager.GetValue("apiKey");
            var encryptionKey = _configurationManager.GetValue("encryptionKey");

            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encryptionKey);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, payment.CreditCard);

            var paymentResult = _payPalGateway.CommitTransaction(cardHashKey, order.Id.ToString(), payment.Total);

            return paymentResult;
        }
    }
}