public class Product 
{
    private string _productName;
    private int _productId;
    private double _pricePerUnit;
    private int _productQuantity;

    public Product(string productName, int productId, double pricePerUnit, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _productQuantity = productQuantity;
    }

    public string CalculateProductTotalCost() //calculates and displays  product total cost.
    {
        double productTotalCost = _productQuantity * _pricePerUnit;
        return $"${productTotalCost:F2}";  
    }

   

}