using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HtmlAttributeValueAttribute : Attribute
    {
        [NotNull]
        public string Name { get; private set; }

        public HtmlAttributeValueAttribute([NotNull] string name)
        {
            Name = name;
        }
    }
}