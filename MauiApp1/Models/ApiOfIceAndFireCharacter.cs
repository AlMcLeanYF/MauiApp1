using MauiApp1.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ApiOfIceAndFireCharacter
    {
        public ApiOfIceAndFireCharacter()
        {
        }

        public ApiOfIceAndFireCharacter(ApiOfIceAndFireCharacterResponse character)
        {
            Name = character.name;
            Gender = character.gender;
            Culture = character.culture;
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Culture { get; set; }


        //public string Born { get; set; }
        //public string Died { get; set; }
        //public List<string> Titles { get; set; } = new List<string>();
        //public List<string> Aliases { get; set; } = new List<string>();


        //public string father { get; set; }
        //public string mother { get; set; }
        //public string spouse { get; set; }
        //public string[] allegiances { get; set; }
        //public string[] books { get; set; }
        //public string[] povBooks { get; set; }
        //public string[] tvSeries { get; set; }
        //public string[] playedBy { get; set; }
    }
}
