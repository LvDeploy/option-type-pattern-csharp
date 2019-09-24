using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Option.Repository.Entity
{
    public class User
    {
        [BsonId]
        public Guid Key { get; protected set; }
        public string FullName { get; protected set; }
        public string NickName { get; protected set; }
        public string Mail { get; protected set; }
        public string Genre { get; protected set; }
        public Photo Image { get; protected set; }
        public List<Phone> Phones { get; protected set; } = new List<Phone>();
        public string Password { get; protected set; }
        public string ConfirmPassword { get; protected set; }
        public string BirthDate { get; protected set; }
        public List<Client> Clients { get; protected set; } = new List<Client>();

        public User()
        {
           
        }

        public User Create()
        {
            Key = Guid.NewGuid();
            return this;
        }
    }
}
