namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int perSmallCharge = 25;
            int perLargeCharge = 35;
            const double tax = 0.06;
            const int nVaildDays = 30;

            Console.WriteLine("\t--Welcom To Islam's Carpet Cleaning Service--\n");

            Console.WriteLine("Please, Enter the Number Of Small Rooms: ");
            int nSmallRooms = Convert.ToInt32(Console.ReadLine());
            int smallRoomsCost = nSmallRooms * perSmallCharge;

            Console.WriteLine("Please, Enter the Number Of large Rooms: ");
            int nLargeRooms = Convert.ToInt32(Console.ReadLine()); ;
            int largeRoomsCost = nLargeRooms * perLargeCharge;



            int totalCost = smallRoomsCost + largeRoomsCost;
            double calculateTax = totalCost * tax;

            Console.WriteLine("\n****************************************************\n");
            Console.WriteLine("-----\tEstimate for carpet cleaning service\t------\n");
            Console.WriteLine($"Price Per Small Rooms: {smallRoomsCost:C} ");
            Console.WriteLine($"Price Per Large Rooms: {largeRoomsCost:C} ");
            Console.WriteLine($"Total Cost before Tax: {totalCost:C} ");
            Console.WriteLine($"Tax is : {(calculateTax) :C}");
            Console.WriteLine("\n--------------------------------------------------------\n");
            Console.WriteLine($"Total Estmate With Tax : {(totalCost + calculateTax):C}");
            Console.WriteLine($"This estimate is vaild for {nVaildDays} days");
            Console.WriteLine("\n****************************************************\n");

        }
    }
}
