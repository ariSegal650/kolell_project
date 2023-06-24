using LogicServices.EO;
using LogicServices.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Collections.Generic;

namespace LogicServices.Services
{
    public class DataService
    {
        // Create a Stopwatch instance
      Stopwatch stopwatch = new Stopwatch();
        private readonly DataContext _DataContext;

        public DataService(DataContext dataContext)
        {
            _DataContext = dataContext;
        }

        public  List<VideosEO> GetLastVideos()
        {
            stopwatch.Start();

             var query = (from Video in _DataContext.videos
                        select new
                        {
                            Video.indexer,
                            Video.video_id,
                            Video.channel_id,
                            Video.sub_channel_id,
                            Video.title,
                            Video.description,
                            Video.tags,
                            Video.channel,
                            Video.date_uploaded,
                            Video.video_length,
                            Video.number_of_views,
                        }).OrderBy(v=>v.date_uploaded).Take(20).ToList();
                    
                    stopwatch.Stop();

    long elapsedTime = stopwatch.ElapsedMilliseconds;

    // Print the runtime
    Console.WriteLine("Elapsed Time: {0} ms", elapsedTime);
    var q=_DataContext.videos.OrderBy(l=>l.date_uploaded).Take(20).ToList();
                    
            return (q);
        }
    }
}







