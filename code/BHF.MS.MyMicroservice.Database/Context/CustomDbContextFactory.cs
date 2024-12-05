using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Diagnostics.CodeAnalysis;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Context
{
    [ExcludeFromCodeCoverage(Justification = "It's EF context design-time factory implementation")]
    public class CustomDbContextFactory : IDesignTimeDbContextFactory<CustomDbContext>
    {
        public CustomDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CustomDbContext>();
            optionsBuilder.UseSqlServer(string.Join(" ", args));
            return new CustomDbContext(optionsBuilder.Options);
        }
    }
}

