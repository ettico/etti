﻿using CarsVolunteer.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using שב_4.Controllers.properties;

namespace CarsVolunteer.Data.Repositories
{
    public class VolunteerRepository : IVolunteerRepository
    {
        private readonly DataContext _dataContext;
        public VolunteerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Volunteer> GetListOfVolunteer()
        {
            return _dataContext.volunteers.ToList();
        }

        public Volunteer GetVolunteerById(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVolunteer(int id)
        {
            _dataContext.volunteers.Remove(GetVolunteerById(id));
            _dataContext.SaveChanges();
            return true;
        }

        public bool AddVolunteer(Volunteer volunteer)
        {
            _dataContext.volunteers.Add(volunteer);
            _dataContext.SaveChanges();
            return true;
        }

        public bool UpdateVolunteer(int id, Volunteer volunteer)
        {
            DeleteVolunteer(id);
            AddVolunteer(volunteer);
            _dataContext.SaveChanges();
            return true;
        }
    }
}
