// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> security services. </summary>
    public partial class RulestackSecurityServices
    {
        /// <summary> Initializes a new instance of RulestackSecurityServices. </summary>
        public RulestackSecurityServices()
        {
        }

        /// <summary> Initializes a new instance of RulestackSecurityServices. </summary>
        /// <param name="vulnerabilityProfile"> IPs Vulnerability Profile Data. </param>
        /// <param name="antiSpywareProfile"> Anti spyware Profile data. </param>
        /// <param name="antiVirusProfile"> anti virus profile data. </param>
        /// <param name="urlFilteringProfile"> URL filtering profile data. </param>
        /// <param name="fileBlockingProfile"> File blocking profile data. </param>
        /// <param name="dnsSubscription"> DNS Subscription profile data. </param>
        /// <param name="outboundUnTrustCertificate"> Untrusted Egress Decryption profile data. </param>
        /// <param name="outboundTrustCertificate"> Trusted Egress Decryption profile data. </param>
        internal RulestackSecurityServices(string vulnerabilityProfile, string antiSpywareProfile, string antiVirusProfile, string urlFilteringProfile, string fileBlockingProfile, string dnsSubscription, string outboundUnTrustCertificate, string outboundTrustCertificate)
        {
            VulnerabilityProfile = vulnerabilityProfile;
            AntiSpywareProfile = antiSpywareProfile;
            AntiVirusProfile = antiVirusProfile;
            UrlFilteringProfile = urlFilteringProfile;
            FileBlockingProfile = fileBlockingProfile;
            DnsSubscription = dnsSubscription;
            OutboundUnTrustCertificate = outboundUnTrustCertificate;
            OutboundTrustCertificate = outboundTrustCertificate;
        }

        /// <summary> IPs Vulnerability Profile Data. </summary>
        public string VulnerabilityProfile { get; set; }
        /// <summary> Anti spyware Profile data. </summary>
        public string AntiSpywareProfile { get; set; }
        /// <summary> anti virus profile data. </summary>
        public string AntiVirusProfile { get; set; }
        /// <summary> URL filtering profile data. </summary>
        public string UrlFilteringProfile { get; set; }
        /// <summary> File blocking profile data. </summary>
        public string FileBlockingProfile { get; set; }
        /// <summary> DNS Subscription profile data. </summary>
        public string DnsSubscription { get; set; }
        /// <summary> Untrusted Egress Decryption profile data. </summary>
        public string OutboundUnTrustCertificate { get; set; }
        /// <summary> Trusted Egress Decryption profile data. </summary>
        public string OutboundTrustCertificate { get; set; }
    }
}
