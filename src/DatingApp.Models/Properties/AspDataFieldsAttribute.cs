using System;

namespace DatingApp.Data.Properties {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public sealed class AspDataFieldsAttribute : Attribute { }
}