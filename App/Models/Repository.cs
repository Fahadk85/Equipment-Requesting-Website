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
    }
}