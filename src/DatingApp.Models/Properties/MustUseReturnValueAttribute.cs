using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     Indicates that the return value of method invocation must be used.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class MustUseReturnValueAttribute : Attribute
    {
        [CanBeNull]
        public string Justification { get; private set; }

        public MustUseReturnValueAttribute() { }

        public MustUseReturnValueAttribute([NotNull] string justification)
        {
            Justification = justification;
        }
    }
}