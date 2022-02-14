using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleHistory.Models;

namespace VehicleHistory.Services
{
    public class FuelRecordDataStore : IDataStore<FuelRecord>
    {
        List<FuelRecord> records;
        public FuelRecordDataStore()
        {
            records = new List<FuelRecord>() 
            { 
                new FuelRecord { Id = Guid.NewGuid().ToString(), GallonsPumped = 14.71f, Mileage = 101266},
                new FuelRecord { Id = Guid.NewGuid().ToString(), GallonsPumped = 13.61f, Mileage = 101318},
                new FuelRecord { Id = Guid.NewGuid().ToString(), GallonsPumped = 14.31f, Mileage = 101518},
                new FuelRecord { Id = Guid.NewGuid().ToString(), GallonsPumped = 14.12f, Mileage = 101612},
                new FuelRecord { Id = Guid.NewGuid().ToString(), GallonsPumped = 13.15f, Mileage = 101811},
                new FuelRecord { Id = Guid.NewGuid().ToString(), GallonsPumped = 12.41f, Mileage = 102049},
                new FuelRecord { Id = Guid.NewGuid().ToString(), GallonsPumped = 13.11f, Mileage = 102301},
            }.OrderBy(x => x.Mileage).ToList();

        }

        public async Task<bool> AddItemAsync(FuelRecord item)
        {
            records.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(FuelRecord item)
        {
            var oldItem = records.Where((FuelRecord arg) => arg.Id == item.Id).FirstOrDefault();
            records.Remove(oldItem);
            records.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = records.Where((FuelRecord arg) => arg.Id == id).FirstOrDefault();
            records.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<FuelRecord> GetItemAsync(string id)
        {
            return await Task.FromResult(records.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<FuelRecord>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(records);
        }
    }
}

