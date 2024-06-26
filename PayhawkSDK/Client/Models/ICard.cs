// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Payhawk card object
    /// </summary>
    public class ICard : IParsable
    {
        /// <summary>Approved funds for the current period</summary>
        public float? ApprovedFunds { get; set; }
        /// <summary>Available funds in the card</summary>
        public float? BudgetLeft { get; set; }
        /// <summary>Date the card was created</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Currency of the card</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Object representing an address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IAddress? DeliveryAddress { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IAddress DeliveryAddress { get; set; }
#endif
        /// <summary>Name of the cardholder printed on the physical card</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmbossName { get; set; }
#nullable restore
#else
        public string EmbossName { get; set; }
#endif
        /// <summary>Unique identifier of the fund account the card is linked to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundAccountId { get; set; }
#nullable restore
#else
        public string FundAccountId { get; set; }
#endif
        /// <summary>Unique identifier of the card</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Indicates if the card can be used with an ATM</summary>
        public bool? IsAtmAllowed { get; set; }
        /// <summary>Indicates if the card is physical. If set to false, the card is virtual</summary>
        public bool? IsPhysical { get; set; }
        /// <summary>Recurring monthly limit of the card</summary>
        public float? Limit { get; set; }
        /// <summary>Name of the card. Useful for differentiating cards</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Spent amount in the current period</summary>
        public float? SpentAmount { get; set; }
        /// <summary>Status of the card</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>Unique identifier of the cardholder</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ICard"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.ICard CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.ICard();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "approvedFunds", n => { ApprovedFunds = n.GetFloatValue(); } },
                { "budgetLeft", n => { BudgetLeft = n.GetFloatValue(); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "deliveryAddress", n => { DeliveryAddress = n.GetObjectValue<PayhawkSDK.Client.Models.IAddress>(PayhawkSDK.Client.Models.IAddress.CreateFromDiscriminatorValue); } },
                { "embossName", n => { EmbossName = n.GetStringValue(); } },
                { "fundAccountId", n => { FundAccountId = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "isAtmAllowed", n => { IsAtmAllowed = n.GetBoolValue(); } },
                { "isPhysical", n => { IsPhysical = n.GetBoolValue(); } },
                { "limit", n => { Limit = n.GetFloatValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "spentAmount", n => { SpentAmount = n.GetFloatValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("approvedFunds", ApprovedFunds);
            writer.WriteFloatValue("budgetLeft", BudgetLeft);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("currency", Currency);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IAddress>("deliveryAddress", DeliveryAddress);
            writer.WriteStringValue("embossName", EmbossName);
            writer.WriteStringValue("fundAccountId", FundAccountId);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isAtmAllowed", IsAtmAllowed);
            writer.WriteBoolValue("isPhysical", IsPhysical);
            writer.WriteFloatValue("limit", Limit);
            writer.WriteStringValue("name", Name);
            writer.WriteFloatValue("spentAmount", SpentAmount);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
