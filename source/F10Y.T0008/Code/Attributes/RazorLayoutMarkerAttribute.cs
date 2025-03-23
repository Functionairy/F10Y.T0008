using System;

using F10Y.T0000;


namespace F10Y.T0008
{
    /// <summary>
    /// Attribute indicating a type is a Razor layout.
    /// It's usually pretty clear that something is a Razor layout, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of Razor layouts.
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class, // Scripts are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class RazorLayoutMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a Razor layout type.
        /// This is useful for marking types that end up canonical Razor layout code file locations, but are not actually Razor layouts.
        /// </summary>
        public bool Is_RazorLayout { get; }


        public RazorLayoutMarkerAttribute(
            bool is_RazorLayout = true)
        {
            this.Is_RazorLayout = is_RazorLayout;
        }
    }
}
