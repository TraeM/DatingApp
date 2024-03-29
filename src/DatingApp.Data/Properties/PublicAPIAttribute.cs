using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     This attribute is intended to mark publicly available API
    ///     which should not be removed and so is treated as used.
    /// </summary>
    [MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
    public sealed class PublicAPIAttribute : Attribute
    {
        [CanBeNull]
        public string Comment { get; private set; }

        public PublicAPIAttribute() { }

        public PublicAPIAttribute([NotNull] string comment)
        {
            Comment = comment;
        }
    }
}