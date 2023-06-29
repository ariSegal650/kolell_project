using System;
using System.ComponentModel.DataAnnotations;

namespace LogicServices.EO
{
    public class Member_profileEO
    {
        public string account_type { get; set; }=string.Empty;
        public int number_of_views { get; set; }
        public DateTime viewtime { get; set; }
        public string user_group { get; set; }=string.Empty;
        public string email_address { get; set; }=string.Empty;
        public string user_name { get; set; }=string.Empty;
        public string password { get; set; }=string.Empty;
        public string? passwordSalt { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public int? zip_code { get; set; }
        public string? country { get; set; }
        public int rating_number_votes { get; set; }
        public int rating_total_points { get; set; }
        public int updated_rating { get; set; }
        public DateTime last_seen { get; set; }
        public string user_ip { get; set; }=string.Empty;
        public DateTime? birthday { get; set; }
        public string? gender { get; set; }
        public string? relationship_status { get; set; }
        public string? about_me { get; set; }
        public string? personal_website { get; set; }
        public string? home_town { get; set; }
        public string? home_country { get; set; }
        public string? current_country { get; set; }
        public string? high_school { get; set; }
        public string? college { get; set; }
        public string? work_places { get; set; }
        public string? interests { get; set; }
        public string? fav_movies { get; set; }
        public string? fav_music { get; set; }
        public string? current_city { get; set; }
        
          [Key]
        public int user_id { get; set; }
        public string? confirm_email_code { get; set; }
        public string? account_status { get; set; }
        public string? random_code { get; set; }
        public DateTime? date_created { get; set; }
        public int moderator { get; set; }
        public int flag_counter { get; set; }

    }
}