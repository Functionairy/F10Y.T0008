using System;

using F10Y.T0000;


namespace F10Y.T0008
{
    /// <summary>
    /// Attribute indicating a type is a Razor component.
    /// It's usually pretty clear that something is a Razor component, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of Razor components.
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class, // Scripts are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class RazorComponentMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a Razor component type.
        /// This is useful for marking types that end up canonical Razor component code file locations, but are not actually Razor components.
        /// </summary>
        public bool Is_RazorComponent { get; }


        public RazorComponentMarkerAttribute(
            bool is_RazorComponent = true)
        {
            this.Is_RazorComponent = is_RazorComponent;
        }
    }
}
