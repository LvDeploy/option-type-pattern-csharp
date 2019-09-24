using System;

namespace Option.Core.ViewModel
{
    public class Photo
    {
        public Guid Key { get; set; }

        public byte[] Bytes { get; set; }

        public string Base64 { get; set; }

        public string Name { get; set; }
    }
}
