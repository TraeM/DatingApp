using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     Indicates that marked element should be localized or not.
    /// </summary>
    /// <example>
    ///     <code>
    /// [LocalizationRequiredAttribute(true)]
    /// class Foo {
    ///   string str = "my string"; // Warning: Localizable string
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class LocalizationRequiredAttribute : Attribute
    {
        public bool Required { get; private set; }
        public LocalizationRequiredAttribute() : this(true) { }

        public LocalizationRequiredAttribute(bool required)
        {
            Required = required;
        }
    }
}