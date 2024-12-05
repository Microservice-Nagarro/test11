using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Context;
using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Context.Entities;
using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Models.DbItem;
using Microsoft.EntityFrameworkCore;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Services
{
    public class DbItemService(CustomDbContext context) : IDbItemService
    {
        public async Task<IList<DbItemDto>> GetAll()
        {
            return await context.DbItems
                .OrderByDescending(x => x.LastUpdated)
                .Take(100)
                .Select(x => new DbItemDto(x)).ToListAsync();
        }

        public async Task<DbItemDto?> GetById(Guid id)
        {
            return await context.DbItems.Where(x => x.Id == id).Select(x => new DbItemDto(x)).FirstOrDefaultAsync();
        }

        public async Task<bool> Update(DbItemDto model)
        {
            var dbItem = await context.DbItems.FindAsync(model.Id);
            if (dbItem == null)
            {
                return false;
            }

            dbItem.Update(model);

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await DbItemExists(model.Id))
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<DbItemDto> Add(DbItemCreateDto model)
        {
            var dbItem = new DbItem { Name = model.Name };

            context.DbItems.Add(dbItem);
            await context.SaveChangesAsync();

            return new DbItemDto(dbItem);
        }

        public async Task<bool> Delete(Guid id)
        {
            var dbItem = await context.DbItems.FindAsync(id);
            if (dbItem == null)
            {
                return false;
            }

            context.DbItems.Remove(dbItem);
            await context.SaveChangesAsync();

            return true;
        }

        private async Task<bool> DbItemExists(Guid id)
        {
            return await context.DbItems.AnyAsync(x => x.Id == id);
        }
    }
}

