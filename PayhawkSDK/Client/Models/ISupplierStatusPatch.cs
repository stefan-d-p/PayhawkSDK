// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Supplier status update
    /// </summary>
    public class ISupplierStatusPatch : IParsable
    {
        /// <summary>The new status of the supplier</summary>
        public PayhawkSDK.Client.Models.ISupplierStatusPatch_status? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ISupplierStatusPatch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.ISupplierStatusPatch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.ISupplierStatusPatch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "status", n => { Status = n.GetEnumValue<PayhawkSDK.Client.Models.ISupplierStatusPatch_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PayhawkSDK.Client.Models.ISupplierStatusPatch_status>("status", Status);
        }
    }
}