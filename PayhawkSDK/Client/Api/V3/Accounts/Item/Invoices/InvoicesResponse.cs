// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Api.V3.Accounts.Item.Invoices
{
    [Obsolete("This class is obsolete. Use InvoicesPostResponse instead.")]
    #pragma warning disable CS1591
    public class InvoicesResponse : PayhawkSDK.Client.Api.V3.Accounts.Item.Invoices.InvoicesPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Api.V3.Accounts.Item.Invoices.InvoicesResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PayhawkSDK.Client.Api.V3.Accounts.Item.Invoices.InvoicesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Api.V3.Accounts.Item.Invoices.InvoicesResponse();
        }
    }
}
