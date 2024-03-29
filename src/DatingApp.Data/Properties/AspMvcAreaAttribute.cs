using System;

namespace DatingApp.Data.Properties {
    /// <summary>
    ///     ASP.NET MVC attribute. Indicates that a parameter is an MVC area.
    ///     Use this attribute for custom wrappers similar to
    ///     <c>System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AspMvcAreaAttribute : Attribute
    {
        [CanBeNull]
        public string AnonymousProperty { get; private set; }

        public AspMvcAreaAttribute() { }

        public AspMvcAreaAttribute([NotNull] string anonymousProperty)
        {
            AnonymousProperty = anonymousProperty;
        }
    }
}