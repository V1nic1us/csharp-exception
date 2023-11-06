using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_exception.Entities.Exceptions;

namespace csharp_exception.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime date = DateTime.Now;
            if (checkIn> date || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"ROOM {RoomNumber}, check-in: {CheckOut.ToString("dd/MM/yyyy")}, checkout: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}
