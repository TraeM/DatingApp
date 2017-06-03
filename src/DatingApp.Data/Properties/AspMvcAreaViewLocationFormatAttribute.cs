using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple =
        true)]
    public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
    {
        [NotNull]
        public string Format { get; private set; }

        public AspMvcAreaViewLocationFormatAttribute([NotNull] string format)
        {
            Format = format;
        }
    }
}