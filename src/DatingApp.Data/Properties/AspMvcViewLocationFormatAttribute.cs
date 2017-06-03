using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple =
        true)]
    public sealed class AspMvcViewLocationFormatAttribute : Attribute
    {
        [NotNull]
        public string Format { get; private set; }

        public AspMvcViewLocationFormatAttribute([NotNull] string format)
        {
            Format = format;
        }
    }
}