using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     For a parameter that is expected to be one of the limited set of values.
    ///     Specify fields of which type should be used as values for this parameter.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field,
        AllowMultiple = true)]
    public sealed class ValueProviderAttribute : Attribute
    {
        [NotNull]
        public string Name { get; private set; }

        public ValueProviderAttribute([NotNull] string name)
        {
            Name = name;
        }
    }
}