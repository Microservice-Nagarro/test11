using System.Text.Json.Serialization;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Models.DbItem
{
    public class DbItemDto : DbItemCreateDto
    {
        [JsonRequired]
        public Guid Id { get; set; }

        public DbItemDto()
        {
        }

        public DbItemDto(Context.Entities.DbItem dbItem) : base(dbItem)
        {
            Id = dbItem.Id;
        }
    }
}

