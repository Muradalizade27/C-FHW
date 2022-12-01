using Cinema_application.Entities;
using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Repositories
{
    internal class CinemaRepository : ICinemaRepository
    {
        Hall[] _halls;
        public Hall[] Halls { get => _halls ;}

        public CinemaRepository()
        {
            _halls = new Hall[0];
        }

        public string CreateHall(int row, int column, Categories category)
        {
            Hall hall = new Hall(category,row,column);
            Array.Resize(ref _halls, _halls.Length+1);
            _halls[_halls.Length - 1] = hall;
            return hall.No;
        }

        public string EditHallNo(Hall hall, string newNo)
        {
            hall.No = newNo.ToUpper();
            return hall.No;
        }

        public void GetHalls()
        {
            if(_halls.Length !=0)
            {
                foreach (Hall hall in _halls)
                {
                    Console.WriteLine(hall);
                }
            }
            else
            {
                Console.WriteLine("There is no hall");
            }
        }

        public void GetSeats(Hall hall)
        {
            foreach (Seat seat in hall.Seats)
            {
                Console.WriteLine(seat);
            }
        }

        public bool Reserve(Hall hall, int row, int column)
        {
            if (!hall.Seats[row-1, column-1].IsFull)
            {
                hall.Seats[row - 1, column - 1].IsFull = true;
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
