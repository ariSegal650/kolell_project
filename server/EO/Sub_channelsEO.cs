using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace server.EO
{
    public class Sub_channelsEO
    {
       
        public Boolean has_vids { get; set; }
        public int sub_channel_id { get; set; }
        public int parent_channel_id { get; set; }
        public string? sub_channel_name { get; set; }
        public string? sub_channel_name_seo { get; set; }
        public string? sub_channel_description { get; set; }
        public DateTime? data_created { get; set; }
        public string? sub_channel_picture { get; set; }

    }
}