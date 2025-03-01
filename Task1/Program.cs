namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t--Welcom To Islam's Carpet Cleaning Service--\n");

            Console.WriteLine("Please, Enter the Number Of Small Rooms: ");
            int nSmallRooms = Convert.ToInt32(Console.ReadLine());
           // bool isConverted= int.TryParse(Console.ReadLine(),out nSmallRooms);

            Console.WriteLine("Please, Enter the Number Of large Rooms: ");
            int nLargeRooms = Convert.ToInt32(Console.ReadLine()); ;
            //bool isConverted2 = int.TryParse(Console.ReadLine(),out nLargeRooms);

            int smallRoomsCost = nSmallRooms * 25;
            int largeRoomsCost = nLargeRooms * 35;
            int totalCost = smallRoomsCost + largeRoomsCost;
            double tax = totalCost * 0.06;
            int nVaildDays = 30;

            Console.WriteLine("\n****************************************************\n");
            Console.WriteLine("-----\tEstimate for carpet cleaning service\t------\n");
            Console.WriteLine($"Price Per Small Rooms: {smallRoomsCost:C} ");
            Console.WriteLine($"Price Per Large Rooms: {largeRoomsCost:C} ");
            Console.WriteLine($"Total Cost before Tax: {totalCost:C} ");
            Console.WriteLine($"Tax is : {(totalCost * 0.06) :C}");
            Console.WriteLine("\n--------------------------------------------------------\n");
            Console.WriteLine($"Total Estmate With Tax : {(totalCost + tax):C}");
            Console.WriteLine($"This estimate is vaild for {nVaildDays} days");
            Console.WriteLine("\n****************************************************\n");

        }
    }
}
