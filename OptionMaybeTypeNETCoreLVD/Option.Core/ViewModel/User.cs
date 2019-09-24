using System;
using System.Collections.Generic;

namespace Option.Core.ViewModel
{
    public class User
    {
        public Guid Key { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string Mail { get; set; }
        public string Genre { get; set; }
        public Photo Image { get; set; }
        public List<Phone> Phones { get; set; } = new List<Phone>();
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string BirthDate { get; set; }

        public List<Client> Clients { get; set; } = new List<Client>();

        public void SetKey(string key) => Key = Guid.Parse(key);
    }
}
