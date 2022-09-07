using Microsoft.EntityFrameworkCore;

namespace BizsolTechAssessment.Models.DBModels
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Developer> Developers { get; set; }
    }
}
