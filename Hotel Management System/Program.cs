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
        public int RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }


        public Guest(string id, string name, string date, int nights)
        {
            GuestId = id;
            GuestName = name;
            CheckInDate = date;
            TotalNights = nights;

            RoomNumber = 0;
        }


        public double CalculateTotalCost(double price)
        {
            return TotalNights * price;
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
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("0. Exit");


                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {


                    // CASE 01
                    case 1:
                        {

                            Console.WriteLine("=== Add New Room ===");


                            Console.Write("Enter Room Number: ");
                            int newRoomNumber = int.Parse(Console.ReadLine());


                            bool roomExists = rooms.Any(r => r.RoomNumber == newRoomNumber);


                            if (roomExists)
                            {
                                Console.WriteLine("Room already exists!");
                                break;
                            }


                            Console.Write("Enter Room Type: ");
                            string newRoomType = Console.ReadLine();


                            Console.Write("Enter Price Per Night: ");
                            double newPrice = double.Parse(Console.ReadLine());


                            if (newRoomNumber <= 0 || newPrice <= 0)
                            {
                                Console.WriteLine("Invalid Data");
                                break;
                            }


                            Room newRoom = new Room(
                                newRoomNumber,
                                newRoomType,
                                newPrice
                            );


                            rooms.Add(newRoom);


                            Console.WriteLine("Room Added Successfully!");
                            Console.WriteLine("Total Rooms: " + rooms.Count);


                            break;
                        }



                    // CASE 02
                    case 2:
                        {

                            Console.WriteLine("=== Register New Guest ===");


                            Console.Write("Enter Guest Name: ");
                            string newGuestName = Console.ReadLine();


                            Console.Write("Enter Check-In Date: ");
                            string newDate = Console.ReadLine();


                            Console.Write("Enter Number of Nights: ");
                            int newNights = int.Parse(Console.ReadLine());


                            string newGuestId = "G" +
                            (guests.Count + 1).ToString("D3");


                            Guest newGuest = new Guest(
                                newGuestId,
                                newGuestName,
                                newDate,
                                newNights
                            );


                            guests.Add(newGuest);


                            Console.WriteLine("Guest Registered Successfully!");
                            Console.WriteLine("Guest ID: " + newGuest.GuestId);


                            break;
                        }



                    // CASE 03
                    case 3:
                        {

                            Console.WriteLine("=== Book a Room for a Guest ===");


                            Console.Write("Enter Guest ID: ");
                            string bookingGuestId = Console.ReadLine();


                            Guest bookingGuest = guests
                            .FirstOrDefault(g => g.GuestId == bookingGuestId);


                            if (bookingGuest == null)
                            {
                                Console.WriteLine("Guest not found!");
                                break;
                            }


                            Console.Write("Enter Room Number: ");
                            int bookingRoomNumber = int.Parse(Console.ReadLine());


                            Room bookingRoom = rooms
                            .FirstOrDefault(r => r.RoomNumber == bookingRoomNumber);


                            if (bookingRoom == null)
                            {
                                Console.WriteLine("Room not found!");
                                break;
                            }


                            if (!bookingRoom.IsAvailable)
                            {
                                Console.WriteLine("Room is already booked.");
                                break;
                            }


                            bookingGuest.RoomNumber = bookingRoom.RoomNumber;

                            bookingRoom.IsAvailable = false;


                            Console.WriteLine("Booking Successful!");

                            Console.WriteLine("Guest Name: " + bookingGuest.GuestName);
                            Console.WriteLine("Room Number: " + bookingRoom.RoomNumber);
                            Console.WriteLine("Room Type: " + bookingRoom.RoomType);
                            Console.WriteLine("Price: " + bookingRoom.PricePerNight);
                            Console.WriteLine("Total Nights: " + bookingGuest.TotalNights);
                            Console.WriteLine("Total Cost: " +
                            bookingGuest.CalculateTotalCost(bookingRoom.PricePerNight));


                            break;
                        }



                    case 0:
                        return;


                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                    case 10:
                        {
                            Console.WriteLine("=== Room Type Breakdown Report ===");


                            string[] roomTypes = { "Single", "Double", "Suite" };


                            foreach (string type in roomTypes)
                            {

                                int count = rooms
                                    .Where(r => r.RoomType == type)
                                    .Count();


                                Console.WriteLine("\nRoom Type: " + type);
                                Console.WriteLine("Number of Rooms: " + count);



                                if (count > 0)
                                {
                                    double averagePrice = rooms
                                        .Where(r => r.RoomType == type)
                                        .Average(r => r.PricePerNight);


                                    Console.WriteLine("Average Price: "
                                        + averagePrice.ToString("0.00"));
                                }
                                else
                                {
                                    Console.WriteLine("Average Price: N/A");
                                }

                            }



                            double overallAverage = rooms
                                .Average(r => r.PricePerNight);



                            Console.WriteLine("\nOverall Average Price: "
                                + overallAverage.ToString("0.00"));


                            break;
                        }

                }
            }
        }
    }
}








