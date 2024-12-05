using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Models.DbItem;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Services
{
    public interface IDbItemService
    {
        public Task<IList<DbItemDto>> GetAll();

        public Task<DbItemDto?> GetById(Guid id);

        public Task<bool> Update(DbItemDto model);

        public Task<DbItemDto> Add(DbItemCreateDto model);

        public Task<bool> Delete(Guid id);
    }
}

