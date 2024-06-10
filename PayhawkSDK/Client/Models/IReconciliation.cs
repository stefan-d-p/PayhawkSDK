// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Reconciliation details
    /// </summary>
    public class IReconciliation : IParsable
    {
        /// <summary>Account code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountCode { get; set; }
#nullable restore
#else
        public string AccountCode { get; set; }
#endif
        /// <summary>Base currency in which expenses are reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseCurrency { get; set; }
#nullable restore
#else
        public string BaseCurrency { get; set; }
#endif
        /// <summary>Tax amount in base currency calculated against the official exchange rate</summary>
        public float? BaseTaxAmount { get; set; }
        /// <summary>Total amount in base currency calculated against the official exchange rate</summary>
        public float? BaseTotalAmount { get; set; }
        /// <summary>The paid currency</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Array of custom fields and their values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.ICustomFieldData>? CustomFields { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.ICustomFieldData> CustomFields { get; set; }
#endif
        /// <summary>Exchange rate to Payhawk base currency</summary>
        public float? FxRate { get; set; }
        /// <summary>Exchange rate to payment currency, if different than expense currency</summary>
        public float? FxRateToPaymentCurrency { get; set; }
        /// <summary>Tax amount in the paid currency</summary>
        public float? TaxAmount { get; set; }
        /// <summary>Total amount in the paid currency</summary>
        public float? TotalAmount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IReconciliation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IReconciliation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IReconciliation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accountCode", n => { AccountCode = n.GetStringValue(); } },
                { "baseCurrency", n => { BaseCurrency = n.GetStringValue(); } },
                { "baseTaxAmount", n => { BaseTaxAmount = n.GetFloatValue(); } },
                { "baseTotalAmount", n => { BaseTotalAmount = n.GetFloatValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "customFields", n => { CustomFields = n.GetCollectionOfObjectValues<PayhawkSDK.Client.Models.ICustomFieldData>(PayhawkSDK.Client.Models.ICustomFieldData.CreateFromDiscriminatorValue)?.ToList(); } },
                { "fxRate", n => { FxRate = n.GetFloatValue(); } },
                { "fxRateToPaymentCurrency", n => { FxRateToPaymentCurrency = n.GetFloatValue(); } },
                { "taxAmount", n => { TaxAmount = n.GetFloatValue(); } },
                { "totalAmount", n => { TotalAmount = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountCode", AccountCode);
            writer.WriteStringValue("baseCurrency", BaseCurrency);
            writer.WriteFloatValue("baseTaxAmount", BaseTaxAmount);
            writer.WriteFloatValue("baseTotalAmount", BaseTotalAmount);
            writer.WriteStringValue("currency", Currency);
            writer.WriteCollectionOfObjectValues<PayhawkSDK.Client.Models.ICustomFieldData>("customFields", CustomFields);
            writer.WriteFloatValue("fxRate", FxRate);
            writer.WriteFloatValue("fxRateToPaymentCurrency", FxRateToPaymentCurrency);
            writer.WriteFloatValue("taxAmount", TaxAmount);
            writer.WriteFloatValue("totalAmount", TotalAmount);
        }
    }
}
