using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cummins.Bootstrapper
{
    internal class Program
    {
        private static async Task Main()
        {
            var dbContext = new CumminsDbContext();

            Console.WriteLine($"Migrating on {dbContext.Database.GetDbConnection().ConnectionString}");
            await dbContext.Database.MigrateAsync();

            Console.WriteLine("Done!");
        }
    }
}
