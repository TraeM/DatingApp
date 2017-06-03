using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     Indicates that the marked method unconditionally terminates control flow execution.
    ///     For example, it could unconditionally throw exception.
    /// </summary>
    [Obsolete(message: "Use [ContractAnnotation('=> halt')] instead")]
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class TerminatesProgramAttribute : Attribute { }
}