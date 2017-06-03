using DatingApp.Data.Contracts.Domain;

namespace DatingApp.Data.Domain
{
    public struct Match : IDomain
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint MatchedUserId { get; set; }
    }
}