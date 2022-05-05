#nullable disable
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


using Alternet.UI.Threading;
using System;

namespace Alternet.UI
{
    /// <summary>
    ///     Provides the base class for all input devices.
    /// </summary>
    public abstract class InputDevice : DispatcherObject
    {
        /// <summary>
        ///     Constructs an instance of the InputDevice class.
        /// </summary>
        protected InputDevice()
        {
            // Only we can create these.
            // But perhaps HID devices can create these too? 
        }

        ///// <summary>
        /////     Returns the element that input from this device is sent to.
        ///// </summary>
        //public abstract IInputElement Target{get;}

        ///// <summary>
        /////     Returns the PresentationSource that is reporting input for this device.
        ///// </summary>
        //public abstract PresentationSource ActiveSource { get; }
    }
}
