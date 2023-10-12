using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public static class Repository
    {
        private static List<UserResponse> _responses = new List<UserResponse>();

        public static IEnumerable<UserResponse> GetAll() => _responses;
        
        static Repository()
        {
            _responses = new List<UserResponse>();
        }

        public static void AddResponse(UserResponse response)
        {
            response.Id = response.GenerateUniqueId();
            _responses.Add(response);
        }

        private static List<Equipment> _equipments;

         public static void PopulateEquipments()
        {

            _equipments.AddRange(          // Can pass multiple products all at once
                new List<Equipment>
                {
                    new Equipment
                    {
                        Description = "iPhone 14 pro", 
                        Type = Type.Phone,
                        IsAvailable = true,
                        EquipmentId = 1 
                    },

                    new Equipment
                    {
                        Description = "iPhone 14 pro Max", 
                        Type = Type.Phone,
                        IsAvailable = true,
                        EquipmentId = 2  
                    },

                    new Equipment
                    {
                        Description = "Iphone 15",
                        Type = Type.Phone,
                        IsAvailable = false,
                        EquipmentId = 3
                    },



                    new Equipment
                    {
                        Description = "ASUS ROG Strix",
                        Type = Type.Laptop,
                        IsAvailable = true,
                        EquipmentId = 4
                    },

                    new Equipment
                    {
                        Description = "ASUS Zephyrus M15",
                        Type = Type.Laptop,
                        IsAvailable = false,
                        EquipmentId = 5
                    },

                    new Equipment
                    {
                        Description = "ASUS Zephyrus M14",
                        Type = Type.Laptop,
                        IsAvailable = false,
                        EquipmentId = 6
                    },
                    


                    new Equipment
                    {
                        Description = "Ipad pro M1",
                        Type = Type.Tablet,
                        IsAvailable = true,
                        EquipmentId = 7
                    },

                    new Equipment
                    {
                        Description = "Ipad pro M2",
                        Type = Type.Tablet,
                        IsAvailable = true,
                        EquipmentId = 8
                    },

                    new Equipment
                    {
                        Description = "Samsung Galaxy Tab S",
                        Type = Type.Tablet,
                        IsAvailable = true,
                        EquipmentId = 9
                    }
                } 
            );

            
        }

        public static List<Equipment> GetEquipments()
        {
            return _equipments;
        }
    }
}