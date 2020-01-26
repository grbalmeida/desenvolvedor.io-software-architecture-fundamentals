namespace DesignPatterns.Facade.Domain
{
    public class Payment
    {
        public string Status { get; set; }
        public decimal Total { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CreditCard { get; set; }
        public string DigitizableBilletLine { get; set; }
        public string TransferConfirmation { get; set; }
    }
}