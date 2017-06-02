using System;

namespace DatingApp.Models
{
    public struct ProfileImage : IDeletable
    {
        public Uri Url { get; set; }
        public ushort Priority { get; set; }
        public bool IsDeleted { get; set; }
    }
}