// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace PayhawkSDK.Client.Models
{
    /// <summary>Status of the payment</summary>
    public enum IExpensePayment_status
    {
        [EnumMember(Value = "pending")]
        #pragma warning disable CS1591
        Pending,
        #pragma warning restore CS1591
        [EnumMember(Value = "settled")]
        #pragma warning disable CS1591
        Settled,
        #pragma warning restore CS1591
        [EnumMember(Value = "failed")]
        #pragma warning disable CS1591
        Failed,
        #pragma warning restore CS1591
        [EnumMember(Value = "reverted")]
        #pragma warning disable CS1591
        Reverted,
        #pragma warning restore CS1591
        [EnumMember(Value = "expired")]
        #pragma warning disable CS1591
        Expired,
        #pragma warning restore CS1591
    }
}