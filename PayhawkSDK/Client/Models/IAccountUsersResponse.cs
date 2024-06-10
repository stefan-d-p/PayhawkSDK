// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Response of multiple IAccountUser objects
    /// </summary>
    public class IAccountUsersResponse : IParsable
    {
        /// <summary>Array of IAccountUser objects</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.IAccountUser>? Items { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.IAccountUser> Items { get; set; }
#endif
        /// <summary>Total count of objects. If using pagination, this is the sum of all pages</summary>
        public float? Total { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IAccountUsersResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IAccountUsersResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IAccountUsersResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "items", n => { Items = n.GetCollectionOfObjectValues<PayhawkSDK.Client.Models.IAccountUser>(PayhawkSDK.Client.Models.IAccountUser.CreateFromDiscriminatorValue)?.ToList(); } },
                { "total", n => { Total = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PayhawkSDK.Client.Models.IAccountUser>("items", Items);
            writer.WriteFloatValue("total", Total);
        }
    }
}
