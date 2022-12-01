using Cinema_application.Entities;
using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Repositories
{
    internal interface ICinemaRepository
    {
        public Hall[] Halls { get; }
        string CreateHall(int row, int column, Categories category);
        string EditHallNo(Hall hall,string newNo);
        void GetHalls();
        void GetSeats(Hall hall);
        bool Reserve(Hall hall,int row, int column);

    }
}
