// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// OS feed type values.
    /// Serialized Name: OSFeedType
    /// </summary>
    public readonly partial struct SphereOSFeedType : IEquatable<SphereOSFeedType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SphereOSFeedType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SphereOSFeedType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RetailValue = "Retail";
        private const string RetailEvalValue = "RetailEval";

        /// <summary>
        /// Retail OS feed type.
        /// Serialized Name: OSFeedType.Retail
        /// </summary>
        public static SphereOSFeedType Retail { get; } = new SphereOSFeedType(RetailValue);
        /// <summary>
        /// Retail evaluation OS feed type.
        /// Serialized Name: OSFeedType.RetailEval
        /// </summary>
        public static SphereOSFeedType RetailEval { get; } = new SphereOSFeedType(RetailEvalValue);
        /// <summary> Determines if two <see cref="SphereOSFeedType"/> values are the same. </summary>
        public static bool operator ==(SphereOSFeedType left, SphereOSFeedType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SphereOSFeedType"/> values are not the same. </summary>
        public static bool operator !=(SphereOSFeedType left, SphereOSFeedType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SphereOSFeedType"/>. </summary>
        public static implicit operator SphereOSFeedType(string value) => new SphereOSFeedType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SphereOSFeedType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SphereOSFeedType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
