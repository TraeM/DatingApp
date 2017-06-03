using System;

using DatingApp.Data.Contracts.Domain;

namespace DatingApp.Data.Domain
{
    public struct ProfileImage : IDeletable
    {
        public Uri Url { get; set; }
        public ushort Priority { get; set; }
        public bool? IsDeleted { get; set; }
    }
}