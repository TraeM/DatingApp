namespace DatingApp.Models
{
    public struct Decision : IDomain
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public bool Like { get; set; }
    }
}