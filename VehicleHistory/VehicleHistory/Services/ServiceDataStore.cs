using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleHistory.Models;

namespace VehicleHistory.Services
{
    public class ServiceDataStore : IDataStore<Service>
    {
        List<Service> services;

        public ServiceDataStore()
        {
            services = new List<Service>()
            {
                new Service { Id = Guid.NewGuid().ToString(), Title = "Oil change", Description = "Test service description", Mileage = 105671 },
                new Service { Id = Guid.NewGuid().ToString(), Title = "Rear brakes", Description = "Test service description", Mileage = 108541 },
                new Service { Id = Guid.NewGuid().ToString(), Title = "Front brakes", Description = "Test service description", Mileage = 107551 },
                new Service { Id = Guid.NewGuid().ToString(), Title = "Tune", Description = "Test service description", Mileage = 109613 },
                new Service { Id = Guid.NewGuid().ToString(), Title = "Oil Change", Description = "Test service description", Mileage = 110548 },


            }.OrderBy(x => x.Mileage).ToList();
        }

        public async Task<bool> AddItemAsync(Service item)
        {
            services.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Service item)
        {
            var oldItem = services.Where((Service arg) => arg.Id == item.Id).FirstOrDefault();
            services.Remove(oldItem);
            services.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = services.Where((Service arg) => arg.Id == id).FirstOrDefault();
            services.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Service> GetItemAsync(string id)
        {
            return await Task.FromResult(services.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Service>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(services);
        }
    }
}