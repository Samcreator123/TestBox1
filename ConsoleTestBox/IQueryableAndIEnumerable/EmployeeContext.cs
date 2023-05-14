using System.Data.Entity;

namespace ConsoleTestBox.IQueryableAndIEnumerable
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base(@"server=127.0.0.1;database=TEST;uid=sa;pwd=Sam008125;Connection Timeout=10") 
        {
        }

        public DbSet<EMPLOYEE> EMPLOYEE { get; set; }

    }

}
