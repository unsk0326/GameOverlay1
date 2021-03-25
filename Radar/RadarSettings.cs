﻿// <copyright file="RadarSettings.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Radar
{
    using GameHelper.Plugin;

    /// <summary>
    /// <see cref="Radar"/> plugin settings class.
    /// </summary>
    public sealed class RadarSettings : IPSettings
    {
#pragma warning disable SA1401
        /// <summary>
        /// Multipler to apply to the Large Map icons
        /// so they display correctly on the screen.
        /// </summary>
        public float LargeMapScaleMultiplier = 0.174f;

        /// <summary>
        /// Hides all the entities that doesn't have life or chest component.
        /// </summary>
        public bool HideUseless = true;
#pragma warning restore SA1401
    }
}