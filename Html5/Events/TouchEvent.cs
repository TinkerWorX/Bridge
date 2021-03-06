﻿// The documentation for this class (on <summary> tags) was extracted from:
// https://developer.mozilla.org/en-US/docs/Web/API/TouchEvent

using Bridge.Html5.Interfaces;

namespace Bridge.Html5.Events
{
    [External]
    [Name("TouchEvent")]
    public class TouchEvent : UIEvent
    {
        /// <summary>
        /// A Boolean value indicating whether or not the alt key was down when the touch event was fired.
        /// </summary>
        public readonly bool AltKey;

        /// <summary>
        /// A <see cref="TouchList"/> of all the <see cref="Touch"/> objects representing individual points of contact whose states changed between the previous touch event and this one.
        /// </summary>
        public readonly TouchList ChangedTouches;

        /// <summary>
        /// A Boolean value indicating whether or not the control key was down when the touch event was fired.
        /// </summary>
        public readonly bool CtrlKey;

        /// <summary>
        /// A Boolean value indicating whether or not the meta key was down when the touch event was fired.
        /// </summary>
        public readonly bool MetaKey;

        /// <summary>
        /// A Boolean value indicating whether or not the shift key was down when the touch event was fired.
        /// </summary>
        public readonly bool ShiftKey;

        /// <summary>
        /// A <see cref="TouchList"/> of all the <see cref="Touch"/> objects that are both currently in contact with the touch surface and were also started on the same element that is the target of the event.
        /// </summary>
        public readonly TouchList targetTouches;

        /// <summary>
        /// A <see cref="TouchList"/> of all the <see cref="Touch"/> objects representing all current points of contact with the surface, regardless of target or changed status.
        /// </summary>
        public readonly TouchList Touches;
    }
}
