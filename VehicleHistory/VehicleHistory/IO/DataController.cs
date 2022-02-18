using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VehicleHistory.Models;

namespace VehicleHistory.IO
{
    internal class DataController
    {
        // Constant
        private string fileName = "userdata.vhd";


        // Instance
        public static DataController Instance => i ??= new();
        private static DataController i;



        // Private
        private string filePath;
        private string combinedFilePath;
        
        
        // Public
        public UserData UserData { get; set; }


        public DataController()
        {
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            combinedFilePath = filePath + fileName;
            Console.Write($"====FILE PATH====: {combinedFilePath}");
        }



        public void Start()
        {
            this.Load();
        }


        private void Load()
        {
            if(File.Exists(combinedFilePath))
            {
                try
                {
                    
                    var rawUserData = File.ReadAllText(this.combinedFilePath);
                    this.UserData = JsonConvert.DeserializeObject<UserData>(rawUserData);


                    Console.WriteLine("Successful deserialization");
                } catch (Exception ex)
                {
                    Console.Write("Deserialization failed");
                }
            }
        }
        public void Save()
        {
            try
            {
                var serializable = JsonConvert.SerializeObject(this.UserData, new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.All,
                    Formatting = Formatting.Indented,

                });
                File.WriteAllText(this.combinedFilePath, serializable);
            } catch
            {

            }
        }

        public void Save(UserData userData)
        {
            try
            {
                var serializable = JsonConvert.SerializeObject(userData, new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.All,
                    Formatting = Formatting.Indented,

                });
                File.WriteAllText(this.combinedFilePath, serializable);
                Console.WriteLine("Serialization successful");
            }
            catch
            {
                Console.WriteLine("Serialization failed");
            }
        }



        public void Dispose()
        {

        }

        // Test method
        public void WriteData()
        {
            var userdata = new UserData()
            {
                FuelRecords = new()
                {
                    new() { Id = Guid.NewGuid().ToString(), GallonsPumped = 12.53f, Mileage = 102315 },
                    new() { Id = Guid.NewGuid().ToString(), GallonsPumped = 12.57f, Mileage = 102515 },
                    new() { Id = Guid.NewGuid().ToString(), GallonsPumped = 13.13f, Mileage = 102715 },
                    new() { Id = Guid.NewGuid().ToString(), GallonsPumped = 11.33f, Mileage = 102915 },
                    new() { Id = Guid.NewGuid().ToString(), GallonsPumped = 13.63f, Mileage = 103015 },
                    new() { Id = Guid.NewGuid().ToString(), GallonsPumped = 11.53f, Mileage = 103215 },
                    new() { Id = Guid.NewGuid().ToString(), GallonsPumped = 12.23f, Mileage = 103415 },
                },
            };
            DataController.Instance.Save(userdata);
        }

    }
}
