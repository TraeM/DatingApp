using DatingApp.Data.Contracts.Domain;

namespace DatingApp.Data.Domain
{
    public struct Decision : IDomain
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint LikedUserId { get; set; }
        public bool Like { get; set; }
    }
}