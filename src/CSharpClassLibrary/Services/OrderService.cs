namespace CSharpClassLibrary.Services;

public interface IOrderService
{
    string GetWelcomeMessage();
    decimal CalculateTotal(int quantity, decimal unitPrice, decimal discountPercent);
    bool IsEligibleForFreeShipping(int orderTotal);
}

public sealed class OrderService : IOrderService
{
    public string GetWelcomeMessage() => "Class library monolith (net9)";

    public decimal CalculateTotal(int quantity, decimal unitPrice, decimal discountPercent)
    {
        var subtotal = quantity * unitPrice;
        return subtotal - (subtotal * discountPercent / 100m);
    }

    public bool IsEligibleForFreeShipping(int orderTotal) => orderTotal >= 50;
}
