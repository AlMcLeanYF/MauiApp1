using MauiApp1.Models;
using MauiApp1.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class TestDataService
    {
        static String HttpClientName = "ApiOfIceAndFireClient";

        public async Task<ApiOfIceAndFireCharacter> GetCharacter(int id)
        {
            await Task.Delay(3000);

            var action = $"characters/{id}";
            var character = new ApiOfIceAndFireCharacter
            {
                 Name = "Name"
            };
            return character;
        }
    }
}
