// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.Item;
using PayhawkSDK.Client.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\accounts\{accountId}\custom-fields\{customFieldId}\values
    /// </summary>
    public class ValuesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the PayhawkSDK.Client.api.v3.accounts.item.customFields.item.values.item collection</summary>
        /// <param name="position">Identifier of the custom field value</param>
        /// <returns>A <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.Item.WithCustomFieldValueItemRequestBuilder"/></returns>
        public PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.Item.WithCustomFieldValueItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("customFieldValueId", position);
                return new PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.Item.WithCustomFieldValueItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.ValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/custom-fields/{customFieldId}/values", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.ValuesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/accounts/{accountId}/custom-fields/{customFieldId}/values", rawUrl)
        {
        }
        /// <summary>
        /// Deletes all values for a custom field
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
        /// Returns the custom field values
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ICustomFieldValuesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 404 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PayhawkSDK.Client.Models.ICustomFieldValuesResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PayhawkSDK.Client.Models.ICustomFieldValuesResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<PayhawkSDK.Client.Models.ICustomFieldValuesResponse>(requestInfo, PayhawkSDK.Client.Models.ICustomFieldValuesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the created custom field value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ICustomFieldValue"/></returns>
        /// <param name="body">Custom field value object without autogenerated fields</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 400 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 401 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 403 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 404 status code</exception>
        /// <exception cref="PayhawkSDK.Client.Models.IError">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PayhawkSDK.Client.Models.ICustomFieldValue?> PostAsync(PayhawkSDK.Client.Models.INewCustomFieldValue body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PayhawkSDK.Client.Models.ICustomFieldValue> PostAsync(PayhawkSDK.Client.Models.INewCustomFieldValue body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<PayhawkSDK.Client.Models.ICustomFieldValue>(requestInfo, PayhawkSDK.Client.Models.ICustomFieldValue.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes all values for a custom field
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
        /// Returns the custom field values
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
        /// Returns the created custom field value
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Custom field value object without autogenerated fields</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(PayhawkSDK.Client.Models.INewCustomFieldValue body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(PayhawkSDK.Client.Models.INewCustomFieldValue body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.ValuesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.ValuesRequestBuilder WithUrl(string rawUrl)
        {
            return new PayhawkSDK.Client.Api.V3.Accounts.Item.CustomFields.Item.Values.ValuesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ValuesRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ValuesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ValuesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}