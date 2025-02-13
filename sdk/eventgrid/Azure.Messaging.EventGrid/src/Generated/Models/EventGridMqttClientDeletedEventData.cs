// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Event data for Microsoft.EventGrid.MQTTClientDeleted event. </summary>
    public partial class EventGridMqttClientDeletedEventData : EventGridMqttClientEventData
    {
        /// <summary> Initializes a new instance of EventGridMqttClientDeletedEventData. </summary>
        internal EventGridMqttClientDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of EventGridMqttClientDeletedEventData. </summary>
        /// <param name="clientAuthenticationName"> Unique identifier for the MQTT client that the client presents to the service for authentication. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </param>
        /// <param name="clientName"> Name of the client resource in the Event Grid namespace. </param>
        /// <param name="namespaceName"> Name of the Event Grid namespace where the MQTT client was created or updated. </param>
        internal EventGridMqttClientDeletedEventData(string clientAuthenticationName, string clientName, string namespaceName) : base(clientAuthenticationName, clientName, namespaceName)
        {
        }
    }
}
