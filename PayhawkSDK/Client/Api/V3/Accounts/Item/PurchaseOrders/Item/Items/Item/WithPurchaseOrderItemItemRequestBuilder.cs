// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using PayhawkSDK.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.Items.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\accounts\{accountId}\purchase-orders\{purchaseOrderId}\items\{purchaseOrderItemId}
    /// </summary>
    public class WithPurchaseOrderItemItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.Items.Item.WithPurchaseOrderItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPurchaseOrderItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/purchase-orders/{purchaseOrderId}/items/{purchaseOrderItemId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.Items.Item.WithPurchaseOrderItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPurchaseOrderItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/purchase-orders/{purchaseOrderId}/items/{purchaseOrderItemId}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a specific purchase order line item.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 404 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "401", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "403", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "404", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "429", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a purchase order item by id.
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IPurchaseOrderItem"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PayhawkSDK.Client.Models.IPurchaseOrderItem?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PayhawkSDK.Client.Models.IPurchaseOrderItem> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "401", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "403", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "429", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<PayhawkSDK.Client.Models.IPurchaseOrderItem>(requestInfo, PayhawkSDK.Client.Models.IPurchaseOrderItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates an existing purchase order line item.
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IPurchaseOrderItem"/></returns>
        /// <param name="body">Purchase order item update request</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PayhawkSDK.Client.Models.IPurchaseOrderItem?> PatchAsync(PayhawkSDK.Client.Models.IPurchaseOrderItemPatch body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PayhawkSDK.Client.Models.IPurchaseOrderItem> PatchAsync(PayhawkSDK.Client.Models.IPurchaseOrderItemPatch body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "401", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "403", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "429", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<PayhawkSDK.Client.Models.IPurchaseOrderItem>(requestInfo, PayhawkSDK.Client.Models.IPurchaseOrderItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a specific purchase order line item.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a purchase order item by id.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates an existing purchase order line item.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Purchase order item update request</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(PayhawkSDK.Client.Models.IPurchaseOrderItemPatch body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(PayhawkSDK.Client.Models.IPurchaseOrderItemPatch body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.Items.Item.WithPurchaseOrderItemItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.Items.Item.WithPurchaseOrderItemItemRequestBuilder WithUrl(string rawUrl)
        {
            return new PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.Items.Item.WithPurchaseOrderItemItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithPurchaseOrderItemItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithPurchaseOrderItemItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithPurchaseOrderItemItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
