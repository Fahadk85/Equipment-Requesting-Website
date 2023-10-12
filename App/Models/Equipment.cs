using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public enum Type
    {
        Laptop,
        Phone,
        Tablet,
        Camera
    }
    public class Equipment
    {
        public int EquipmentId {get; set;}
        public Type Type {get; set;}

        public string Description{get; set;} = "NA";

        public bool IsAvailable {get; set;}

        public Equipment()
        {

        }
        public Equipment (bool IsAvailable)
        {
            this.IsAvailable = IsAvailable;
        }
    }
}