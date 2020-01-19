namespace SOLID.DIP.Solution
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
