﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace XRTK.Ultraleap.Definitions
{
    /// <summary>
    /// Supported operation modes for the leap motion device.
    /// </summary>
    public enum LeapMotionOperationMode
    {
        /// <summary>
        /// The leap motion device is lying flat on a desk and pointing
        /// upwards.
        /// </summary>
        Desktop = 0,
        /// <summary>
        /// The leap motion device is mounted to a headset and
        /// pointing in forward direction.
        /// </summary>
        HeadsetMounted
    }
}