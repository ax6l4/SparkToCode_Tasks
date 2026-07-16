namespace Hotel_Management_System
{
    class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }


        public Room(int number, string type, double price)
        {
            RoomNumber = number;
            RoomType = type;
            PricePerNight = price;
            IsAvailable = true;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            { 

                while (true)
                {
                    Console.WriteLine("====== HOTEL MANAGEMENT SYSTEM ======");
                    Console.WriteLine("1. Add New Room");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter your choice: ");

                    int choice = int.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("=== Add New Room ===");

                            Console.Write("Enter Room Number: ");
                            int roomNumber = int.Parse(Console.ReadLine());


                            bool roomExists = rooms.Any(r => r.RoomNumber == roomNumber);


                            if (roomExists)
                            {
                                Console.WriteLine("Room already exists!");
                                break;
                            }


                            Console.Write("Enter Room Type: ");
                            string roomType = Console.ReadLine();


                            Console.Write("Enter Price Per Night: ");
                            double price = double.Parse(Console.ReadLine());


                            Room newRoom = new Room(roomNumber, roomType, price);


                            rooms.Add(newRoom);


                            Console.WriteLine("Room Added Successfully!");
                            Console.WriteLine("Total Rooms: " + rooms.Count);

                            break;


                        case 0:
                            return;


                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
            }




        }
    }
}
