// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Region profile. </summary>
    public partial class RegionContract
    {
        /// <summary> Initializes a new instance of RegionContract. </summary>
        internal RegionContract()
        {
        }

        /// <summary> Initializes a new instance of RegionContract. </summary>
        /// <param name="name"> Region name. </param>
        /// <param name="isMasterRegion"> whether Region is the master region. </param>
        /// <param name="isDeleted"> whether Region is deleted. </param>
        internal RegionContract(string name, bool? isMasterRegion, bool? isDeleted)
        {
            Name = name;
            IsMasterRegion = isMasterRegion;
            IsDeleted = isDeleted;
        }

        /// <summary> Region name. </summary>
        public string Name { get; }
        /// <summary> whether Region is the master region. </summary>
        public bool? IsMasterRegion { get; }
        /// <summary> whether Region is deleted. </summary>
        public bool? IsDeleted { get; }
    }
}
