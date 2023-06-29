using System.Collections.Generic;
using System.Linq;
using LogicServices.Data;
using LogicServices.DTO;
using Microsoft.AspNetCore.Authorization;

namespace LogicServices.Services
{
    public class DataService
    {
        private readonly DataContext _DataContext;

        protected IQueryable<VideosDto> BasicQuery;
        public DataService(DataContext dataContext)
        {
            _DataContext = dataContext;
           BasicQuery= InitializeBasicQuery();
        }

        public List<VideosDto> GetLastVideos()
        {
            var query = BasicQuery.OrderByDescending(v => v.date_uploaded).Take(20).ToList();

            return (query);
        }

        public List<VideosDto> GetVideosByCategoryService(int Category)
        {
            var query = BasicQuery.OrderByDescending(v=>v.date_uploaded).Where(v => v.channel_id == Category).Take(20).ToList();

            return query;
        }
        public List<VideosDto> GetVideosBySpeaker(int speaker)
        {
            var query = BasicQuery.OrderByDescending(v=>v.date_uploaded).Where(v => v.user_id == speaker).Take(20).ToList();

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



        private IQueryable<VideosDto> InitializeBasicQuery()
        {
            return (from video in _DataContext.videos
                          join channel in _DataContext.channels on video.channel_id equals channel.channel_id
                          join user in _DataContext.member_profile on video.user_id equals user.user_id
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
                              // select from channel table
                              channel_name = channel.channel_name,
                              channel_name_seo = channel.channel_name_seo,
                              channel_description = channel.channel_description,

                              // select from channel Member_profile
                              last_name = user.last_name,
                              first_name = user.first_name,

                          });

        }

    }
}







