using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Context.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Context
{
    [ExcludeFromCodeCoverage(Justification = "It's EF context implementation")]
    public class CustomDbContext(DbContextOptions<CustomDbContext> options) : DbContext(options)
    {
        public virtual DbSet<DbItem> DbItems { get; set; }
    }
}

