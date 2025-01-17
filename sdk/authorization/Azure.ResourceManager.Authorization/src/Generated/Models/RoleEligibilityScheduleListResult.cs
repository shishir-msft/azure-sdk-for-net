// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> role eligibility schedule list operation result. </summary>
    internal partial class RoleEligibilityScheduleListResult
    {
        /// <summary> Initializes a new instance of RoleEligibilityScheduleListResult. </summary>
        internal RoleEligibilityScheduleListResult()
        {
            Value = new ChangeTrackingList<RoleEligibilityScheduleData>();
        }

        /// <summary> Initializes a new instance of RoleEligibilityScheduleListResult. </summary>
        /// <param name="value"> role eligibility schedule list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleEligibilityScheduleListResult(IReadOnlyList<RoleEligibilityScheduleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> role eligibility schedule list. </summary>
        public IReadOnlyList<RoleEligibilityScheduleData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
