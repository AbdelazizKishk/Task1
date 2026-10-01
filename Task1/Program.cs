namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");

            Console.WriteLine("*******************************************");

            Console.WriteLine("Number of small carpets: ");

            int NumOfSmallCarpets = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number of large carpets: ");

            int NumOfLargeCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small carpet: $25");

            Console.WriteLine("Price per large carpet: $35");


            int Cost = (NumOfSmallCarpets * 25) + (NumOfLargeCarpets * 35);

            double Tax = Cost * 0.06;

            Console.WriteLine($"Cost: ${Cost}");

            Console.WriteLine($"Tax: ${Tax}");

            double TotalEstimate = Cost + Tax;

            Console.WriteLine("*******************************************");

            Console.WriteLine($"Total Estimate: ${TotalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
