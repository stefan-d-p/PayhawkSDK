// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Purchase order object
    /// </summary>
    public class IPurchaseOrder : IParsable
    {
        /// <summary>Based on the status this object may represent either the person who approved the PO or the one who rejected/returned it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IPurchaseOrder_approvalProcessState? ApprovalProcessState { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IPurchaseOrder_approvalProcessState ApprovalProcessState { get; set; }
#endif
        /// <summary>Date the purchase order was created</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The person who approved/rejected/returned the purchase order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IBasicActor? CreatedBy { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IBasicActor CreatedBy { get; set; }
#endif
        /// <summary>Currency of the purchase order</summary>
        public PayhawkSDK.Client.Models.IPurchaseOrder_currency? Currency { get; set; }
        /// <summary>Unique identifier of the purchase order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The total invoiced amount (sum of all expenses total amounts) in the currency of the purchase order.</summary>
        public float? InvoicedAmount { get; set; }
        /// <summary>Represent the difference between the purchase order total amount and the invoiced amount.</summary>
        public PayhawkSDK.Client.Models.IPurchaseOrder_invoicedAmountStatus? InvoicedAmountStatus { get; set; }
        /// <summary>List of purchase order items</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.IPurchaseOrderItem>? Items { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.IPurchaseOrderItem> Items { get; set; }
#endif
        /// <summary>Note from the creator of the purchase order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>The sum of all purchase order items purchaseAmount property.</summary>
        public float? PurchasedAmount { get; set; }
        /// <summary>Purchase Order Number. If not passed, it is autogenerated based on the settings set for the account on approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurchaseOrderNumber { get; set; }
#nullable restore
#else
        public string PurchaseOrderNumber { get; set; }
#endif
        /// <summary>Represents the difference between the expected quantity and the received quantity for the purchase order. Applicable only when the PO is of type `receipt_note`.</summary>
        public PayhawkSDK.Client.Models.IPurchaseOrder_receivedQuantityStatus? ReceivedQuantityStatus { get; set; }
        /// <summary>Status of the purchase order</summary>
        public PayhawkSDK.Client.Models.IPurchaseOrder_status? Status { get; set; }
        /// <summary>Supplier details</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.ISupplier? Supplier { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.ISupplier Supplier { get; set; }
#endif
        /// <summary>User-friendly title of the purchase order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>Item type of the purchase order</summary>
        public PayhawkSDK.Client.Models.IPurchaseOrder_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IPurchaseOrder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IPurchaseOrder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IPurchaseOrder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "approvalProcessState", n => { ApprovalProcessState = n.GetObjectValue<PayhawkSDK.Client.Models.IPurchaseOrder_approvalProcessState>(PayhawkSDK.Client.Models.IPurchaseOrder_approvalProcessState.CreateFromDiscriminatorValue); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<PayhawkSDK.Client.Models.IBasicActor>(PayhawkSDK.Client.Models.IBasicActor.CreateFromDiscriminatorValue); } },
                { "currency", n => { Currency = n.GetEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_currency>(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "invoicedAmount", n => { InvoicedAmount = n.GetFloatValue(); } },
                { "invoicedAmountStatus", n => { InvoicedAmountStatus = n.GetEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_invoicedAmountStatus>(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<PayhawkSDK.Client.Models.IPurchaseOrderItem>(PayhawkSDK.Client.Models.IPurchaseOrderItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "purchaseOrderNumber", n => { PurchaseOrderNumber = n.GetStringValue(); } },
                { "purchasedAmount", n => { PurchasedAmount = n.GetFloatValue(); } },
                { "receivedQuantityStatus", n => { ReceivedQuantityStatus = n.GetEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_receivedQuantityStatus>(); } },
                { "status", n => { Status = n.GetEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_status>(); } },
                { "supplier", n => { Supplier = n.GetObjectValue<PayhawkSDK.Client.Models.ISupplier>(PayhawkSDK.Client.Models.ISupplier.CreateFromDiscriminatorValue); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IPurchaseOrder_approvalProcessState>("approvalProcessState", ApprovalProcessState);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IBasicActor>("createdBy", CreatedBy);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_currency>("currency", Currency);
            writer.WriteStringValue("id", Id);
            writer.WriteFloatValue("invoicedAmount", InvoicedAmount);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_invoicedAmountStatus>("invoicedAmountStatus", InvoicedAmountStatus);
            writer.WriteCollectionOfObjectValues<PayhawkSDK.Client.Models.IPurchaseOrderItem>("items", Items);
            writer.WriteStringValue("note", Note);
            writer.WriteFloatValue("purchasedAmount", PurchasedAmount);
            writer.WriteStringValue("purchaseOrderNumber", PurchaseOrderNumber);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_receivedQuantityStatus>("receivedQuantityStatus", ReceivedQuantityStatus);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_status>("status", Status);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.ISupplier>("supplier", Supplier);
            writer.WriteStringValue("title", Title);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IPurchaseOrder_type>("type", Type);
        }
    }
}
