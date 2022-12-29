using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Dtos
{
    public record ItemDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; init; } //immutable property == init or private set; == cannot moditfy property after creation
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}