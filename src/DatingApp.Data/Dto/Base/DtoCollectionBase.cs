using System.Collections.Specialized;

using DatingApp.Data.Contracts.Dto;

namespace DatingApp.Data.Dto.Base
{
    public abstract class DtoCollectionBase : IDtoCollection
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}