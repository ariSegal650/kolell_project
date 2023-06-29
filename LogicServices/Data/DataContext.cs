using Microsoft.EntityFrameworkCore;
using LogicServices.EO;

namespace LogicServices.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            channels = Set<ChannelsEO>();
            sub_channels=Set<Sub_channelsEO>();
            videos=Set<VideosEO>();
            member_profile=Set<Member_profileEO>();
        }

        public DbSet<ChannelsEO> channels { get; set; }
        public DbSet<Sub_channelsEO> sub_channels { get; set; }
        public DbSet<VideosEO> videos { get; set; }
        public DbSet<Member_profileEO> member_profile { get; set; }

    }
}