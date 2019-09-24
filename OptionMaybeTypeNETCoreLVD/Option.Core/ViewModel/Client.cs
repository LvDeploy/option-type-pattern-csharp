using System;
using System.Collections.Generic;

namespace Option.Core.ViewModel
{
    public class Client
    {
        public Guid Key { get; set; }
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string Genre { get; set; }
        public string Mail { get; set; }
        public List<Phone> Phones { get; set; } = new List<Phone>();
    }
}
