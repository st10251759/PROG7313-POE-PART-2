using Microsoft.EntityFrameworkCore;

namespace ST10251759_PROG7313_POE_PART_2.Data
{
    public class Prog7311DbContext : DbContext
    {
        public Prog7311DbContext(DbContextOptions<Prog7311DbContext> options) : base(options)
        {
        }
    }
}
