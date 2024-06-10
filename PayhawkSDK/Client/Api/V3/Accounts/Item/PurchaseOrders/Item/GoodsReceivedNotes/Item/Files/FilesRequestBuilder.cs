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
namespace PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\accounts\{accountId}\purchase-orders\{purchaseOrderId}\goods-received-notes\{goodsReceivedNoteId}\files
    /// </summary>
    public class FilesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/purchase-orders/{purchaseOrderId}/goods-received-notes/{goodsReceivedNoteId}/files", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/purchase-orders/{purchaseOrderId}/goods-received-notes/{goodsReceivedNoteId}/files", rawUrl)
        {
        }
        /// <summary>
        /// Upload a file and attach it to a specific goods received note.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 404 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
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
        /// Upload a file and attach it to a specific goods received note.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesRequestBuilder WithUrl(string rawUrl)
        {
            return new PayhawkSDK.Client.Api.V3.Accounts.Item.PurchaseOrders.Item.GoodsReceivedNotes.Item.Files.FilesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FilesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
