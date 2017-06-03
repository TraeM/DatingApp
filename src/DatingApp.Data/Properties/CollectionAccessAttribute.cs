using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     Indicates how method, constructor invocation or property access
    ///     over collection type affects content of the collection.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property)]
    public sealed class CollectionAccessAttribute : Attribute
    {
        public CollectionAccessType CollectionAccessType { get; private set; }

        public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
        {
            CollectionAccessType = collectionAccessType;
        }
    }
}