using System;

using F10Y.T0000;


namespace F10Y.T0008
{
    /// <summary>
    /// Attribute indicating a type is a Razor page.
    /// It's usually pretty clear that something is a Razor page, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of Razor pages.
    /// <para>
    /// Note! The page marker is <strong>only</strong> for pages that are URL-reachable (usually only Razor components with a page-directive).
    /// </para>
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class, // Scripts are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class RazorPageMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a Razor page type.
        /// This is useful for marking types that end up canonical Razor page code file locations, but are not actually Razor pages.
        /// </summary>
        public bool Is_RazorPage { get; }


        public RazorPageMarkerAttribute(
            bool is_RazorPage = true)
        {
            this.Is_RazorPage = is_RazorPage;
        }
    }
}
