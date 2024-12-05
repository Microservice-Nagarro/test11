using BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Models.DbItem;
using FluentAssertions;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Database.Tests.Models.DbItem
{
    public sealed class DbItemDtoTests
    {
        [Fact]
        public void Constructor_DbItem_ShouldCopyValues()
        {
            // Arrange
            var dbItem = new Context.Entities.DbItem
            {
                Name = "abc",
                Id = Guid.NewGuid()
            };
            var expectedResult = new DbItemDto
            {
                Id = dbItem.Id,
                Name = dbItem.Name
            };

            // Act
            var sut = new DbItemDto(dbItem);

            // Assert
            sut.Should().BeEquivalentTo(expectedResult);
        }
    }
}

