namespace DatingApp.Models
{
    public struct Match : IDomain, IDeletable
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint MatchedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}