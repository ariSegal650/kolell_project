using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicServices.DTO
{
    public class SpeakerCompoDto
    {
        public SpeakerCompoDto(string full_name, int user_id, int number_views, string img)
        {
            this.full_name = full_name;
            this.user_id = user_id;
            this.number_views = number_views;
            this.img = img;
        }

       public string full_name { get; set; } = string.Empty;
       public int user_id { get; set; }
        public int number_views { get; set; }
        public string img { get; set; }


        

    }
}