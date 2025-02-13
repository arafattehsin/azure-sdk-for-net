// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricIPPrefix data model.
    /// The IP Prefix resource definition.
    /// </summary>
    public partial class NetworkFabricIPPrefixData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricIPPrefixData. </summary>
        /// <param name="location"> The location. </param>
        public NetworkFabricIPPrefixData(AzureLocation location) : base(location)
        {
            IPPrefixRules = new ChangeTrackingList<IPPrefixRule>();
        }

        /// <summary> Initializes a new instance of NetworkFabricIPPrefixData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="ipPrefixRules"> The list of IP Prefix Rules. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        internal NetworkFabricIPPrefixData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, IList<IPPrefixRule> ipPrefixRules, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            IPPrefixRules = ipPrefixRules;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> The list of IP Prefix Rules. </summary>
        public IList<IPPrefixRule> IPPrefixRules { get; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}
