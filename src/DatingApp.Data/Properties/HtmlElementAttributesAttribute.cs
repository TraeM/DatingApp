using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class HtmlElementAttributesAttribute : Attribute
    {
        [CanBeNull]
        public string Name { get; private set; }

        public HtmlElementAttributesAttribute() { }

        public HtmlElementAttributesAttribute([NotNull] string name)
        {
            Name = name;
        }
    }
}