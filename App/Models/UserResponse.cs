using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class UserResponse
    {
        public int Id {get; set;} //Adding the ID property

        [Required]
        public string Name {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [Phone]
        public string PhoneNumber {get; set;}

        [Required]
        public string UserType {get; set;}

        [Required]
        public string EquipmentType {get; set;}

        [Required]
        public string RequestDetails {get; set;}

        [Required]
        public int Duration {get; set;}

        public UserResponse()
        {
            Id = GenerateUniqueId(); // Updating the constructor to set the Id property 
        }
        
        public int _currentId = 1;

        public int GenerateUniqueId()
        {
            return _currentId++;
        }
    }
}