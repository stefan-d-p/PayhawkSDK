// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.Status;
using PayhawkSDK.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\accounts\{accountId}\cards\{cardId}
    /// </summary>
    public class WithCardItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The status property</summary>
        public PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.Status.StatusRequestBuilder Status
        {
            get => new PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.Status.StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.WithCardItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCardItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/cards/{cardId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.WithCardItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCardItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/cards/{cardId}", rawUrl)
        {
        }
        /// <summary>
        /// Returns card by id
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ICard"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 404 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PayhawkSDK.Client.Models.ICard?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PayhawkSDK.Client.Models.ICard> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "401", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "403", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "404", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "429", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<PayhawkSDK.Client.Models.ICard>(requestInfo, PayhawkSDK.Client.Models.ICard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Partially updates a card with the provided fields. Returns the updated card
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ICard"/></returns>
        /// <param name="body">Payhawk card patch object used for partial update of a card</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 404 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PayhawkSDK.Client.Models.ICard?> PatchAsync(PayhawkSDK.Client.Models.ICardPatch body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PayhawkSDK.Client.Models.ICard> PatchAsync(PayhawkSDK.Client.Models.ICardPatch body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "401", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "403", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "404", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
                { "429", PayhawkSDK.Client.Models.IError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<PayhawkSDK.Client.Models.ICard>(requestInfo, PayhawkSDK.Client.Models.ICard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns card by id
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
        /// Partially updates a card with the provided fields. Returns the updated card
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Payhawk card patch object used for partial update of a card</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(PayhawkSDK.Client.Models.ICardPatch body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(PayhawkSDK.Client.Models.ICardPatch body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.WithCardItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.WithCardItemRequestBuilder WithUrl(string rawUrl)
        {
            return new PayhawkSDK.Client.Api.V3.Accounts.Item.Cards.Item.WithCardItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithCardItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithCardItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}