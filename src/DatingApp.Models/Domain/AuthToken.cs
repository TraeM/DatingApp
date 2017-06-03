using System;

using DatingApp.Data.Contracts.Domain;

namespace DatingApp.Data.Domain
{
    public struct AuthToken : IDomain
    {
        public uint Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
        public bool IsExpired { get; set; }
        public byte[] Value { get; set; }
    }
}