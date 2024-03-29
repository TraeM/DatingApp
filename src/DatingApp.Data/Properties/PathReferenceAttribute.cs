using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     Indicates that a parameter is a path to a file or a folder within a web project.
    ///     Path can be relative or absolute, starting from web root (~).
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class PathReferenceAttribute : Attribute
    {
        [CanBeNull]
        public string BasePath { get; private set; }

        public PathReferenceAttribute() { }

        public PathReferenceAttribute([NotNull] [PathReference] string basePath)
        {
            BasePath = basePath;
        }
    }
}