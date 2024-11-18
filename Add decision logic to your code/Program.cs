using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_decision_logic_to_your_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                Console.Write("Renew now and save 20%!");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                Console.Write("Renew now and save 10%!");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            Console.ReadLine();
        }
    }
}
