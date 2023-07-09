using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicServices.DTO
{
    public class MemberProfileDto
    {
        public MemberProfileDto(string user_name,string? first_name,string? last_name, int user_id)
        {
            this.user_name = user_name;
            this.user_id = user_id;
            this.first_name=first_name;
            this.last_name=last_name;

        }
        public string user_name { get; set; } = string.Empty;
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public int user_id { get; set; }



    }
}