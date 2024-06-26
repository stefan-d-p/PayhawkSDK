// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// The applied rates for this trip
    /// </summary>
    public class IExpenseMileageRate : IParsable
    {
        /// <summary>The accumulated mileage for a calendar. Does not include the created mileage expense distance</summary>
        public float? AccumulatedMilage { get; set; }
        /// <summary>The applied rates</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IExpenseMileageRate_rates? Rates { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IExpenseMileageRate_rates Rates { get; set; }
#endif
        /// <summary>The threshold definitions for the given rate</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ThresholdDefinitions { get; set; }
#nullable restore
#else
        public List<string> ThresholdDefinitions { get; set; }
#endif
        /// <summary>The threshold type of the given rate</summary>
        public PayhawkSDK.Client.Models.IExpenseMileageRate_thresholdType? ThresholdType { get; set; }
        /// <summary>The type of the given rate</summary>
        public PayhawkSDK.Client.Models.IExpenseMileageRate_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IExpenseMileageRate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IExpenseMileageRate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IExpenseMileageRate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accumulatedMilage", n => { AccumulatedMilage = n.GetFloatValue(); } },
                { "rates", n => { Rates = n.GetObjectValue<PayhawkSDK.Client.Models.IExpenseMileageRate_rates>(PayhawkSDK.Client.Models.IExpenseMileageRate_rates.CreateFromDiscriminatorValue); } },
                { "thresholdDefinitions", n => { ThresholdDefinitions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "thresholdType", n => { ThresholdType = n.GetEnumValue<PayhawkSDK.Client.Models.IExpenseMileageRate_thresholdType>(); } },
                { "type", n => { Type = n.GetEnumValue<PayhawkSDK.Client.Models.IExpenseMileageRate_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("accumulatedMilage", AccumulatedMilage);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IExpenseMileageRate_rates>("rates", Rates);
            writer.WriteCollectionOfPrimitiveValues<string>("thresholdDefinitions", ThresholdDefinitions);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IExpenseMileageRate_thresholdType>("thresholdType", ThresholdType);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IExpenseMileageRate_type>("type", Type);
        }
    }
}
