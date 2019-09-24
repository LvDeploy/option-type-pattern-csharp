using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Option.Repository.Entity
{
    public class Phone
    {
        [BsonId]
        public Guid Key { get; set; }
        public int Number { get; set; }
        public int DDD { get; set; }
        public int PreFix { get; set; }
    }
}
