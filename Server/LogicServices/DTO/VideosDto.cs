using System;

namespace LogicServices.DTO
{
    public class VideosDto
    {
        public int indexer { get; set; }
        public string? video_id { get; set; }
        public int channel_id { get; set; }
        public int sub_channel_id { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public string? tags { get; set; }
        public string? channel { get; set; }
        public DateTime? date_uploaded { get; set; }
        public string? video_length { get; set; }
        public int? number_of_views { get; set; }
        public string? channel_name { get; set; }
        public string? channel_name_seo { get; set; }
        public string? channel_description { get; set; }
        public string? last_name { get; set; }
        public string? first_name { get; set; }
        public int? user_id { get; set; }

    }
}