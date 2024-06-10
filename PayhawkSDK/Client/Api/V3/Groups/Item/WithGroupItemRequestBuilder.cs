// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using PayhawkSDK.Client.Api.V3.Groups.Item.Teams;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace PayhawkSDK.Client.Api.V3.Groups.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\groups\{groupId}
    /// </summary>
    public class WithGroupItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The teams property</summary>
        public PayhawkSDK.Client.Api.V3.Groups.Item.Teams.TeamsRequestBuilder Teams
        {
            get => new PayhawkSDK.Client.Api.V3.Groups.Item.Teams.TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Groups.Item.WithGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithGroupItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/groups/{groupId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Groups.Item.WithGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithGroupItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/groups/{groupId}", rawUrl)
        {
        }
    }
}