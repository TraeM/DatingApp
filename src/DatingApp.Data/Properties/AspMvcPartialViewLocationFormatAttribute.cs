using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple =
        true)]
    public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
    {
        [NotNull]
        public string Format { get; private set; }

        public AspMvcPartialViewLocationFormatAttribute([NotNull] string format)
        {
            Format = format;
        }
    }
}