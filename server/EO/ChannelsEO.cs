using System.ComponentModel.DataAnnotations;

namespace server.EO
{
    public class ChannelsEO
    {
        [Key]
        public int channel_id { get; set; }
        public string? channel_name { get; set; }
        public string? channel_name_seo { get; set; }
        public string? channel_description { get; set; }
        public DateTime? date_created { get; set; }
        public string? channel_picture { get; set; }
        
    }
}