using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple =
        true)]
    public sealed class AspMvcMasterLocationFormatAttribute : Attribute
    {
        [NotNull]
        public string Format { get; private set; }

        public AspMvcMasterLocationFormatAttribute([NotNull] string format)
        {
            Format = format;
        }
    }
}