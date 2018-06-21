// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Supplies monetary amounts
    /// </summary>
    public partial class PaymentCurrencyAmount
    {
        /// <summary>
        /// Initializes a new instance of the PaymentCurrencyAmount class.
        /// </summary>
        public PaymentCurrencyAmount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaymentCurrencyAmount class.
        /// </summary>
        /// <param name="currency">A currency identifier</param>
        /// <param name="value">Decimal monetary value</param>
        /// <param name="currencySystem">Currency system</param>
        public PaymentCurrencyAmount(string currency = default(string), string value = default(string), string currencySystem = default(string))
        {
            Currency = currency;
            Value = value;
            CurrencySystem = currencySystem;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a currency identifier
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets decimal monetary value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets currency system
        /// </summary>
        [JsonProperty(PropertyName = "currencySystem")]
        public string CurrencySystem { get; set; }

    }
}
