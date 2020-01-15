namespace OOP
{
    // Class definition
    public class Home
    {
        public int SizeSquareMeters { get; set; }
        public int Floors { get; set; }
        public decimal Price { get; set; }
        public int NumberOfParkingSpaces { get; set; }
    }

    public class Object
    {
        public Object()
        {
            // Object definition
            var home = new Home
            {
                SizeSquareMeters = 100,
                Floors = 2,
                Price = 100000,
                NumberOfParkingSpaces = 3
            };
        }
    }
}
