using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class UserResponse
    {
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
        
    }
}