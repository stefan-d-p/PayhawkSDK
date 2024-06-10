// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Details for an expense payment fees
    /// </summary>
    public class IExpensePaymentFees : IParsable
    {
        /// <summary>Amount of bank transaction fees</summary>
        public float? Bank { get; set; }
        /// <summary>Amount of currency exchange fees</summary>
        public float? Fx { get; set; }
        /// <summary>Amount of POS transaction fees</summary>
        public float? Pos { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IExpensePaymentFees"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IExpensePaymentFees CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IExpensePaymentFees();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bank", n => { Bank = n.GetFloatValue(); } },
                { "fx", n => { Fx = n.GetFloatValue(); } },
                { "pos", n => { Pos = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("bank", Bank);
            writer.WriteFloatValue("fx", Fx);
            writer.WriteFloatValue("pos", Pos);
        }
    }
}