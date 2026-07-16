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

    class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }


        public Guest(string id, string name, string date, int nights)
        {
            GuestId = id;
            GuestName = name;
            RoomNumber = "Not Assigned";
            CheckInDate = date;
            TotalNights = nights;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();


            while (true)
            {
                Console.WriteLine("==============================");
                Console.WriteLine(" HOTEL MANAGEMENT SYSTEM");
                Console.WriteLine("==============================");

                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("0. Exit");


                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {

                    // Add new room 
                    case 1:

                        Console.WriteLine("\n=== Add New Room ===");


                        Console.Write("Enter Room Number: ");
                        int roomNumber;


                        while (!int.TryParse(Console.ReadLine(), out roomNumber) || roomNumber <= 0)
                        {
                            Console.Write("Invalid Room Number. Enter again: ");
                        }



                        bool roomExists = rooms.Any(r => r.RoomNumber == roomNumber);



                        if (roomExists)
                        {
                            Console.WriteLine("Room already exists!");
                            break;
                        }



                        Console.Write("Enter Room Type (Single / Double / Suite): ");
                        string roomType = Console.ReadLine();



                        Console.Write("Enter Price Per Night: ");
                        double price;



                        while (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
                        {
                            Console.Write("Invalid Price. Enter again: ");
                        }



                        Room newRoom = new Room(roomNumber, roomType, price);



                        rooms.Add(newRoom);



                        Console.WriteLine("\nRoom Added Successfully!");
                        Console.WriteLine("Room Number: " + newRoom.RoomNumber);
                        Console.WriteLine("Room Type: " + newRoom.RoomType);
                        Console.WriteLine("Price: " + newRoom.PricePerNight);
                        Console.WriteLine("Total Rooms: " + rooms.Count);


                        break;



                    // Add register New Guest
                    case 2:


                        Console.WriteLine("\n=== Register New Guest ===");



                        Console.Write("Enter Guest Name: ");
                        string guestName = Console.ReadLine();



                        Console.Write("Enter Check-In Date: ");
                        string checkInDate = Console.ReadLine();



                        Console.Write("Enter Number of Nights: ");
                        int nights;



                        while (!int.TryParse(Console.ReadLine(), out nights) || nights <= 0)
                        {
                            Console.Write("Invalid Nights. Enter again: ");
                        }



                        string guestId = "G" + (guests.Count + 1).ToString("D3");



                        Guest newGuest = new Guest(
                            guestId,
                            guestName,
                            checkInDate,
                            nights
                        );



                        guests.Add(newGuest);



                        Console.WriteLine("\nGuest Registered Successfully!");
                        Console.WriteLine("Guest ID: " + newGuest.GuestId);
                        Console.WriteLine("Name: " + newGuest.GuestName);
                        Console.WriteLine("Room: " + newGuest.RoomNumber);
                        Console.WriteLine("Nights: " + newGuest.TotalNights);



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
    





