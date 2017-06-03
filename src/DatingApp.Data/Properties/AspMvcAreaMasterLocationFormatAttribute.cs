using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple =
        true)]
    public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
    {
        [NotNull]
        public string Format { get; private set; }

        public AspMvcAreaMasterLocationFormatAttribute([NotNull] string format)
        {
            Format = format;
        }
    }
}