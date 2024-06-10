// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Custom field data object
    /// </summary>
    public class ICustomFieldData : IParsable
    {
        /// <summary>Unique identifier of the custom field in the external system</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>Unique identifier of the external system the field originates from</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalSource { get; set; }
#nullable restore
#else
        public string ExternalSource { get; set; }
#endif
        /// <summary>Unique identifier of the custom field</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Label of the custom field</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>Array of selected values from a predefined list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.ICustomFieldDataValue>? SelectedValues { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.ICustomFieldDataValue> SelectedValues { get; set; }
#endif
        /// <summary>Free text value. Used for text input custom fields</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ICustomFieldData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.ICustomFieldData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.ICustomFieldData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "externalSource", n => { ExternalSource = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "selectedValues", n => { SelectedValues = n.GetCollectionOfObjectValues<PayhawkSDK.Client.Models.ICustomFieldDataValue>(PayhawkSDK.Client.Models.ICustomFieldDataValue.CreateFromDiscriminatorValue)?.ToList(); } },
                { "value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("externalSource", ExternalSource);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("label", Label);
            writer.WriteCollectionOfObjectValues<PayhawkSDK.Client.Models.ICustomFieldDataValue>("selectedValues", SelectedValues);
            writer.WriteStringValue("value", Value);
        }
    }
}