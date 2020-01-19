namespace SOLID.DIP.Violation
{
    public class CPF
    {
        public string Number { get; set; }

        public bool Validate()
        {
            return Number.Length == 11;
        }
    }
}
