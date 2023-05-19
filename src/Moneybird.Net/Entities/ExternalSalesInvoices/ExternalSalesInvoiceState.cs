using System.Text.Json.Serialization;

namespace Moneybird.Net.Entities.SalesInvoices
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ExternalSalesInvoiceState
    {
        [JsonPropertyName("all")]
        All,
        
        [JsonPropertyName("new")]
        New,
        
        [JsonPropertyName("open")]
        Open,
        
        [JsonPropertyName("late")]
        Late,
        
        [JsonPropertyName("paid")]
        Paid
    }
}
