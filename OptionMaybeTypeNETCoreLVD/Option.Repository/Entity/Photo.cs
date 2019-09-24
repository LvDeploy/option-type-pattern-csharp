using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Option.Repository.Entity
{
    public class Photo
    {
        [BsonId]
        public Guid Key { get; set; }

        public byte[] Bytes { get; set; }

        public string Base64 { get; set; }

        public string Name { get; set; }
    }
}
