using System;
using System.Threading;

namespace DesignPatterns.Observer
{
    public static class ObserverExecution
    {
        public static void Execute()
        {
            var john = new Observer("John");
            var eduardo = new Observer("Eduardo");
            var bill = new Observer("Bill");

            var amazon = new BovespaPaper("Amazon", NextDecimal());
            var microsoft = new BovespaPaper("Microsoft", NextDecimal());

            amazon.Subscribe(john);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);

                amazon.Value = NextDecimal();
                microsoft.Value = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(eduardo);
                }
            }
        }

        public static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
            return r / (decimal)100000.00;
        }
    }
}