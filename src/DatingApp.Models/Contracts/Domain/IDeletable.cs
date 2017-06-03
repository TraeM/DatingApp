namespace DatingApp.Data.Contracts.Domain
{
    public interface IDeletable
    {
        bool? IsDeleted { get; set; }
    }
}