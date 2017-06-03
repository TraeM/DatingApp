using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class RazorInjectionAttribute : Attribute
    {
        [NotNull]
        public string Type { get; private set; }

        [NotNull]
        public string FieldName { get; private set; }

        public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
        {
            Type = type;
            FieldName = fieldName;
        }
    }
}