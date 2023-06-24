using Microsoft.EntityFrameworkCore;
using LogicServices.EO;

namespace LogicServices.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<ChannelsEO> channels { get; set; }
        public DbSet<Sub_channelsEO> sub_channels { get; set; }
        public DbSet<VideosEO> videos { get; set; }
        public DbSet<Member_profileEO> member_profile { get; set; }

    }
}