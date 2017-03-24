using ConciergeApp.Infrastructure;
using ConciergeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConciergeApp.ViewModels;

namespace ConciergeApp.Services
{
    public class BusinessService
    {
        private BusinessRepository _repo;
        public BusinessService(BusinessRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Business> GetBusinesses()
        {
            return _repo.GetBusinesses().ToList();
        }

        public Business GetBusinessById(int id)
        {
            return _repo.GetBusinessById(id);
        }

    }
}
