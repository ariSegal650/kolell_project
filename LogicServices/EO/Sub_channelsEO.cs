using System.ComponentModel.DataAnnotations;

namespace LogicServices.EO
{
    public class Sub_channelsEO
    {
       
        public string has_vids { get; set; }=string.Empty;
       
        [Key]
        public int sub_channel_id { get; set; }
        public int parent_channel_id { get; set; }
        public string? sub_channel_name { get; set; }
        public string? sub_channel_name_seo { get; set; }
        public string? sub_channel_description { get; set; }
        public DateTime? date_created { get; set; }
        public string? sub_channel_picture { get; set; }

    }
}