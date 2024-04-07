using Microsoft.EntityFrameworkCore;
using VideoGamesManagement.DataLayer.Entities;

namespace VideoGamesManagement.DataLayer.DBContext
{
    public class VideoGamesManagementDBContext : DbContext
    {
        public VideoGamesManagementDBContext() { }
        public DbSet<VideoGame> VideoGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set your own connection string
            optionsBuilder.UseSqlServer("Data Source=WINDOWS-4PGG12B;Initial Catalog=VideoGamesManagement;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
