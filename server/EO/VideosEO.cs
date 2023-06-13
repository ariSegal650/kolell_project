using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.EO
{
    public class VideosEO
    {
        public int indexer { get; set; }
        public string? video_id { get; set; }
        public string type { get; set; }=string.Empty;
        public string response_id { get; set; }=string.Empty;
        public int channel_id { get; set; }
        public int sub_channel_id { get; set; }
        public int? user_id { get; set; }
        public DateTime? viewtime { get; set; }
        public string? title { get; set; }
        public string? title_seo { get; set; }
        public string? description { get; set; }
        public string? tags { get; set; }
        public string? channel { get; set; }
        public DateTime? date_recorded { get; set; }
        public DateTime? date_uploaded { get; set; }
        public string? location_recorded { get; set; }
        public string? video_length { get; set; }
        public Boolean? allow_comments { get; set; }
        public Boolean? allow_embedding { get; set; }
        public Boolean? allow_ratings { get; set; }
        public int? rating_number_votes { get; set; }
        public int? rating_total_points { get; set; }
        public int? updated_rating { get; set; }
        public string? public_private { get; set; }
        public string? approved { get; set; }
        public int? number_of_views { get; set; }
        public Boolean? featured { get; set; }
        public Boolean promoted { get; set; }
        public int flag_counter { get; set; }
        public string video_type { get; set; }=string.Empty;
        public string? embed_id { get; set; }
        public string media_location { get; set; }=string.Empty;
        public string media_quality { get; set; }=string.Empty;
    }
}