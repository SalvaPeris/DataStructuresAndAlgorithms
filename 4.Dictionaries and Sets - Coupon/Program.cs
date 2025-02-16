﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is the coupon demo. \n");

        HashSet<int> usedCoupons = new HashSet<int>();
        do
        {
            Console.Write("Enter the coupon number: ");
            string couponString = Console.ReadLine();
            if (int.TryParse(couponString, out int coupon))
            {
                if (usedCoupons.Contains(coupon))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The coupon has been already used");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    usedCoupons.Add(coupon);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                break;
            }
        }
        while (true);

        Console.WriteLine();
        Console.WriteLine("A list of used coupons:");
        foreach (int coupon in usedCoupons)
        {
            Console.WriteLine(coupon);
        }
    }
}
