namespace CSharpClassLibrary.Models;

public sealed class PriceQuote
{
    public decimal Subtotal { get; init; }
    public decimal Discount { get; init; }
    public decimal Total { get; init; }
}
