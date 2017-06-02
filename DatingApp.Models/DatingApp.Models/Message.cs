using System;

namespace DatingApp.Models
{
    public class Message : DomainBase, IDeletable
    {
        public uint SenderId { get; set; }
        public uint RecieverId { get; set; }
        public DateTime SentTime { get; set; }
        public DateTime RecievedTime { get; set; }
        public string Content { get; set; }
        public bool Liked { get; set; }
        public bool IsDeleted { get; set; }
    }
}