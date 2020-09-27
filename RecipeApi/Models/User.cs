using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RecipeApi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}