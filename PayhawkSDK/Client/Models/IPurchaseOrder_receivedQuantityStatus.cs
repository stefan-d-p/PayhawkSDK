// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>Represents the difference between the expected quantity and the received quantity for the purchase order. Applicable only when the PO is of type `receipt_note`.</summary>
    public enum IPurchaseOrder_receivedQuantityStatus
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "partial")]
        #pragma warning disable CS1591
        Partial,
        #pragma warning restore CS1591
        [EnumMember(Value = "full")]
        #pragma warning disable CS1591
        Full,
        #pragma warning restore CS1591
        [EnumMember(Value = "discrepancy")]
        #pragma warning disable CS1591
        Discrepancy,
        #pragma warning restore CS1591
    }
}