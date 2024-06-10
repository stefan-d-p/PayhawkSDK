// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>
    /// Payhawk expense object
    /// </summary>
    public class IExpense : IParsable
    {
        /// <summary>Amortization information</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IAmortization? Amortization { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IAmortization Amortization { get; set; }
#endif
        /// <summary>Expense category object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IExpenseCategory? Category { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IExpenseCategory Category { get; set; }
#endif
        /// <summary>Date the expense was created</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Actor user that last approved the expense</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IActor? CreatedBy { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IActor CreatedBy { get; set; }
#endif
        /// <summary>Document information for the expense</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IExpenseDocument? Document { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IExpenseDocument Document { get; set; }
#endif
        /// <summary>Array of links to external system records</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.IExternalLink>? ExternalLinks { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.IExternalLink> ExternalLinks { get; set; }
#endif
        /// <summary>Unique identifier of the expense</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Indicates if the expense is paid</summary>
        public bool? IsPaid { get; set; }
        /// <summary>Array of expense&apos;s line items</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PayhawkSDK.Client.Models.ILineItem>? LineItems { get; set; }
#nullable restore
#else
        public List<PayhawkSDK.Client.Models.ILineItem> LineItems { get; set; }
#endif
        /// <summary>Mileage information</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IExpenseMileage? Mileage { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IExpenseMileage Mileage { get; set; }
#endif
        /// <summary>Note from the cardholder of the expense as submitted by the Payhawk mobile app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>Per Diem information</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IExpensePerDiem? PerDiem { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IExpensePerDiem PerDiem { get; set; }
#endif
        /// <summary>Reconciliation details</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IReconciliation? Reconciliation { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IReconciliation Reconciliation { get; set; }
#endif
        /// <summary>Date the expense was reviewed</summary>
        public DateTimeOffset? ReviewedAt { get; set; }
        /// <summary>Date the expense was settled</summary>
        public DateTimeOffset? SettledAt { get; set; }
        /// <summary>Status of the expense</summary>
        public PayhawkSDK.Client.Models.IExpense_status? Status { get; set; }
        /// <summary>Backwards compatible object containing all available information about the supplier for this expense</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.IExpenseSupplier? Supplier { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.IExpenseSupplier Supplier { get; set; }
#endif
        /// <summary>Tax rate object without autogenerated fields</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayhawkSDK.Client.Models.INewTaxRate? TaxRate { get; set; }
#nullable restore
#else
        public PayhawkSDK.Client.Models.INewTaxRate TaxRate { get; set; }
#endif
        /// <summary>User-friendly title of the expense</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>Type of the expense payment</summary>
        public PayhawkSDK.Client.Models.IExpense_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayhawkSDK.Client.Models.IExpense"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayhawkSDK.Client.Models.IExpense CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayhawkSDK.Client.Models.IExpense();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amortization", n => { Amortization = n.GetObjectValue<PayhawkSDK.Client.Models.IAmortization>(PayhawkSDK.Client.Models.IAmortization.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetObjectValue<PayhawkSDK.Client.Models.IExpenseCategory>(PayhawkSDK.Client.Models.IExpenseCategory.CreateFromDiscriminatorValue); } },
                { "createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<PayhawkSDK.Client.Models.IActor>(PayhawkSDK.Client.Models.IActor.CreateFromDiscriminatorValue); } },
                { "document", n => { Document = n.GetObjectValue<PayhawkSDK.Client.Models.IExpenseDocument>(PayhawkSDK.Client.Models.IExpenseDocument.CreateFromDiscriminatorValue); } },
                { "externalLinks", n => { ExternalLinks = n.GetCollectionOfObjectValues<PayhawkSDK.Client.Models.IExternalLink>(PayhawkSDK.Client.Models.IExternalLink.CreateFromDiscriminatorValue)?.ToList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "isPaid", n => { IsPaid = n.GetBoolValue(); } },
                { "lineItems", n => { LineItems = n.GetCollectionOfObjectValues<PayhawkSDK.Client.Models.ILineItem>(PayhawkSDK.Client.Models.ILineItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "mileage", n => { Mileage = n.GetObjectValue<PayhawkSDK.Client.Models.IExpenseMileage>(PayhawkSDK.Client.Models.IExpenseMileage.CreateFromDiscriminatorValue); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "perDiem", n => { PerDiem = n.GetObjectValue<PayhawkSDK.Client.Models.IExpensePerDiem>(PayhawkSDK.Client.Models.IExpensePerDiem.CreateFromDiscriminatorValue); } },
                { "reconciliation", n => { Reconciliation = n.GetObjectValue<PayhawkSDK.Client.Models.IReconciliation>(PayhawkSDK.Client.Models.IReconciliation.CreateFromDiscriminatorValue); } },
                { "reviewedAt", n => { ReviewedAt = n.GetDateTimeOffsetValue(); } },
                { "settledAt", n => { SettledAt = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<PayhawkSDK.Client.Models.IExpense_status>(); } },
                { "supplier", n => { Supplier = n.GetObjectValue<PayhawkSDK.Client.Models.IExpenseSupplier>(PayhawkSDK.Client.Models.IExpenseSupplier.CreateFromDiscriminatorValue); } },
                { "taxRate", n => { TaxRate = n.GetObjectValue<PayhawkSDK.Client.Models.INewTaxRate>(PayhawkSDK.Client.Models.INewTaxRate.CreateFromDiscriminatorValue); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<PayhawkSDK.Client.Models.IExpense_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IAmortization>("amortization", Amortization);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IExpenseCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IActor>("createdBy", CreatedBy);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IExpenseDocument>("document", Document);
            writer.WriteCollectionOfObjectValues<PayhawkSDK.Client.Models.IExternalLink>("externalLinks", ExternalLinks);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isPaid", IsPaid);
            writer.WriteCollectionOfObjectValues<PayhawkSDK.Client.Models.ILineItem>("lineItems", LineItems);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IExpenseMileage>("mileage", Mileage);
            writer.WriteStringValue("note", Note);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IExpensePerDiem>("perDiem", PerDiem);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IReconciliation>("reconciliation", Reconciliation);
            writer.WriteDateTimeOffsetValue("reviewedAt", ReviewedAt);
            writer.WriteDateTimeOffsetValue("settledAt", SettledAt);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IExpense_status>("status", Status);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.IExpenseSupplier>("supplier", Supplier);
            writer.WriteObjectValue<PayhawkSDK.Client.Models.INewTaxRate>("taxRate", TaxRate);
            writer.WriteStringValue("title", Title);
            writer.WriteEnumValue<PayhawkSDK.Client.Models.IExpense_type>("type", Type);
        }
    }
}