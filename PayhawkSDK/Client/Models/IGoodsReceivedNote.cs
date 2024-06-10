// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Purchase order goods received note object
    /// </summary>
    public class IGoodsReceivedNote : IParsable
    {
        /// <summary>Date the GRN was created</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Details of the uploaded document</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IGoodsReceivedNoteDocument? Document { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IGoodsReceivedNoteDocument Document { get; set; }
#endif
        /// <summary>Id of the GRN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Description of the goods received</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>List of purchase order items and the quantities received</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.IGoodsReceivedNoteItemQuantity>? Quantities { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.IGoodsReceivedNoteItemQuantity> Quantities { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IGoodsReceivedNote"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IGoodsReceivedNote CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IGoodsReceivedNote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "document", n => { Document = n.GetObjectValue<PayhawkSDK.Client.Models.IGoodsReceivedNoteDocument>(PayhawkSDK.Client.Models.IGoodsReceivedNoteDocument.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "quantities", n => { Quantities = n.GetCollectionOfObjectValues<PayhawkSDK.Client.Models.IGoodsReceivedNoteItemQuantity>(PayhawkSDK.Client.Models.IGoodsReceivedNoteItemQuantity.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IGoodsReceivedNoteDocument>("document", Document);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("note", Note);
            writer.WriteCollectionOfObjectValues<PayhawkSDK.Client.Models.IGoodsReceivedNoteItemQuantity>("quantities", Quantities);
        }
    }
}
