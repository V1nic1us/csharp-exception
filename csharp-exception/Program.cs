using csharp_exception.Entities;
using csharp_exception.Entities.Exceptions;

namespace csharp_exception
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room numbers: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (DD/MM/YYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (DD/MM/YYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the resercation:");
                Console.WriteLine("Check-in date (DD/MM/YYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (DD/MM/YYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error:" + e.Message);
            }
        }
    }
}

