public class Order
{
    private float _shippingCostUSA;
    private float _foreignShippingCost;

    private List<Product> _products;



    public Order(float shippingCostUSA = 5, float foreignShippingCost = 35, List<Product> products = null)
    {
        _shippingCostUSA = shippingCostUSA;
        _foreignShippingCost = foreignShippingCost;
        _products = products ?? new List<Product>(); // Initialize with the provided list or a new list if null
    }
    
    public string CalculateTotalCost(Address address)
    {
        double totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.CalculateProductTotalCost();
        }
        if (address.AddressAmericanOrNot())
        {
            totalCost += _shippingCostUSA;
        }
        else
        {
            totalCost += _foreignShippingCost;
        }

        return $"${totalCost:F2}";
    }

    public  



}