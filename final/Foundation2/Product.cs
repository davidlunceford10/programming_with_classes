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

    public double CalculateProductTotalCost() //calculates and displays  product total cost.
    {
        double productTotalCost = _productQuantity * _pricePerUnit;
        return productTotalCost;
    }

   public string DisplayProductPackingLabel()
   {
        return $"Product Name: {_productName} - Product ID: {_productId}";
   }

}