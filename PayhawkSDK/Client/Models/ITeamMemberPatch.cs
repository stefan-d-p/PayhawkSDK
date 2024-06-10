// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Object, that is used for update of the team member object
    /// </summary>
    public class ITeamMemberPatch : IParsable
    {
        /// <summary>Roles granted to the team member</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.ITeamMemberPatch_roles?>? Roles { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.ITeamMemberPatch_roles?> Roles { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.ITeamMemberPatch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.ITeamMemberPatch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.ITeamMemberPatch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "roles", n => { Roles = n.GetCollectionOfEnumValues<PayhawkSDK.Client.Models.ITeamMemberPatch_roles>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<PayhawkSDK.Client.Models.ITeamMemberPatch_roles>("roles", Roles);
        }
    }
}
