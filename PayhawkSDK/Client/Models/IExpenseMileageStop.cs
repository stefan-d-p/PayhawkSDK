// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Expense Mileage Stop object
    /// </summary>
    public class IExpenseMileageStop : IParsable
    {
        /// <summary>The coordinates for the given route stop</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IExpenseMileageStopCoordinates? Coordinates { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IExpenseMileageStopCoordinates Coordinates { get; set; }
#endif
        /// <summary>The label for the given route stop</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IExpenseMileageStop"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IExpenseMileageStop CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IExpenseMileageStop();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "coordinates", n => { Coordinates = n.GetObjectValue<PayhawkSDK.Client.Models.IExpenseMileageStopCoordinates>(PayhawkSDK.Client.Models.IExpenseMileageStopCoordinates.CreateFromDiscriminatorValue); } },
                { "label", n => { Label = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IExpenseMileageStopCoordinates>("coordinates", Coordinates);
            writer.WriteStringValue("label", Label);
        }
    }
}
