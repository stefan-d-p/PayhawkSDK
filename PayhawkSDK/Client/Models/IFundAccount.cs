// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Payhawk fund account object
    /// </summary>
    public class IFundAccount : IParsable
    {
        /// <summary>Currency of the fund account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Unique identifier of the fund account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Status of the fund account</summary>
        public PayhawkSDK.Client.Models.IFundAccount_status? Status { get; set; }
        /// <summary>Type of the fund account, for example debit or credit</summary>
        public PayhawkSDK.Client.Models.IFundAccount_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IFundAccount"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IFundAccount CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IFundAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<PayhawkSDK.Client.Models.IFundAccount_status>(); } },
                { "type", n => { Type = n.GetEnumValue<PayhawkSDK.Client.Models.IFundAccount_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IFundAccount_status>("status", Status);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IFundAccount_type>("type", Type);
        }
    }
}
