using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     Indicates that IEnumerable, passed as parameter, is not enumerated.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class NoEnumerationAttribute : Attribute { }
}