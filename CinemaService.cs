using Cinema_application.Entities;
using Cinema_application.Repositories;
using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Services
{
    internal class CinemaService
    {
        readonly ICinemaRepository _repository;
        public CinemaService()
        {
            _repository = new CinemaRepository();
        }

        public bool CreateHall(int row, int column, Categories category)
        {
            _repository.CreateHall(row, column, category);
            return true;
        }
        public bool EditHall(string currentHallNo,string newNo)
        {
            Hall existed = FindHall(currentHallNo);
            
            if(existed == null)
            {
                return false;
            }

            foreach (Hall hall in _repository.Halls)
            {
                if (hall.No.ToLower() == newNo)
                {
                    return false;
                }
            }
            _repository.EditHallNo(existed,newNo);
            return true;
        }

        Hall FindHall(string currentHallNo)
        {
            foreach (Hall hall in _repository.Halls)
            {
                if (hall.No.ToLower() == currentHallNo)
                {
                    return hall;
                }
            }
            return null;
        }
    }
}
