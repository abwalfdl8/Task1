namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t--Welcom To Islam's Carpet Cleaning Service--\n");

            Console.WriteLine("Please, Enter the Number Of Small Rooms: ");
            int nSmallRooms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, Enter the Number Of large Rooms: ");
            int nLargeRooms = Convert.ToInt32(Console.ReadLine());

            int smallRoomsCost = nSmallRooms * 25;
            int largeRoomsCost = nLargeRooms * 35;
            int totalCost = smallRoomsCost + largeRoomsCost;
            double tax = totalCost * 0.06;
            Console.WriteLine("\n****************************************************\n");
            Console.WriteLine("-----\tEstimate for carpet cleaning service\t------\n");
            Console.WriteLine($"Price Per Small Rooms: ${smallRoomsCost} ");
            Console.WriteLine($"Price Per Large Rooms: ${largeRoomsCost} ");
            Console.WriteLine($"Total Cost before Tax: ${totalCost} ");
            Console.WriteLine($"Tax is : ${totalCost * 0.06}");
            Console.WriteLine("\n--------------------------------------------------------\n");
            Console.WriteLine($"Total Estmate With Tax : ${totalCost + tax}");
            Console.WriteLine("This estimate is vaild for 30 days");
            Console.WriteLine("\n****************************************************\n");
        }
    }
}
