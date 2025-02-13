// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ProfileResourceGetWafLogAnalyticsMetricsOptions. </summary>
    public partial class ProfileResourceGetWafLogAnalyticsMetricsOptions
    {
        /// <summary> Initializes a new instance of ProfileResourceGetWafLogAnalyticsMetricsOptions. </summary>
        /// <param name="metrics"> The ArrayOfWafMetric to use. </param>
        /// <param name="dateTimeBegin"> The DateTime to use. </param>
        /// <param name="dateTimeEnd"> The DateTime to use. </param>
        /// <param name="granularity"> The WafGranularity to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metrics"/> is null. </exception>
        public ProfileResourceGetWafLogAnalyticsMetricsOptions(IEnumerable<WafMetric> metrics, DateTimeOffset dateTimeBegin, DateTimeOffset dateTimeEnd, WafGranularity granularity)
        {
            Argument.AssertNotNull(metrics, nameof(metrics));

            Metrics = metrics.ToList();
            DateTimeBegin = dateTimeBegin;
            DateTimeEnd = dateTimeEnd;
            Granularity = granularity;
            Actions = new ChangeTrackingList<WafAction>();
            GroupBy = new ChangeTrackingList<WafRankingGroupBy>();
            RuleTypes = new ChangeTrackingList<WafRuleType>();
        }

        /// <summary> The ArrayOfWafMetric to use. </summary>
        public IList<WafMetric> Metrics { get; }
        /// <summary> The DateTime to use. </summary>
        public DateTimeOffset DateTimeBegin { get; }
        /// <summary> The DateTime to use. </summary>
        public DateTimeOffset DateTimeEnd { get; }
        /// <summary> The WafGranularity to use. </summary>
        public WafGranularity Granularity { get; }
        /// <summary> The ArrayOfWafAction to use. </summary>
        public IList<WafAction> Actions { get; }
        /// <summary> The ArrayOfWafRankingGroupBy to use. </summary>
        public IList<WafRankingGroupBy> GroupBy { get; }
        /// <summary> The ArrayOfWafRuleType to use. </summary>
        public IList<WafRuleType> RuleTypes { get; }
    }
}
