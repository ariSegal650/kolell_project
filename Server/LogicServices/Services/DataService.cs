using System.Collections.Generic;
using System.Linq;
using LogicServices.Data;
using LogicServices.DTO;
using LogicServices.EO;
using Microsoft.AspNetCore.Authorization;

namespace LogicServices.Services
{
    public class DataService
    {
        private readonly DataContext _DataContext;

        protected IQueryable<VideosDto> BasicQueryVideo;
        public DataService(DataContext dataContext)
        {
            _DataContext = dataContext;
           BasicQueryVideo= InitializeBasicQueryVideo();
        }

        public List<VideosDto> GetLastVideos()
        {
            var query = BasicQueryVideo.OrderByDescending(v => v.date_uploaded).Take(20).ToList();

            return (query);
        }
         public List<MemberProfileDto> GetSpeakers()
        {
            var query = _DataContext.member_profile.Select(profile=>new MemberProfileDto(profile.user_name,profile.first_name,profile.last_name,profile.user_id)).Take(20).ToList();

            return (query);
        }
          public List<ChannelsEO> GetAllChannles()
        {
            var query = _DataContext.channels.ToList();
            
            return (query);
        }

        public List<VideosDto> GetVideosByCategoryService(int Category)
        {
            var query = BasicQueryVideo.OrderByDescending(v=>v.date_uploaded).Where(v => v.channel_id == Category).Take(20).ToList();

            return query;
        }
        public List<VideosDto> GetVideosBySpeaker(int speaker)
        {
            var query = BasicQueryVideo.OrderByDescending(v=>v.date_uploaded).Where(v => v.user_id == speaker).Take(20).ToList();

            return query;
        }
           public List<VideosDto> test(string se)
        {
            var query = BasicQueryVideo.Where(u=>u.channel_name==se).ToList();

            return query;
        }

        public bool AddVideo()
        {
            try
            {

              //  _DataContext.videos.Add();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return true;
        }



        private IQueryable<VideosDto> InitializeBasicQueryVideo()
        {
            return (from video in _DataContext.videos
                         // join channel in _DataContext.sub_channels on video.sub_channel_id equals channel.sub_channel_id
                          //join sub in _DataContext.sub_channels on video.user_id equals 
                          select new VideosDto
                          {
                              // select from video table
                              indexer = video.indexer,
                              video_id = video.video_id,
                              channel_id = video.channel_id,
                              sub_channel_id = video.sub_channel_id,
                              title = video.title,
                              description = video.description,
                              tags = video.tags,
                              channel = video.channel,
                              date_uploaded = video.date_uploaded,
                              video_length = video.video_length,
                              number_of_views = video.number_of_views,
                              user_id = video.user_id,
                
                            //   channel_name = channel.sub_channel_name,
                            //   channel_name_seo = channel.sub_channel_name_seo,
                            //   // select from channel Member_profile
                            //   last_name = user.last_name,
                            //   first_name = user.first_name,

                          });

        }

        

    }
}







